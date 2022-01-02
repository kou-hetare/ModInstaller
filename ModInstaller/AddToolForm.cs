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

namespace AmongUsModInstaller
{
    public partial class AddToolForm : Form
    {
        public string toolName="";
        public string toolPath = "";

        public AddToolForm()
        {
            InitializeComponent();
        }

        private void AddToolForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = toolName;
            textBoxPath.Text = toolPath;
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

        private void AddToolForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void AddToolForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string file
                in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    var ext = Path.GetExtension(file).ToLower();
                    String fileName = file;
                    String fileExt = ext;

                    if (ext == ".lnk")
                    {
                        var shellAppType = Type.GetTypeFromProgID("WScript.Shell");
                        dynamic shell = Activator.CreateInstance(shellAppType);
                        var link = shell.CreateShortcut(file);
                        fileName = link.TargetPath;
                        fileExt = Path.GetExtension(fileName).ToLower();
                    }
                    if (fileExt == ".url")
                    {
                        textBoxPath.Text = fileName;
                    }
                    else
                    {
                        textBoxPath.Text = file;

                    }
                }
            }

        }

    }
}
