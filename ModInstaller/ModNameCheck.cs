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
    public partial class ModNameCheck : Form
    {
        public ModNameCheck()
        {
            InitializeComponent();
        }

        public void SetModFileInfo(string info)
        {
            textFileInfo.Text = info;
            textFileInfo.TextAlign = HorizontalAlignment.Left;
            textModName.Text = info;
        }

        public string GetModName()
        {
            return textModName.Text;
        }

        private void ModNameCheck_Shown(object sender, EventArgs e)
        {
            textModName.Focus();
        }
    }
}
