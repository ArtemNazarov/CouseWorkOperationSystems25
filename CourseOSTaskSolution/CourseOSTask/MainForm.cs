using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseOSTask
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            seedListView();
        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{ "user1", "heheg" },
                new []{ "user2", "wsfwef" },
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            progressSecondTask.Value = Math.Max(progressSecondTask.Value + 10, 100);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            progressSecondTask.Value = Math.Min(progressSecondTask.Value + 10, 100);
        }

        private void chooseCatalogButton_Click(object sender, EventArgs e)
        {
            var result = chooseFolderDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(chooseFolderDialog.SelectedPath))
            {
                pathField.Text = chooseFolderDialog.SelectedPath;
                //string[] files = Directory.GetFiles(fbd.SelectedPath);

                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

    }
}
