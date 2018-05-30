using CourseOSTask.WinAPI;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CourseOSTask
{
    public partial class MainForm : MaterialForm
    {
        private string[] Drives { get; set; }

        /// <summary>
        /// Инициализация формы, её стилей, цветов и компонентов
        /// </summary>
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

        /// <summary>
        /// Выбор каталога для копирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Изменение стандартных цветов компонентов формы windows
        /// </summary>
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

        /// <summary>
        /// Обработка события загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            drivesBox.DataSource = Drives;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Копировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyStructure_Click(object sender, EventArgs e)
        {
            var drive = drivesBox.SelectedValue.ToString();
            string neededPath = pathField.Text;
            //если пользователь не выбрал каталог
            if (String.IsNullOrEmpty(neededPath))
            {
                MessageBox.Show("Выберите каталог, который хотите скопировать!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var np = neededPath.ToCharArray()[0] + ":\\";
            //если выбранный диск и диск с каталогом совпадают
            if (np.Equals(drive))
            {
                MessageBox.Show("Вы выбрали диск, с которого хотите скопировать!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //формирование объекта с информацией о выбранном каталоге и выбранном диске
            var ci = new CopyInfo
            {
                NeededPath = neededPath,
                SelectedDrive = drive
            };

            var copyStructureThread = new Thread(CopyStructureThread);
            copyStructureThread.Start(ci);
        }

        /// <summary>
        /// Поток копирования каталога
        /// </summary>
        /// <param name="copyInf"></param>
        private void CopyStructureThread(object copyInf)
        {
            var copyInfo = (CopyInfo)copyInf;
            var neededPath = copyInfo.NeededPath;
            string drive = "\\\\.\\" + copyInfo.SelectedDrive;
            drive = drive.Remove(drive.Length - 1, 1);
            //анализ выбранного диска
            DiskInfo diskInfoHandle = new DiskInfo(drive);
            //если выбранный диск не является NTFS
            if (diskInfoHandle.NotNTFSFlag)
            {
                MessageBox.Show("Данный раздел не является томом NTFS!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var np = neededPath.ToCharArray();
                np[0] = drive[4];
                string toPath = new string(np);
                //скопировать каталоги
                copyInfo.CopyDirs(neededPath, toPath);
                MessageBox.Show("Каталог успешно скопирован.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик кнопки выбора файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseFilesButton_Click(object sender, EventArgs e)
        {
            //
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

        private void AnalyzeFileGroupThread(object filesobj)
        {
            var files = (List<string>)filesobj;
            var mftViewTable = new List<TableView>();

            if (files.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var file in files)
                {
                    //разбиваем путьк файлу на каталоги
                    var catalogs = file.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
                    DiskInfo diskHandle = new DiskInfo(catalogs[0]);
                    if (!diskHandle.NotNTFSFlag)
                    {
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
                        MessageBox.Show("Группа файлов успешно проанализирована", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Файл {file} находится на диске, не являющимся томом NTFS", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                AnalyzeDataView.DataSource = null;
                // вывод данных в таблицу на форме
                AnalyzeDataView.DataSource = mftViewTable;
            }
        }


        private void опрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NTFS2Threads (C) 1.0 by Danilov Ilya", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("NTFS2Threads.chm");
        }

        /// <summary>
        /// Обработчик нажатия на кнопку Анализ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void analyzeMFTButton_Click(object sender, EventArgs e)
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
    }
}
