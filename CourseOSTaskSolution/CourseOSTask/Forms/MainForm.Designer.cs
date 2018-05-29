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
            this.chooseCatalogButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.copyStructure = new MaterialSkin.Controls.MaterialRaisedButton();
            this.drivesBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AnalyzeDataView = new System.Windows.Forms.DataGridView();
            this.analyzeMFTButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chosenFilesBox = new System.Windows.Forms.ListBox();
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
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.chooseFilesButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pathField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalyzeDataView)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(16, 130);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1070, 685);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pathField);
            this.tabPage1.Controls.Add(this.chooseCatalogButton);
            this.tabPage1.Controls.Add(this.copyStructure);
            this.tabPage1.Controls.Add(this.drivesBox);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.pathLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1062, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            // 
            // chooseCatalogButton
            // 
            this.chooseCatalogButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseCatalogButton.AutoSize = true;
            this.chooseCatalogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseCatalogButton.Depth = 0;
            this.chooseCatalogButton.Icon = null;
            this.chooseCatalogButton.Location = new System.Drawing.Point(805, 71);
            this.chooseCatalogButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.chooseCatalogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chooseCatalogButton.Name = "chooseCatalogButton";
            this.chooseCatalogButton.Primary = false;
            this.chooseCatalogButton.Size = new System.Drawing.Size(184, 36);
            this.chooseCatalogButton.TabIndex = 8;
            this.chooseCatalogButton.Text = "Выбрать каталог";
            this.chooseCatalogButton.UseVisualStyleBackColor = true;
            this.chooseCatalogButton.Click += new System.EventHandler(this.chooseCatalogButton_Click);
            // 
            // copyStructure
            // 
            this.copyStructure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyStructure.AutoSize = true;
            this.copyStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyStructure.Depth = 0;
            this.copyStructure.Icon = null;
            this.copyStructure.Location = new System.Drawing.Point(25, 223);
            this.copyStructure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyStructure.MouseState = MaterialSkin.MouseState.HOVER;
            this.copyStructure.Name = "copyStructure";
            this.copyStructure.Primary = true;
            this.copyStructure.Size = new System.Drawing.Size(136, 36);
            this.copyStructure.TabIndex = 12;
            this.copyStructure.Text = "Копировать";
            this.copyStructure.UseVisualStyleBackColor = true;
            this.copyStructure.Click += new System.EventHandler(this.copyStructure_Click);
            // 
            // drivesBox
            // 
            this.drivesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drivesBox.FormattingEnabled = true;
            this.drivesBox.Location = new System.Drawing.Point(25, 175);
            this.drivesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drivesBox.Name = "drivesBox";
            this.drivesBox.Size = new System.Drawing.Size(136, 24);
            this.drivesBox.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 130);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(414, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Выберите логический диск для копирования";
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLabel.AutoSize = true;
            this.pathLabel.Depth = 0;
            this.pathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pathLabel.Location = new System.Drawing.Point(21, 31);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(173, 24);
            this.pathLabel.TabIndex = 9;
            this.pathLabel.Text = "Выберите каталог";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.chooseFilesButton);
            this.tabPage2.Controls.Add(this.AnalyzeDataView);
            this.tabPage2.Controls.Add(this.analyzeMFTButton);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.chosenFilesBox);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1062, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            // 
            // AnalyzeDataView
            // 
            this.AnalyzeDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AnalyzeDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AnalyzeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalyzeDataView.Location = new System.Drawing.Point(45, 376);
            this.AnalyzeDataView.Margin = new System.Windows.Forms.Padding(4);
            this.AnalyzeDataView.Name = "AnalyzeDataView";
            this.AnalyzeDataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnalyzeDataView.Size = new System.Drawing.Size(785, 257);
            this.AnalyzeDataView.TabIndex = 5;
            // 
            // analyzeMFTButton
            // 
            this.analyzeMFTButton.AutoSize = true;
            this.analyzeMFTButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.analyzeMFTButton.Depth = 0;
            this.analyzeMFTButton.Icon = null;
            this.analyzeMFTButton.Location = new System.Drawing.Point(45, 310);
            this.analyzeMFTButton.Margin = new System.Windows.Forms.Padding(4);
            this.analyzeMFTButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.analyzeMFTButton.Name = "analyzeMFTButton";
            this.analyzeMFTButton.Primary = true;
            this.analyzeMFTButton.Size = new System.Drawing.Size(92, 36);
            this.analyzeMFTButton.TabIndex = 4;
            this.analyzeMFTButton.Text = "Анализ";
            this.analyzeMFTButton.UseVisualStyleBackColor = true;
            this.analyzeMFTButton.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(41, 82);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(182, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Выбранные файлы";
            // 
            // chosenFilesBox
            // 
            this.chosenFilesBox.FormattingEnabled = true;
            this.chosenFilesBox.ItemHeight = 16;
            this.chosenFilesBox.Location = new System.Drawing.Point(44, 125);
            this.chosenFilesBox.Margin = new System.Windows.Forms.Padding(4);
            this.chosenFilesBox.Name = "chosenFilesBox";
            this.chosenFilesBox.Size = new System.Drawing.Size(786, 164);
            this.chosenFilesBox.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(40, 33);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(311, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Выберите файлы на одном диске";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 71);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1135, 52);
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
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(143, 100);
            // 
            // цуToolStripMenuItem
            // 
            this.цуToolStripMenuItem.Name = "цуToolStripMenuItem";
            this.цуToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.цуToolStripMenuItem.Text = "цу";
            // 
            // цуToolStripMenuItem1
            // 
            this.цуToolStripMenuItem1.Name = "цуToolStripMenuItem1";
            this.цуToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.цуToolStripMenuItem1.Text = "цу";
            // 
            // цуцуцуToolStripMenuItem
            // 
            this.цуцуцуToolStripMenuItem.Name = "цуцуцуToolStripMenuItem";
            this.цуцуцуToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.цуцуцуToolStripMenuItem.Text = "цуцуцу";
            // 
            // цуцуцуцуToolStripMenuItem
            // 
            this.цуцуцуцуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проToolStripMenuItem});
            this.цуцуцуцуToolStripMenuItem.Name = "цуцуцуцуToolStripMenuItem";
            this.цуцуцуцуToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.цуцуцуцуToolStripMenuItem.Text = "цуцуцуцу";
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.проToolStripMenuItem.Text = "про";
            // 
            // chooseFolderDialog
            // 
            this.chooseFolderDialog.Description = "Выберите каталог, который хотите скопировать";
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
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(145, 26);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.closeToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(58, 22);
            this.файлToolStripMenuItem1.Text = "&Файл";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(125, 6);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem1.Text = "Вы&ход";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator11,
            this.опрограммеToolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(79, 22);
            this.справкаToolStripMenuItem1.Text = "Помощь";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(184, 6);
            // 
            // опрограммеToolStripMenuItem1
            // 
            this.опрограммеToolStripMenuItem1.Name = "опрограммеToolStripMenuItem1";
            this.опрограммеToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.опрограммеToolStripMenuItem1.Text = "&О программе...";
            this.опрограммеToolStripMenuItem1.Click += new System.EventHandler(this.опрограммеToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.справкаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Выберите файлы";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Csv file|*.csv";
            this.saveFileDialog.InitialDirectory = "~";
            this.saveFileDialog.Title = "Сохранение файла данных";
            // 
            // chooseFilesButton
            // 
            this.chooseFilesButton.AutoSize = true;
            this.chooseFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseFilesButton.Depth = 0;
            this.chooseFilesButton.Icon = null;
            this.chooseFilesButton.Location = new System.Drawing.Point(431, 21);
            this.chooseFilesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chooseFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chooseFilesButton.Name = "chooseFilesButton";
            this.chooseFilesButton.Primary = false;
            this.chooseFilesButton.Size = new System.Drawing.Size(117, 36);
            this.chooseFilesButton.TabIndex = 6;
            this.chooseFilesButton.Text = "Выбрать...";
            this.chooseFilesButton.UseVisualStyleBackColor = true;
            this.chooseFilesButton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // pathField
            // 
            this.pathField.Depth = 0;
            this.pathField.Enabled = false;
            this.pathField.Hint = "";
            this.pathField.Location = new System.Drawing.Point(25, 71);
            this.pathField.MaxLength = 32767;
            this.pathField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathField.Name = "pathField";
            this.pathField.PasswordChar = '\0';
            this.pathField.SelectedText = "";
            this.pathField.SelectionLength = 0;
            this.pathField.SelectionStart = 0;
            this.pathField.Size = new System.Drawing.Size(731, 28);
            this.pathField.TabIndex = 13;
            this.pathField.TabStop = false;
            this.pathField.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 852);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalyzeDataView)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListBox chosenFilesBox;
        private MaterialSkin.Controls.MaterialRaisedButton analyzeMFTButton;
        private System.Windows.Forms.DataGridView AnalyzeDataView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private MaterialSkin.Controls.MaterialFlatButton chooseFilesButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField pathField;
    }
}

