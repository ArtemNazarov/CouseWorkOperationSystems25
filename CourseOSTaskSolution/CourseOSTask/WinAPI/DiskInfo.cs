using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask.WinAPI
{
    public class DiskInfo
    {

        public SafeFileHandle Drive { get; set; }

        public BPB BPB { get; set; }

        public MFTHandle MFT { get; set; }

        public DiskInfo(string drive)
        {
            drive = "\\\\.\\" + drive;

            // Создание дескриптора файла для чтения с диска
            Drive = HandleDriveAPI.CreateFile(
                drive,
                HandleDriveAPI.GENERIC_READ,
                HandleDriveAPI.FILE_SHARE_READ | HandleDriveAPI.FILE_SHARE_WRITE,
                IntPtr.Zero,
                HandleDriveAPI.OPEN_EXISTING,
                0,
                IntPtr.Zero
                );
            if (Drive.IsInvalid)
            {
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            }
            // считываем блок параметров БИОС
            BPB = new BPB(Drive);
            // считываем первую запись МФТ
            MFT = GetFirstMFT();
        }


        private unsafe byte[] _ReadSector(int sectorNum)
        {
            byte[] bytes = new byte[Constants.BYTE_IN_SECTOR]; 
            IntPtr BytesRead = IntPtr.Zero;
            ulong pointer = (ulong)sectorNum * (ulong)Constants.BYTE_IN_SECTOR;
            int hight = (int)(pointer >> 32);
            HandleDriveAPI.SetFilePointer(Drive, (int)(pointer & 0xffffffff), out hight, HandleDriveAPI.EMoveMethod.Begin);

            fixed (byte* ptr = bytes)
            {
                HandleDriveAPI.ReadFile(Drive, ptr, Constants.BYTE_IN_SECTOR, BytesRead, IntPtr.Zero); // Считывание сектора
            };

            HandleDriveAPI.SetFilePointer(Drive, 0, out hight, HandleDriveAPI.EMoveMethod.Begin);

            return bytes;
        }

        public byte[] ReadSector(int num)
        {
            if ((ulong)num >= BPB.SecCount)
                throw new ArgumentException($"Слишком большой номер сектора {num}. Максимальный номер сектора {BPB.SecCount}");

            return _ReadSector(num);
        }

        public string[] SectorToHex(byte[] sector)
        {
            string[] SectorHex = new string[sector.Length];

            for (int i = 0; i < sector.Length; i++)
                SectorHex[i] = BitConverter.ToString(new byte[] { sector[i] }); // Преобразование к шестнадцатиричному виду

            return SectorHex;
        }

        public byte[] ReadSectorByClusterNum(int num)
        {
            int sectorNum = num * BPB.SectorPerCluster;//* 8;
            if ((ulong)sectorNum >= BPB.SecCount)
            {
                throw new ArgumentException($"Слишком большой номер кластера {num}. Максимальный номер сектора {BPB.SecCount}");
            }

            return _ReadSector(sectorNum);
        }

        public byte[] ReadCluster(int cluster)
        {
            byte[] ByteRecord = new byte[BPB.SectorPerCluster * BPB.BytePerSec];
            for (int i = 0; i < ByteRecord.Length / 512; i++)
            {
                Array.Copy(ReadSector((int)(cluster * BPB.SectorPerCluster) + i), 0, ByteRecord, i * BPB.BytePerSec, BPB.BytePerSec); // Так как кластер состоит из нескольких секторов, чтение производится
            }                                                                                                                         // посекторно

            return ByteRecord;
        }

        public MFTHandle GetFirstMFT()
        {
            byte[] ByteRecord = new byte[(int)Math.Pow(2, BPB.ClustersPerMFT * -1)]; // массив байт, совпадающий размером с записью в МФТ, вычисляется с помощью BPB.ClustersPerMFT
            for (int i = 0; i < ByteRecord.Length / 512; i++)
            {
                Array.Copy(ReadSector((int)(BPB.FirstClusterMFT * BPB.SectorPerCluster) + i), 0, ByteRecord, i * BPB.BytePerSec, BPB.BytePerSec);
            }

            return new MFTHandle(ByteRecord, this);
        }

        public MFTHandle GetMftRecord(int indexMFT)
        {
            int mftSize = (int)Math.Pow(2, BPB.ClustersPerMFT * -1);
            int recordInCluster = BPB.SectorPerCluster * BPB.BytePerSec / mftSize;
            // Поиск номера первого сектора записи МФТ, нужна, так как возможна фрагментация МФТ 
            int sector = FindSector(indexMFT); 

            byte[] ByteRecord = new byte[mftSize];
            for (int i = 0; i < ByteRecord.Length / 512; i++)
            {
                Array.Copy(ReadSector(sector + i), 0, ByteRecord, i * BPB.BytePerSec, BPB.BytePerSec); // считываем запись
            }

            return new MFTHandle(ByteRecord, this); // Создаем и возвращаем объектное представление записи МФТ
        }


        private int FindSector(int IndexMFT)
        {
            // Размер записи МФТ
            int mftSize = (int)Math.Pow(2, BPB.ClustersPerMFT * -1);
            // Подсчет количества записей МФТ в одном кластере
            int recordInCluster = BPB.SectorPerCluster * BPB.BytePerSec / mftSize;
            // из аттрибутов первой записи МФТ выбираем аттрибут DATA
            Attribute data = MFT.Attributes.Where(n => n.Type == AttributeTypes.AT_DATA).FirstOrDefault(); 
            int prevMin = 0;
            int prevMax = 0;
            int maxRec = 0;
            int minRec = 0;
            int run = 0;
            // Для всех отрезков, в которых хранится нерезидентный атрибут DATA
            for (int i = 0; i < data.NotResidentAttr.Clusters.Count; i++) 
            {
                minRec = prevMax; // Максимальный номер записи МФТ в предыдущем отрезке (0 для первого отрезка), является минимальным номером записи в текущем отрезке
                maxRec = (int)(data.NotResidentAttr.Clusters[i].End - data.NotResidentAttr.Clusters[i].Start) * recordInCluster + prevMax;  // Максимальный номер записи МФТ в текущем отрезке
                // Если запись номер записи МФТ попадает в текущий отрезок, то запоминаем номер отрезка
                if (IndexMFT < maxRec) 
                {
                    run = i;
                    break;
                }

                prevMin = minRec;
                prevMax = maxRec;
            }
            // Вычисляем начальный сектор отрезка, в котором хранится искомая запись
            int startSectorOfCluster = (int)data.NotResidentAttr.Clusters[run].Start * BPB.SectorPerCluster;
            // вычисляем номер записи внутри отрезка
            int recordInRun = IndexMFT - minRec;
            // вычисляем первый сектор записи МФТ
            int number = startSectorOfCluster + recordInRun * (mftSize / BPB.BytePerSec); 

            return number;
        }

        // функция поиска файла в индексных элементах каталога по имени файла
        public static int FoundSubdir(MFTHandle record, string dir) 
        {
            int result = 0;
            // для всех индексных элементов каталога проверяем 
            foreach (var index in record.Indexes) 
            {
                // если имя файла совпадает с введенным, то сохраняем номер записи МФТ из индексного элемента
                if (index.FileNameString == dir) 
                    result = (int)index.IndexedFile;
            }
            // возвращаем найденный номер
            return result; 
        }
    }
}
