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
            this.печатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.MainMenu.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(764, 339);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(756, 313);
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
            this.copyStructure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.drivesBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(756, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
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
            this.materialTabSelector1.Size = new System.Drawing.Size(810, 42);
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
            this.правкаToolStripMenuItem1,
            this.сервисToolStripMenuItem1,
            this.справкаToolStripMenuItem1});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenu.Location = new System.Drawing.Point(-1, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(248, 23);
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
            this.печатьToolStripMenuItem1,
            this.предварительныйпросмотрToolStripMenuItem1,
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
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
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
            // печатьToolStripMenuItem1
            // 
            this.печатьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem1.Image")));
            this.печатьToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem1.Name = "печатьToolStripMenuItem1";
            this.печатьToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.печатьToolStripMenuItem1.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem1
            // 
            this.предварительныйпросмотрToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem1.Image")));
            this.предварительныйпросмотрToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem1.Name = "предварительныйпросмотрToolStripMenuItem1";
            this.предварительныйпросмотрToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.предварительныйпросмотрToolStripMenuItem1.Text = "Предварительный про&смотр";
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
            // правкаToolStripMenuItem1
            // 
            this.правкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem2,
            this.отменадействияToolStripMenuItem3,
            this.toolStripSeparator9,
            this.вырезатьToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставкаToolStripMenuItem1,
            this.toolStripSeparator10,
            this.выделитьвсеToolStripMenuItem1});
            this.правкаToolStripMenuItem1.Name = "правкаToolStripMenuItem1";
            this.правкаToolStripMenuItem1.Size = new System.Drawing.Size(62, 19);
            this.правкаToolStripMenuItem1.Text = "&Правка";
            // 
            // отменадействияToolStripMenuItem2
            // 
            this.отменадействияToolStripMenuItem2.Name = "отменадействияToolStripMenuItem2";
            this.отменадействияToolStripMenuItem2.Size = new System.Drawing.Size(182, 26);
            this.отменадействияToolStripMenuItem2.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem3
            // 
            this.отменадействияToolStripMenuItem3.Name = "отменадействияToolStripMenuItem3";
            this.отменадействияToolStripMenuItem3.Size = new System.Drawing.Size(182, 26);
            this.отменадействияToolStripMenuItem3.Text = "&Отмена действия";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(179, 6);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem1.Image")));
            this.вырезатьToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.вырезатьToolStripMenuItem1.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem1.Image")));
            this.копироватьToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.копироватьToolStripMenuItem1.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem1
            // 
            this.вставкаToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem1.Image")));
            this.вставкаToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem1.Name = "вставкаToolStripMenuItem1";
            this.вставкаToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.вставкаToolStripMenuItem1.Text = "Вст&авка";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(179, 6);
            // 
            // выделитьвсеToolStripMenuItem1
            // 
            this.выделитьвсеToolStripMenuItem1.Name = "выделитьвсеToolStripMenuItem1";
            this.выделитьвсеToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.выделитьвсеToolStripMenuItem1.Text = "Выделить &все";
            // 
            // сервисToolStripMenuItem1
            // 
            this.сервисToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem1,
            this.параметрыToolStripMenuItem1});
            this.сервисToolStripMenuItem1.Name = "сервисToolStripMenuItem1";
            this.сервисToolStripMenuItem1.Size = new System.Drawing.Size(61, 19);
            this.сервисToolStripMenuItem1.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.настройкиToolStripMenuItem1.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem1
            // 
            this.параметрыToolStripMenuItem1.Name = "параметрыToolStripMenuItem1";
            this.параметрыToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.параметрыToolStripMenuItem1.Text = "&Параметры";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 550);
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
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem1;
    }
}

