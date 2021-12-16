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
using System.IO.Compression;

namespace ModInstaller
{
    public partial class Form1 : Form
    {
        String openCommand = "";
        String openCommandPre = "Open=";
        String installFolder="";
        String installFolderPre = "InstallFolder=";
        String AmongUsCapturePath = "";
        String AmongUsCapturePathPre = "AmongUsCapture=";
        String BetterCrewLinkPath = "";
        String BetterCrewLinkPathPre = "BetterCrewLink=";
        String exePath = "";
        String dllStorePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        String getModInstallFolder()
        {
            return Path.Combine(installFolder, "BepInEx\\plugins");
        }

        void loadSetting()
        {
            System.IO.StreamReader sr;
            try
            {
                sr = new System.IO.StreamReader("setting.txt");
            }
            catch (Exception)
            {
                return;
            }
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                if (line.StartsWith(openCommandPre))
                {
                    openCommand = line.Substring(openCommandPre.Length);
                }
                if (line.StartsWith(installFolderPre))
                {
                    installFolder = line.Substring(installFolderPre.Length);
                }
                if (line.StartsWith(AmongUsCapturePathPre))
                {
                    AmongUsCapturePath = line.Substring(AmongUsCapturePathPre.Length);
                }
                if (line.StartsWith(BetterCrewLinkPathPre))
                {
                    BetterCrewLinkPath = line.Substring(BetterCrewLinkPathPre.Length);
                }
            }

            sr.Close();
            textUpdate();

        }

