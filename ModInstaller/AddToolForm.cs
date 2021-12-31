using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModInstaller
{
    public partial class AddToolForm : Form
    {
        public string toolName;
        public string toolPath;

        public AddToolForm()
        {
            InitializeComponent();
        }

        private void ButtonSelectExe_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "外部ツール|*.exe;*.lnk"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                toolPath = dlg.FileName;
                textBoxPath.Text = toolPath;
            }

        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            toolName = textBoxName.Text;
        }

        private void ButtonRegist_Click(object sender, EventArgs e)
        {
            toolName = textBoxName.Text;
            toolPath = textBoxPath.Text;

        }
    }
}
