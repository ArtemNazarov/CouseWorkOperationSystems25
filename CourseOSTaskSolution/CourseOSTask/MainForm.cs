using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            public override Color MenuItemSelected
            {
                get {
                    var materialSkinManager = MaterialSkinManager.Instance;
                    return Color.Yellow;
                }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Yellow; }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            drivesBox.DataSource = Drives;
            
            //var msmInstance = MaterialSkinManager.Instance;
            
            //MainMenu.BackColor = msmInstance.ColorScheme.DarkPrimaryColor;
            //MainMenu.ForeColor = msmInstance.ColorScheme.TextColor;

            //var ffamily = msmInstance.ROBOTO_REGULAR_11.FontFamily;
            //var menuFont = new Font(ffamily, 9);
            //MainMenu.Font = menuFont;
        }

        private void copyStructure_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Копирование ещё не реализовано");
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