        void saveSetting()
        {
            System.IO.StreamWriter wr;
            try
            {
                wr = new System.IO.StreamWriter("setting.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("設定ファイルを開けません");

                return;
            }

            wr.WriteLine(openCommandPre + openCommand);
            wr.WriteLine(installFolderPre + installFolder);
            wr.WriteLine(AmongUsCapturePathPre + AmongUsCapturePath);
            wr.WriteLine(BetterCrewLinkPathPre + BetterCrewLinkPath);

            wr.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exePath = Path.GetDirectoryName(Application.ExecutablePath);
            dllStorePath = Path.Combine(exePath , "MODs");
            Directory.CreateDirectory(dllStorePath);
            loadSetting();
            listupDLL();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSetting();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string file
                in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    var ext = Path.GetExtension(file).ToLower();
                    String fileName = file;
                    if (ext == ".lnk")
                    {
                        var shellAppType = Type.GetTypeFromProgID("WScript.Shell");
                        dynamic shell = Activator.CreateInstance(shellAppType);
                        var link = shell.CreateShortcut(file);
                        fileName = link.TargetPath;
                    }

                    if (ext == ".url")
                    {
                        readUrlFile(fileName);
                    } else if (Path.GetFileName(fileName) == "Among Us.exe")
                    {
                        installFolder = Path.GetDirectoryName(fileName);

                    }
                    else if (Path.GetFileName(fileName) == "AmongUsCapture.exe")
                    {
                        AmongUsCapturePath = fileName;
                    }
                    else if (Path.GetFileName(fileName) == "Better-CrewLink.exe")
                    {
                        BetterCrewLinkPath = fileName;
                    }
                    else if (ext == ".zip")
                    {
                        extractMod(fileName);

                    }
                    else
                    {
                        findModDLL(fileName);
                    }
                }
                textUpdate();
            }
        }

        private void StartSetting_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Among Usショートカット|*.url";
            dlg.DereferenceLinks = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                readUrlFile(dlg.FileName);
                textUpdate();
            }
        }
        private void FolderSetting_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Among Us|Among Us.exe";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                installFolder = Path.GetDirectoryName(dlg.FileName);

                textUpdate();
            }
        }

        private void AmongUsMuteCapture_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "AmongUsCapture|AmongUsCapture.exe;AmongUsCapture.lnk";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AmongUsCapturePath = dlg.FileName;

                textUpdate();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Better-CrewLink|Better-CrewLink.exe;Better-CrewLink.lnk";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BetterCrewLinkPath = dlg.FileName;

                textUpdate();
            }

        }

        void readUrlFile(String filename)
        {
            System.IO.StreamReader sr;
            try
            {
                sr = new System.IO.StreamReader(filename);
            }
            catch (Exception)
            {
                return;
            }
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                if (line.StartsWith("URL"))
                {
                    openCommand = line.Substring(4);
                }
                if (line.StartsWith("IconFile"))
                {
                    if (line.Contains("Epic"))
                    {
                        installFolder = Path.GetDirectoryName(line.Substring(9));
                    }
                }
            }
            textUpdate();

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (openCommand != "")
            {
                var items = ModList.SelectedItems;
                if (items.Count != 1)
                {
                    MessageBox.Show("Vanilla/Modを選択してください");
                    return;
                }

                clearModDLL();

                if (items[0].Text != "Vanilla")
                {
                    var dllpath = items[0].SubItems[1].Text;
                    var dllFIles = Directory.GetFiles(dllpath);
                    foreach(var srcfileName in dllFIles)
                    {
                        var dllname = Path.GetFileName(srcfileName);

                        File.Copy(srcfileName, Path.Combine(getModInstallFolder(), dllname));

                    }
                }

                if (BootAmongUsMuteCapture.Enabled && BootAmongUsMuteCapture.Checked)
                {
                    execCommand(AmongUsCapturePath);
                }
                if (BootBetterCrewLink.Enabled && BootBetterCrewLink.Checked)
                {
                    execCommand(BetterCrewLinkPath);
                }

                execCommand(openCommand);

            }
        }
        void execCommand(String cmd)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo(cmd);
            startInfo.UseShellExecute = true;
            System.Diagnostics.Process.Start(startInfo);
        }

        void clearModDLL()
        {
            if (Directory.Exists(getModInstallFolder()))
            {
                foreach (string fileName in Directory.GetFiles(getModInstallFolder()))
                {
                    if (fileName.EndsWith(".dll"))
                    {
                        File.Delete(fileName);
                    }
                }
            }
        }
        String getModName(String[] files)
        {
            foreach(var fileName in files)
            {
                var ModName = GetFilePropertyValue(fileName, 34);
                var ModVer = GetFilePropertyValue(fileName, 166);
                if (ModName.ToLower() != "reactor")
                {
                    return ModName + ModVer;
                }
            }
            return "";
        }

        void copyModDll(String [] files)
        {

            var ModName = getModName(files);
            var dllpath = Path.Combine(dllStorePath , ModName);
            Directory.CreateDirectory(dllpath);
            foreach (var fileName in files) {
                var dest = Path.Combine(dllpath, Path.GetFileName(fileName));
                try
                {
                    File.Copy(fileName, dest,true);
                }
                catch
                {
                    return;
                }
            }
            AddModDLL(dllpath);

        }

        void AddModDLL(String DllPath)
        {
            var ModName = Path.GetFileName(DllPath);
            string[] item = { ModName, DllPath };
            var test = ModList.FindItemWithText(ModName);
            if(test==null)
            {
                ModList.Items.Add(new ListViewItem(item));
            }


        }

        public static string GetFilePropertyValue(string file, int property_index)
        {

            var shellAppType = Type.GetTypeFromProgID("Shell.Application");
            dynamic shell = Activator.CreateInstance(shellAppType);

            string ret = "";

            try
            {
                //フォルダを取得
                var objFolder = shell.NameSpace(System.IO.Path.GetDirectoryName(file));

                //ファイルを取得
                var folderItem = objFolder.ParseName(System.IO.Path.GetFileName(file));

                //プロパティ情報を取得
                ret = objFolder.GetDetailsOf(folderItem, property_index);

                if (ret.Trim() == "")
                {
                    return "";
                }

            }
            catch
            {
                return "";
            }

            return ret;
        }

        private void extractMod(string fileName)
        {
            clearModDLL();
            ZipFile.ExtractToDirectory(fileName, installFolder, true);
/*
            using (ZipArchive zip = ZipFile.OpenRead(fileName))
            {
                foreach (var entry in zip.Entries)
                {
                    var fullPath = Path.Combine(installFolder, entry.FullName);
                    if (entry.Name == "")
                    {
                        if (!Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                    }
                    else
                    {
                        entry.ExtractToFile(fullPath, true);

                    }
                }

            }
            var modName = Path.GetFileNameWithoutExtension(fileName);
*/
            copyModDll(Directory.GetFiles(getModInstallFolder()));
        }

        void findModDLL(String filename)
        {
            if (Directory.Exists(filename))
            {
                foreach(var child in Directory.GetFiles(filename))
                {
                    findModDLL(child);
                }
            }else if (Path.GetExtension(filename).ToLower()==".dll")
            {
                String [] files = { filename }; 
                copyModDll(files);

            }

        }

        void listupDLL()
        {
            ModList.Items.Clear();
            string[] item = { "Vanilla", "", "" };
            ModList.Items.Add(new ListViewItem(item));

            foreach (string fileName in Directory.GetDirectories(dllStorePath)) {
                AddModDLL(fileName);
            }
            textUpdate();

        }

        private void UpdateList_Click(object sender, EventArgs e)
        {
            listupDLL();
        }

        void textUpdate()
        {
            saveSetting();
            if (openCommand.Contains("steam"))
            {
                ShortcutType.Text = "Steam";
            }else if (openCommand.Contains("epicgames"))
            {
                ShortcutType.Text = "Epic";
            }
            else
            {
                ShortcutType.Text = "????";
            }

            if (installFolder.Contains("Steam"))
            {
                exeType.Text = "Steam";
            }else if (installFolder.Contains("Epic"))
            {
                exeType.Text = "Epic";
            }
            else
            {
                exeType.Text = "????";
            }

            if (AmongUsCapturePath == "")
            {
                AmongUsMuteCaptureStatus.Text = "";
                BootAmongUsMuteCapture.Enabled = false;
            }
            else
            {
                AmongUsMuteCaptureStatus.Text = "OK";
                BootAmongUsMuteCapture.Enabled = true;

            }

            if (BetterCrewLinkPath == "")
            {
                BetterCrewLinkStatus.Text = "";
                BootBetterCrewLink.Enabled = false;
            }
            else
            {
                BetterCrewLinkStatus.Text = "OK";
                BootBetterCrewLink.Enabled = true;

            }

            var path = getModInstallFolder();
            if (ShortcutType.Text=="????" || exeType.Text=="????")
            {
                Start.Enabled = false;
                infoText.Text = "ショートカット/.exeを登録してください";

            }
            else if (exeType.Text != "????" && Directory.Exists(path))
            {
                Start.Enabled = true;
                infoText.Text = "MOD準備OK";
            }
            else
            {
                Start.Enabled = false;
                infoText.Text = "ModのZipファイルを登録してください";
            }
        }

        private void BootAmongUsMuteCapture_CheckedChanged(object sender, EventArgs e)
        {
            if (BootAmongUsMuteCapture.Checked)
            {
                BootBetterCrewLink.Checked = false;
            }
        }

        private void BootBetterCrewLink_CheckedChanged(object sender, EventArgs e)
        {
            if (BootBetterCrewLink.Checked)
            {
                BootAmongUsMuteCapture.Checked = false;
            }

        }

    }

}
