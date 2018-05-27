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
using CourseOSTask.WinAPI;
using Microsoft.Win32.SafeHandles;
using static CourseOSTask.HandleDriveAPI;

namespace CourseOSTask
{
    public partial class MainForm : MaterialForm
    {
        private string[] Drives { get; set; }


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
                get
                {
                    return materialSkinManager.ColorScheme.LightPrimaryColor;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {

                get
                {
                    return materialSkinManager.ColorScheme.LightPrimaryColor;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
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
            //chosenFilesBox.
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

        private void CopyStructureThread(object copyInf)
        {
            var copyInfo = (CopyInfo)copyInf;
            var neededPath = copyInfo.NeededPath;
            string drive = "\\\\.\\" + copyInfo.SelectedDrive;
            drive = drive.Remove(drive.Length - 1, 1);

            DiskInfo diskInfoHandle = new DiskInfo(drive);
            var bpb = diskInfoHandle.BPB;
            if (bpb.Signature != "NTFS    ")
            {
                MessageBox.Show("Данный раздел не является томом NTFS");
            }
            else
            {
                var np = neededPath.ToCharArray();
                np[0] = drive[4];
                string toPath = new string(np);
                copyInfo.CopyDirs(neededPath, toPath);
                MessageBox.Show("Структура каталогов успешно скопирована!");
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chooseFilesButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            chosenFilesBox.Items.Clear();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.SafeFileName))
            {
                var files = openFileDialog.FileNames;
                foreach (var item in files)
                {
                    chosenFilesBox.Items.Add(item);
                }
                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var files = new List<string>();
            var mftViewTable = new List<TableView>();

            foreach (var item in chosenFilesBox.Items)
            {
                files.Add(item.ToString());
            }

            foreach (var file in files)
            {
                var catalogs = file.Split(new [] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);//Разбиваем полный путь на имена каталогов)
                DiskInfo diskHandle = new DiskInfo(catalogs[0]);
                int nextRecord = 5; // 5 запись -- корневой каталог, поиск начинаем с него
                MFTHandle root; // переменная для хранения текущего каталога
                for (int i = 1; i < catalogs.Length; i++)
                {
                    root = diskHandle.GetMftRecord(nextRecord); // читаем следующую запись МФТ со всеми аттрибутами, включая INDEX_ROOT и INDEX_ALLOCATION
                    nextRecord = DiskInfo.FoundSubdir(root, catalogs[i]); // Ищем номер записи МФТ следующего каталога
                }

                MFTHandle detectedFile = diskHandle.GetMftRecord(nextRecord);

                mftViewTable.Add(new TableView(detectedFile)); // Первым отображается запись самого каталога
                foreach (var index in detectedFile.Indexes)
                {
                    mftViewTable.Add(new TableView(diskHandle.GetMftRecord((int)index.IndexedFile))); // добавляем в отображаемые записи сведения о файле в каталоге
                }
            }

            dataGridView1.DataSource = null;
            // выводим данные в таблицу
            dataGridView1.DataSource = mftViewTable;

        }
    }
}
