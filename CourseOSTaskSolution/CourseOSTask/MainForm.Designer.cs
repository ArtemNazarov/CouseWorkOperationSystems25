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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.copyStructure = new MaterialSkin.Controls.MaterialRaisedButton();
            this.drivesBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.chooseCatalogButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pathField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.цуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цуцуцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цуцуцуцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(16, 90);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1019, 417);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1011, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            // 
            // copyStructure
            // 
            this.copyStructure.AutoSize = true;
            this.copyStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyStructure.Depth = 0;
            this.copyStructure.Icon = null;
            this.copyStructure.Location = new System.Drawing.Point(27, 225);
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
            this.drivesBox.Location = new System.Drawing.Point(25, 173);
            this.drivesBox.Name = "drivesBox";
            this.drivesBox.Size = new System.Drawing.Size(121, 24);
            this.drivesBox.TabIndex = 11;
            // 
            // materialLabel1
            // 
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
            this.pathLabel.AutoSize = true;
            this.pathLabel.Depth = 0;
            this.pathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pathLabel.Location = new System.Drawing.Point(21, 27);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(518, 24);
            this.pathLabel.TabIndex = 9;
            this.pathLabel.Text = "Введите путь до каталога или нажмите выбрать каталог";
            // 
            // chooseCatalogButton
            // 
            this.chooseCatalogButton.AutoSize = true;
            this.chooseCatalogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseCatalogButton.Depth = 0;
            this.chooseCatalogButton.Icon = null;
            this.chooseCatalogButton.Location = new System.Drawing.Point(331, 62);
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
            // pathField
            // 
            this.pathField.Depth = 0;
            this.pathField.Hint = "";
            this.pathField.Location = new System.Drawing.Point(27, 78);
            this.pathField.Margin = new System.Windows.Forms.Padding(4);
            this.pathField.MaxLength = 32767;
            this.pathField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathField.Name = "pathField";
            this.pathField.PasswordChar = '\0';
            this.pathField.SelectedText = "";
            this.pathField.SelectionLength = 0;
            this.pathField.SelectionStart = 0;
            this.pathField.Size = new System.Drawing.Size(271, 28);
            this.pathField.TabIndex = 7;
            this.pathField.TabStop = false;
            this.pathField.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1011, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1011, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Справка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-4, 31);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1080, 52);
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
            this.chooseFolderDialog.SelectedPath = "~";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 554);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox drivesBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton copyStructure;
    }
}

