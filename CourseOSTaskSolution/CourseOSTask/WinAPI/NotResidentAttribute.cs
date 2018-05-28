using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask.WinAPI
{
    public class NotResidentAttribute
    {
        /*0x10*/
        public ulong LowestVCN { get; }
        /*0x18*/
        public ulong HighestVCN { get; }
        /*0x20*/
        //смещение списка отрезков
        public ushort MappingPairOffset { get; }
        /*0x22*/
        public byte CompressionUnit { get; }
        /*0x23*/
        public byte Reserved { get; }
        /*0x28*/
        //размер дискового пространства, которое было выделено
        //под тело атрибута
        public ulong AllocatedSize { get; }
        /*0x30*/
        //реальный размер атрибута
        public ulong DataSize { get; set; }
        /*0x38*/
        public ulong InitializedSize;
        public int StartCluster { get; set; }
        public int GroupLength { get; set; }
        public byte[] RunList { get; set; }
        public List<Segment> Clusters { get; set; }

        public override string ToString()
        {
            string result = "";

            result += "Начальный виртуальный кластер:" + LowestVCN.ToString() + "\n";
            result += "Конечный виртуальный кластер:" + HighestVCN.ToString() + "\n";
            result += "Смещение списка отрезков:" + MappingPairOffset.ToString() + "\n";
            result += "Размер блока сжатия:" + CompressionUnit.ToString() + "\n";
            result += "Выделенный размер, округленный до размера кластера:" + AllocatedSize.ToString() + "\n";
            result += "Реальный размер:" + DataSize.ToString() + "\n";
            result += "Размер тела атрибута:" + InitializedSize.ToString() + "\n";

            return result;
        }

        public NotResidentAttribute(byte[] sector, int offset)
        {
            StartCluster = -1;
            GroupLength = -1;
            LowestVCN = 0;
            for (int i = 0; i < 8; i++)
                LowestVCN += (ulong)sector[offset + 0x10 + i] << (i * 8);

            HighestVCN = 0;
            for (int i = 0; i < 8; i++)
                HighestVCN += (ulong)sector[offset + 0x18 + i] << (i * 8);

            MappingPairOffset = 0;
            for (int i = 0; i < 4; i++)
                MappingPairOffset += (ushort)(sector[offset + 0x20 + i] << (i * 8));

            CompressionUnit = sector[offset + 0x22];

            Reserved = sector[offset + 0x23];

            AllocatedSize = 0;
            for (int i = 0; i < 8; i++)
                AllocatedSize += (ulong)sector[offset + 0x28 + i] << (i * 8);

            DataSize = 0;
            for (int i = 0; i < 8; i++)
                DataSize += (ulong)sector[offset + 0x30 + i] << (i * 8);

            InitializedSize = 0;
            for (int i = 0; i < 8; i++)
                InitializedSize += (ulong)sector[offset + 0x38 + i] << (i * 8);

            Clusters = new List<Segment>();
        }
    }
}
