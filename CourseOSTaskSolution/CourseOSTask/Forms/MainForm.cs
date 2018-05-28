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
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var files = new List<string>();
            //чтение путей файлов, добавленных в ListBox
            foreach (var item in chosenFilesBox.Items)
            {
                files.Add(item.ToString());
            }
            //создание и запуск потока анализа файла
            var analyzeFileGroupThread = new Thread(AnalyzeFileGroupThread);
            analyzeFileGroupThread.Start(files);
        }

        private void AnalyzeFileGroupThread(object filesobj)
        {
            var files = (List<string>)filesobj;
            var mftViewTable = new List<TableView>();

            if (files.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного файла!");
            }
            else
            {
                foreach (var file in files)
                {
                    //разбиваем путьк файлу на каталоги
                    var catalogs = file.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
                    DiskInfo diskHandle = new DiskInfo(catalogs[0]);
                    // 5 запись является корневым каталогом, обращаемся к ней при старте поиска
                    int nextRecord = 5;
                    // в объявленной переменной хранится текущий каталог
                    MFTHandle root; 
                    for (int i = 1; i < catalogs.Length; i++)
                    {
                        // считывание следующей записи MFT
                        root = diskHandle.GetMftRecord(nextRecord);
                        // поиск номера записи МФТ следующего каталога
                        nextRecord = DiskInfo.FoundSubdir(root, catalogs[i]); 
                    }

                    MFTHandle detectedFile = diskHandle.GetMftRecord(nextRecord);

                    mftViewTable.Add(new TableView(detectedFile)); 
                    foreach (var index in detectedFile.Indexes)
                    {
                        mftViewTable.Add(new TableView(diskHandle.GetMftRecord((int)index.IndexedFile))); 
                    }
                }

                AnalyzeDataView.DataSource = null;
                // вывод данных в таблицу на форме
                AnalyzeDataView.DataSource = mftViewTable;
            }
        }

        private void saveAnalyzeResults_Click(object sender, EventArgs e)
        {
            if (AnalyzeDataView.DataSource != null)
            {
                var data = (List<string>)AnalyzeDataView.DataSource;
                if (data.Count != 0)
                {
                    var result = saveFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //StreamWriter sw = new StreamWriter();
                    }
                }
                else
                {
                    MessageBox.Show("Таблица не содержит элементов!");
                }
            }
            else
            {
                MessageBox.Show("Таблица не содержит элементов!");
            }
        }

        private void опрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NTFS2Threads (C) 1.0 By Danilov Ilya");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
