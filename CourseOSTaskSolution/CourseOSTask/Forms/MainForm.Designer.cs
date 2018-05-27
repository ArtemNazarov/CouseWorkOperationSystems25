namespace CourseOSTask
{
    partial class MainForm 
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.copyStructure = new MaterialSkin.Controls.MaterialRaisedButton();
            this.drivesBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.chooseCatalogButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pathField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chosenFilesBox = new System.Windows.Forms.ListBox();
            this.chooseFilesButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.цуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цуцуцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цуцуцуцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитькакToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 106);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(882, 744);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.copyStructure);
            this.tabPage1.Controls.Add(this.drivesBox);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.pathLabel);
            this.tabPage1.Controls.Add(this.chooseCatalogButton);
            this.tabPage1.Controls.Add(this.pathField);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 718);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            // 
            // copyStructure
            // 
            this.copyStructure.AutoSize = true;
            this.copyStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyStructure.Depth = 0;
            this.copyStructure.Icon = null;
            this.copyStructure.Location = new System.Drawing.Point(19, 181);
            this.copyStructure.Margin = new System.Windows.Forms.Padding(2);
            this.copyStructure.MouseState = MaterialSkin.MouseState.HOVER;
            this.copyStructure.Name = "copyStructure";
            this.copyStructure.Primary = true;
            this.copyStructure.Size = new System.Drawing.Size(112, 36);
            this.copyStructure.TabIndex = 12;
            this.copyStructure.Text = "Копировать";
            this.copyStructure.UseVisualStyleBackColor = true;
            this.copyStructure.Click += new System.EventHandler(this.copyStructure_Click);
            // 
            // drivesBox
            // 
            this.drivesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drivesBox.FormattingEnabled = true;
            this.drivesBox.Location = new System.Drawing.Point(19, 141);
            this.drivesBox.Margin = new System.Windows.Forms.Padding(2);
            this.drivesBox.Name = "drivesBox";
            this.drivesBox.Size = new System.Drawing.Size(92, 21);
            this.drivesBox.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 106);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(332, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Выберите логический диск для копирования";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Depth = 0;
            this.pathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pathLabel.Location = new System.Drawing.Point(16, 22);
            this.pathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(413, 19);
            this.pathLabel.TabIndex = 9;
            this.pathLabel.Text = "Введите путь до каталога или нажмите выбрать каталог";
            // 
            // chooseCatalogButton
            // 
            this.chooseCatalogButton.AutoSize = true;
            this.chooseCatalogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseCatalogButton.Depth = 0;
            this.chooseCatalogButton.Icon = null;
            this.chooseCatalogButton.Location = new System.Drawing.Point(446, 57);
            this.chooseCatalogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chooseCatalogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chooseCatalogButton.Name = "chooseCatalogButton";
            this.chooseCatalogButton.Primary = false;
            this.chooseCatalogButton.Size = new System.Drawing.Size(151, 36);
            this.chooseCatalogButton.TabIndex = 8;
            this.chooseCatalogButton.Text = "Выбрать каталог";
            this.chooseCatalogButton.UseVisualStyleBackColor = true;
            this.chooseCatalogButton.Click += new System.EventHandler(this.chooseCatalogButton_Click);
            // 
            // pathField
            // 
            this.pathField.Depth = 0;
            this.pathField.Hint = "";
            this.pathField.Location = new System.Drawing.Point(20, 63);
            this.pathField.MaxLength = 32767;
            this.pathField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathField.Name = "pathField";
            this.pathField.PasswordChar = '\0';
            this.pathField.SelectedText = "";
            this.pathField.SelectionLength = 0;
            this.pathField.SelectionStart = 0;
            this.pathField.Size = new System.Drawing.Size(430, 23);
            this.pathField.TabIndex = 7;
            this.pathField.TabStop = false;
            this.pathField.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.materialRaisedButton1);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.chosenFilesBox);
            this.tabPage2.Controls.Add(this.chooseFilesButton);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 718);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(34, 319);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(77, 36);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Анализ";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(30, 120);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Выбранные файлы";
            // 
            // chosenFilesBox
            // 
            this.chosenFilesBox.FormattingEnabled = true;
            this.chosenFilesBox.Location = new System.Drawing.Point(34, 158);
            this.chosenFilesBox.Name = "chosenFilesBox";
            this.chosenFilesBox.Size = new System.Drawing.Size(412, 134);
            this.chosenFilesBox.TabIndex = 2;
            // 
            // chooseFilesButton
            // 
            this.chooseFilesButton.AutoSize = true;
            this.chooseFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseFilesButton.Depth = 0;
            this.chooseFilesButton.Icon = null;
            this.chooseFilesButton.Location = new System.Drawing.Point(34, 62);
            this.chooseFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chooseFilesButton.Name = "chooseFilesButton";
            this.chooseFilesButton.Primary = true;
            this.chooseFilesButton.Size = new System.Drawing.Size(97, 36);
            this.chooseFilesButton.TabIndex = 1;
            this.chooseFilesButton.Text = "Выбрать...";
            this.chooseFilesButton.UseVisualStyleBackColor = true;
            this.chooseFilesButton.Click += new System.EventHandler(this.chooseFilesButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(30, 27);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(249, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Выберите файлы на одном диске";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 58);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(943, 42);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цуToolStripMenuItem,
            this.цуToolStripMenuItem1,
            this.цуцуцуToolStripMenuItem,
            this.цуцуцуцуToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(127, 92);
            // 
            // цуToolStripMenuItem
            // 
            this.цуToolStripMenuItem.Name = "цуToolStripMenuItem";
            this.цуToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.цуToolStripMenuItem.Text = "цу";
            // 
            // цуToolStripMenuItem1
            // 
            this.цуToolStripMenuItem1.Name = "цуToolStripMenuItem1";
            this.цуToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.цуToolStripMenuItem1.Text = "цу";
            // 
            // цуцуцуToolStripMenuItem
            // 
            this.цуцуцуToolStripMenuItem.Name = "цуцуцуToolStripMenuItem";
            this.цуцуцуToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.цуцуцуToolStripMenuItem.Text = "цуцуцу";
            // 
            // цуцуцуцуToolStripMenuItem
            // 
            this.цуцуцуцуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проToolStripMenuItem});
            this.цуцуцуцуToolStripMenuItem.Name = "цуцуцуцуToolStripMenuItem";
            this.цуцуцуцуToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.цуцуцуцуToolStripMenuItem.Text = "цуцуцуцу";
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.проToolStripMenuItem.Text = "про";
            // 
            // chooseFolderDialog
            // 
            this.chooseFolderDialog.SelectedPath = "~";
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.справкаToolStripMenuItem1});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenu.Location = new System.Drawing.Point(-1, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(125, 23);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.открытьToolStripMenuItem1,
            this.toolStripSeparator6,
            this.сохранитьToolStripMenuItem1,
            this.сохранитькакToolStripMenuItem1,
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.closeToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(51, 19);
            this.файлToolStripMenuItem1.Text = "&Файл";
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem1.Image")));
            this.создатьToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.создатьToolStripMenuItem1.Text = "&Создать";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem1.Image")));
            this.открытьToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.открытьToolStripMenuItem1.Text = "&Открыть";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(244, 6);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem1.Image")));
            this.сохранитьToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.сохранитьToolStripMenuItem1.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem1
            // 
            this.сохранитькакToolStripMenuItem1.Name = "сохранитькакToolStripMenuItem1";
            this.сохранитькакToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.сохранитькакToolStripMenuItem1.Text = "Сохранить &как";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(244, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(244, 6);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.closeToolStripMenuItem1.Text = "Вы&ход";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem1,
            this.индексToolStripMenuItem1,
            this.поискToolStripMenuItem1,
            this.toolStripSeparator11,
            this.опрограммеToolStripMenuItem1});
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(68, 19);
            this.справкаToolStripMenuItem1.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem1
            // 
            this.содержаниеToolStripMenuItem1.Name = "содержаниеToolStripMenuItem1";
            this.содержаниеToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.содержаниеToolStripMenuItem1.Text = "&Содержание";
            // 
            // индексToolStripMenuItem1
            // 
            this.индексToolStripMenuItem1.Name = "индексToolStripMenuItem1";
            this.индексToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.индексToolStripMenuItem1.Text = "&Индекс";
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.поискToolStripMenuItem1.Text = "&Поиск";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(157, 6);
            // 
            // опрограммеToolStripMenuItem1
            // 
            this.опрограммеToolStripMenuItem1.Name = "опрограммеToolStripMenuItem1";
            this.опрограммеToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.опрограммеToolStripMenuItem1.Text = "&О программе...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 301);
            this.dataGridView1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 876);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField pathField;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цуцуцуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цуцуцуцуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton chooseCatalogButton;
        private MaterialSkin.Controls.MaterialLabel pathLabel;
        private System.Windows.Forms.FolderBrowserDialog chooseFolderDialog;
        private System.Windows.Forms.ComboBox drivesBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton copyStructure;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialRaisedButton chooseFilesButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListBox chosenFilesBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

