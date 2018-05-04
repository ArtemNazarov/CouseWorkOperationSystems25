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
            this.pathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.chooseCatalogButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pathField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progressSecondTask = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.цуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цуцуцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цуцуцуцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 73);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(764, 339);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pathLabel);
            this.tabPage1.Controls.Add(this.chooseCatalogButton);
            this.tabPage1.Controls.Add(this.pathField);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
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
            this.chooseCatalogButton.Location = new System.Drawing.Point(248, 50);
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
            this.pathField.Size = new System.Drawing.Size(203, 23);
            this.pathField.TabIndex = 7;
            this.pathField.TabStop = false;
            this.pathField.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialFlatButton2);
            this.tabPage2.Controls.Add(this.materialRaisedButton2);
            this.tabPage2.Controls.Add(this.progressSecondTask);
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(42, 105);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(108, 36);
            this.materialFlatButton2.TabIndex = 14;
            this.materialFlatButton2.Text = "Уменьшить";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(597, 105);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(102, 36);
            this.materialRaisedButton2.TabIndex = 13;
            this.materialRaisedButton2.Text = "Увеличить";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // progressSecondTask
            // 
            this.progressSecondTask.Depth = 0;
            this.progressSecondTask.Location = new System.Drawing.Point(42, 67);
            this.progressSecondTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressSecondTask.Name = "progressSecondTask";
            this.progressSecondTask.Size = new System.Drawing.Size(657, 5);
            this.progressSecondTask.TabIndex = 11;
            this.progressSecondTask.Value = 13;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(42, 150);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(657, 143);
            this.materialListView1.TabIndex = 10;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Login";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 300;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-3, 25);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Справка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "MainForm";
            this.Text = " ";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField pathField;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цуцуцуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цуцуцуцуToolStripMenuItem;
        private MaterialSkin.Controls.MaterialProgressBar progressSecondTask;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialFlatButton chooseCatalogButton;
        private MaterialSkin.Controls.MaterialLabel pathLabel;
        private System.Windows.Forms.FolderBrowserDialog chooseFolderDialog;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

