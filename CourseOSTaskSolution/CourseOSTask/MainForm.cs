using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using static CourseOSTask.HandlesAPI;

namespace CourseOSTask
{
    public partial class MainForm : MaterialForm
    {
        private string[] Drives { get; set; }
        private static SafeFileHandle FlashDrive;


        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            MainMenu.BackColor = materialSkinManager.ColorScheme.DarkPrimaryColor;
            MainMenu.ForeColor = materialSkinManager.ColorScheme.TextColor;
            var ffamily = materialSkinManager.ROBOTO_REGULAR_11.FontFamily;
            var menuFont = new Font(ffamily, 9);
            MainMenu.Font = menuFont;
            MainMenu.Renderer = new MyRenderer();
            Drives = Environment.GetLogicalDrives();
        }



        private void chooseCatalogButton_Click(object sender, EventArgs e)
        {
            var result = chooseFolderDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(chooseFolderDialog.SelectedPath))
            {
                pathField.Text = chooseFolderDialog.SelectedPath;
                string[] files = Directory.GetFiles(pathField.Text);

                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

            public override Color MenuItemSelectedGradientBegin
            {
                get {
                    return materialSkinManager.ColorScheme.LightPrimaryColor;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {

                get { 
                    return materialSkinManager.ColorScheme.LightPrimaryColor;
                }
            }

            public override Color MenuItemBorder
            {
                get {
                    return materialSkinManager.ColorScheme.DarkPrimaryColor;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return materialSkinManager.ColorScheme.LightPrimaryColor; }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return materialSkinManager.ColorScheme.DarkPrimaryColor; }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            drivesBox.DataSource = Drives;
            pathField.Text = @"J:\dev\check";
        }

        private void copyStructure_Click(object sender, EventArgs e)
        {
            var drive = drivesBox.SelectedValue.ToString();
            string neededPath = pathField.Text;
            if (String.IsNullOrEmpty(neededPath))
            {
                MessageBox.Show("Выберите каталог, который хотите скопировать!");
                return;
            }
            var ci = new CopyInfo
            {
                NeededPath = neededPath,
                SelectedDrive = drive
            };

            var copyStructureThread = new Thread(CopyStructureThread);
            copyStructureThread.Start(ci);
        }

        class CopyInfo
        {

            public string NeededPath { get; set; }
            public string SelectedDrive { get; set; }


        }

        private void CopyStructureThread(object copyInf)
        {
            var copyInfo = (CopyInfo)copyInf;
            var neededPath = copyInfo.NeededPath;
            string drive = "\\\\.\\" + copyInfo.SelectedDrive;
            drive = drive.Remove(drive.Length - 1, 1);
            FlashDrive = HandlesAPI.CreateFile(
                drive,
                HandlesAPI.GENERIC_READ,
                HandlesAPI.FILE_SHARE_READ | HandlesAPI.FILE_SHARE_WRITE,
                IntPtr.Zero,
                HandlesAPI.OPEN_EXISTING,
                0,
                IntPtr.Zero
            );
            if (FlashDrive.IsInvalid)
            {
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            }



            byte[] BootSector = ReturnBootSector(FlashDrive);

            var bpb = ReadBPB(BootSector);
            if (bpb.Signature != "NTFS    ")
            {
                MessageBox.Show("Данный раздел не является томом NTFS");
                return;
            }
            else
            {
                var np = neededPath.ToCharArray();
                np[0] = drive[4];
                string toPath = new string(np);
                CopyDirs(neededPath, toPath);
                MessageBox.Show("Структура каталогов успешно скопирована!");
            }
        }




        private void CopyDirs(string fromPath, string toPath)
        {

            CreateDir(toPath);
            foreach (string s1 in Directory.GetFiles(fromPath))
            {
                string s2 = toPath + "\\" + Path.GetFileName(s1);
                CopyFile(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(fromPath))
            {
                CopyDirs(s, toPath + "\\" + Path.GetFileName(s));
            }
        }

        public CopyProgressResult CopyProgressHandler(long total, long transferred, long streamSize, long StreamByteTrans, uint dwStreamNumber, CopyProgressCallbackReason reason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData)
        {
            return CopyProgressResult.PROGRESS_CONTINUE;
        }

        private void CopyFile(string oldFile, string newFile)
        {
            int pbCancel = 0;
            CopyFileEx(oldFile, newFile, new CopyProgressRoutine(this.CopyProgressHandler), IntPtr.Zero, ref pbCancel, CopyFileFlags.COPY_FILE_RESTARTABLE);
        }

        private void CreateDir(string path)
        {
            if (!CreateDirectory(path, null))
            {
                //считываем код текущей ошибки
                var err = Marshal.GetLastWin32Error();
                //если код равен 3, что означает PATH_NOT_FOUND, создаем необходимые для копирования каталоги
                if (err == 3)
                {
                    var catalogs = path.Split('\\');
                    for (int i = 1; i < catalogs.Length - 1; i++)
                    {
                        var resPath = "";
                        for (int j = 0; j <= i; j++)
                        {
                            resPath += catalogs[j] + '\\';
                        }
                        CreateDirectory(resPath, null);
                    }
                    CreateDirectory(path, null);
                }

            }
        }

        private BPB ReadBPB(byte[] sector)
        {
            BPB bpb = new BPB();
            bpb.Signature = "";
            for (int i = 0; i < 8; i++)
                bpb.Signature += (char)sector[0x3 + i];

            bpb.BytePerSec = sector[0xB] + (sector[0xC] << 8);
            bpb.SectorPerCluster = sector[Constants.SEC_PER_CLUS];
            bpb.TypeOfDrive = sector[0x15];
            bpb.SecPerTrack = sector[0x18];
            bpb.NumHeads = sector[0x1A];

            bpb.HiddenSec = 0;
            for (int i = 0; i < 4; i++)
                bpb.HiddenSec += sector[0x1C + i] << (i * 8);

            bpb.SecCount = 0;
            for (int i = 0; i < 8; i++)
                bpb.SecCount += (ulong)sector[0x28 + i] << (i * 8);

            bpb.FirstClusterMFT = 0;
            for (int i = 0; i < 8; i++)
                bpb.FirstClusterMFT += (ulong)sector[i + Constants.START_CLUS_MFT] << (8 * i);

            bpb.FirstClusterMirror = 0;
            for (int i = 0; i < 8; i++)
                bpb.FirstClusterMirror += (ulong)sector[i + Constants.START_CLUS_MFT + 8] << (8 * i);

            bpb.ClustersPerMFT = (sbyte)sector[0x40];
            bpb.ClustertPerIndex = (sbyte)sector[0x44];

            bpb.SerialNumber = 0;
            for (int i = 0; i < 8; i++)
                bpb.SerialNumber += (ulong)sector[i + 0x48] << (8 * i);

            return bpb;
        }



        private unsafe byte[] ReturnBootSector(SafeFileHandle drive)
        {
            byte[] bytes = new byte[Constants.BYTE_IN_SECTOR]; // BOOT сектор в виде одномерного массива байтов
            IntPtr BytesRead = IntPtr.Zero;

            fixed (byte* ptr = bytes)
            {
                HandlesAPI.ReadFile(drive, ptr, Constants.BYTE_IN_SECTOR, BytesRead, IntPtr.Zero); // Считывание первого сектора
            };

            return bytes;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
