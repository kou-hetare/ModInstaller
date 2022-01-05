using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModInstaller
{
    public partial class FormMain : Form
    {
        private AppSetting appsetting = new();

        public FormMain()
        {
            InitializeComponent();
        }

        void LoadSetting()
        {
            try
            {
                using var sr = new StreamReader("setting.json");
                var json = sr.ReadToEnd();
                appsetting = JsonSerializer.Deserialize<AppSetting>(json);
            }
            catch (Exception)
            {
                return;
            }

        }

        void SaveSetting()
        {
            try
            {
                var json = JsonSerializer.Serialize<AppSetting>(appsetting);
                using var sw = new StreamWriter("setting.json");
                sw.Write(json);
            }
            catch (Exception)
            {

            }
        }
        String GetModInstallFolder()
        {
            String ret = "";
            if (appsetting.AmongUsFolder != "")
            {
                ret = Path.Combine(appsetting.AmongUsFolder, "BepInEx\\plugins");
            }
            return ret;
        }

        static String GetDllStorePath()
        {
            var exePath = Path.GetDirectoryName(Application.ExecutablePath);
            var dllStorePath = Path.Combine(exePath, "MODs");
            return dllStorePath;
        }

        static void ExecCommand(String cmd)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo(cmd)
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        void ClearModDLL()
        {
            if (Directory.Exists(GetModInstallFolder()))
            {
                foreach (string fileName in Directory.GetFiles(GetModInstallFolder()))
                {
                    if (fileName.EndsWith(".dll"))
                    {
                        File.Delete(fileName);
                    }
                }
            }
        }

        static String GetModName(String[] files)
        {
            foreach (var fileName in files)
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

        void CopyModDll(String[] files)
        {

            var ModName = GetModName(files);
            var dllpath = Path.Combine(GetDllStorePath(), ModName);
            Directory.CreateDirectory(dllpath);
            foreach (var fileName in files)
            {
                var dest = Path.Combine(dllpath, Path.GetFileName(fileName));
                try
                {
                    File.Copy(fileName, dest, true);
                }
                catch
                {
                    return;
                }
            }
            AddModDLL(ModName);

        }

        void AddModDLL(String ModName)
        {
            string[] item = { ModName, "MODs\\"+ModName };
            var test = listViewMod.FindItemWithText(ModName);
            if (test == null)
            {
                listViewMod.Items.Add(new ListViewItem(item));
            }


        }

        public static string GetFilePropertyValue(string file, int property_index)
        {

            var shellAppType = Type.GetTypeFromProgID("Shell.Application");
            dynamic shell = Activator.CreateInstance(shellAppType);

            string ret;
            try
            {
                //フォルダを取得
                var objFolder = shell.NameSpace(System.IO.Path.GetDirectoryName(file));

                //ファイルを取得
                var folderItem = objFolder.ParseName(System.IO.Path.GetFileName(file));

                //プロパティ情報を取得
                ret = objFolder.GetDetailsOf(folderItem, property_index);
            }
            catch
            {
                return "";
            }

            return ret.Trim();
        }

        private void ExtractMod(string fileName)
        {
            ClearModDLL();
            ZipFile.ExtractToDirectory(fileName, appsetting.AmongUsFolder, true);
            CopyModDll(Directory.GetFiles(GetModInstallFolder()));
        }

        void FindModDLL(String filename)
        {
            if (Directory.Exists(filename))
            {
                foreach (var child in Directory.GetFiles(filename))
                {
                    FindModDLL(child);
                }
            }
            else if (Path.GetExtension(filename).ToLower() == ".dll")
            {
                String[] files = { filename };
                CopyModDll(files);

            }

        }

        void ListupDLL()
        {
            listViewMod.Items.Clear();
            var dllPath = GetDllStorePath();
            if (!Directory.Exists(dllPath)) return;

            foreach (string DirName in Directory.GetDirectories(dllPath))
            {
                AddModDLL(Path.GetFileName(DirName));
            }
            TextUpdate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            labelVersion.Text = "Ver." + ver.ToString();

            LoadSetting();
            TextUpdate();
            ListupDLL();
            
            OtherToolsSource.DataSource = appsetting.OtherTools;
            dataGridViewToolSetting.DataSource = OtherToolsSource;
            dataGridViewToolsGame.DataSource = OtherToolsSource;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        void TextUpdate()
        {
            SaveSetting();
            if (appsetting.AmongUsURL.ToLower().Contains("steam"))
            {
                textBoxShortcutPlatform.Text = "Steam";
            }
            else if (appsetting.AmongUsURL.ToLower().Contains("epicgames"))
            {
                textBoxShortcutPlatform.Text = "Epic";
            }
            else
            {
                textBoxShortcutPlatform.Text = "????";
            }

            textBoxExePath.Text = appsetting.AmongUsFolder;

            if (appsetting.AmongUsFolder.ToLower().Contains("steam"))
            {
                textBoxExePlatform.Text = "Steam";
            }
            else if (appsetting.AmongUsFolder.ToLower().Contains("epic"))
            {
                textBoxExePlatform.Text = "Epic";
            }
            else
            {
                textBoxExePlatform.Text = "????";
            }

            textBoxAmongUsCapturePath.Text = appsetting.AmongUsCaptureExe;
            if (appsetting.AmongUsCaptureExe == "")
            {
                radioButtonAmongUsCapture.Enabled = false;
            }
            else
            {
                radioButtonAmongUsCapture.Enabled = true;

            }

            textBoxBetterCrewLinkPath.Text = appsetting.BetterCrewLinkExe;
            if (appsetting.BetterCrewLinkExe == "")
            {
                radioButtonBetterCrewLink.Enabled = false;
            }
            else
            {
                radioButtonBetterCrewLink.Enabled = true;

            }
            if (appsetting.OtherTools.Count == 0)
            {
                radioButtonOtherTool.Enabled = false;
            }
            else
            {
                radioButtonOtherTool.Enabled = true;
            }
            UpdateButtonStart();
        }

        void UpdateButtonStart()
        {
            var path = GetModInstallFolder();
            if (textBoxShortcutPlatform.Text == "????" || textBoxExePlatform.Text == "????")
            {
                textBoxStore.Text = "????";
                buttonGameStart.Enabled = false;
                textBoxInfo.Text = "ショートカット/.exeを登録してください";
                return;
            }

            if (textBoxShortcutPlatform.Text !=  textBoxExePlatform.Text) 
            {
                textBoxStore.Text = "????";
                buttonGameStart.Enabled = false;
                textBoxInfo.Text = "Among Us設定が未完了です";
                return;
            }
            textBoxStore.Text = textBoxShortcutPlatform.Text;
            if (path != "" && Directory.Exists(path))
            {
                textBoxInfo.Text = "MOD準備OK";

                buttonGameStart.Enabled = radioVanila.Checked || listViewMod.SelectedItems.Count == 1;
            }
            else
            {
                buttonGameStart.Enabled = false;
                textBoxInfo.Text = "ModのZipファイルを登録してください";
                buttonGameStart.Enabled = radioVanila.Checked;
            }
        }
        void ReadUrlFile(String filename)
        {
            try
            {
                using var sr = new System.IO.StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    if (line.StartsWith("URL"))
                    {
                        appsetting.AmongUsURL = line[4..];
                    }
                    if (line.StartsWith("IconFile"))
                    {
                        if (line.Contains("Epic"))
                        {
                            appsetting.AmongUsFolder = Path.GetDirectoryName(line[9..]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ButtonAmongUsShortcut_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Among Usショートカット|*.url",
                DereferenceLinks = false
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ReadUrlFile(dlg.FileName);
                TextUpdate();
            }

        }

        private void ButtonAmongUsExe_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Among Us|Among Us.exe"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                appsetting.AmongUsFolder = Path.GetDirectoryName(dlg.FileName);
                TextUpdate();
            }

        }

        private void ButtonAmongUsFolderOpen_Click(object sender, EventArgs e)
        {
            if (appsetting.AmongUsFolder != "")
            {
                ExecCommand(appsetting.AmongUsFolder);
            }
        }

        private void ButtonAmongUsCapture_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "AmongUsCapture|AmongUsCapture.exe;AmongUsCapture.lnk"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                appsetting.AmongUsCaptureExe = dlg.FileName;

                TextUpdate();
            }

        }

        private void ButtonBetterCrewLonk_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Better-CrewLink|Better-CrewLink.exe;Better-CrewLink.lnk"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                appsetting.BetterCrewLinkExe = dlg.FileName;

                TextUpdate();
            }

        }

        private void RadioVanila_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStart();
        }

        private void RadioMod_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStart();
        }

        private void TabPageSetting_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void TabPageSetting_DragDrop(object sender, DragEventArgs e)
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
                        ReadUrlFile(fileName);
                    }
                    else if (Path.GetFileName(fileName) == "Among Us.exe")
                    {
                        appsetting.AmongUsFolder = Path.GetDirectoryName(fileName);

                    }
                    else if (Path.GetFileName(fileName) == "AmongUsCapture.exe")
                    {
                        appsetting.AmongUsCaptureExe = file;
                    }
                    else if (Path.GetFileName(fileName) == "Better-CrewLink.exe")
                    {
                        appsetting.BetterCrewLinkExe = file;
                    }

                }
                TextUpdate();
            }

        }

        private void TabPageGame_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void TabPageGame_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string file
                in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    var ext = Path.GetExtension(file).ToLower();
                    String fileName = file;
                    if (ext == ".zip")
                    {
                        ExtractMod(fileName);

                    }
                    else
                    {
                        FindModDLL(fileName);
                    }

                }
            }
        }

        private void ListViewMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMod.SelectedItems.Count == 1)
            {
                radioMod.Checked = true;
                buttonGameStart.Enabled = true;
            }
            else
            {
                buttonGameStart.Enabled = false;
            }
            if (listViewMod.SelectedItems.Count > 0)
            {
                contextMenuStrip1.Enabled=true;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void ButtonGameStart_Click(object sender, EventArgs e)
        {
            ClearModDLL();

            if (radioMod.Checked)
            {
                var modName = listViewMod.SelectedItems[0].Text;
                var dllpath = Path.Combine(GetDllStorePath(), modName);
                var dllFiles = Directory.GetFiles(dllpath);
                foreach (var srcfileName in dllFiles)
                {
                    var dllname = Path.GetFileName(srcfileName);

                    File.Copy(srcfileName, Path.Combine(GetModInstallFolder(), dllname));

                }
            }

            if (radioButtonAmongUsCapture.Checked)
            {
                ExecCommand(appsetting.AmongUsCaptureExe);
            }
            if (radioButtonBetterCrewLink.Checked)
            {
                ExecCommand(appsetting.BetterCrewLinkExe);
            }
            if (radioButtonOtherTool.Checked)
            {
                foreach(var tool in appsetting.OtherTools)
                {
                    if (tool.ToolRun)
                    {
                        ExecCommand(tool.ToolPath);
                    }
                }
            }
            ExecCommand(appsetting.AmongUsURL);
            buttonGameStart.Enabled = false;
            buttonGameStart.Text = "起動中";
            var task=Task.Run(()=>TimerStart());
            task.Wait();
            timer1.Enabled = true;
        }

        private void ButtonAddTool_Click(object sender, EventArgs e)
        {
            var dlg = new AddToolForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AppSetting.OtherTool item = new() { ToolName=dlg.toolName, ToolPath=dlg.toolPath };
                appsetting.OtherTools.Add(item);
                OtherToolsSource.ResetBindings(true);
                SaveSetting();
            }
        }

        private void ButtonDeleteTool_Click(object sender, EventArgs e)
        {
            if (dataGridViewToolSetting.SelectedRows.Count > 0)
            {
                List<int> indexList = new();

                foreach(DataGridViewRow item in dataGridViewToolSetting.SelectedRows)
                {
                    indexList.Add(item.Index);
                }
                indexList.Reverse();
                foreach(var index in indexList)
                {
                    appsetting.OtherTools.RemoveAt(index);
                }
                OtherToolsSource.ResetBindings(true);
            }
        }

        private void TabControlSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextUpdate();
        }

        private void TimerStart()
        {
            while(Process.GetProcessesByName("Among Us").Length == 0)
            {
                Thread.Sleep(100);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Process.GetProcessesByName("Among Us").Length == 0)
            {
                timer1.Enabled = false;
                buttonGameStart.Enabled = true;
                buttonGameStart.Text = "Among Us起動";
            }
        }

        private void dataGridViewToolSetting_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void dataGridViewToolSetting_DragDrop(object sender, DragEventArgs e)
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
                    String toolPath;
                    if (fileExt == ".url")
                    {
                        toolPath = fileName;
                    }
                    else
                    {
                        toolPath = file;

                    }
                    var dlg = new AddToolForm();
                    dlg.toolPath = toolPath;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        AppSetting.OtherTool item = new() { ToolName = dlg.toolName, ToolPath = dlg.toolPath };
                        appsetting.OtherTools.Add(item);
                        OtherToolsSource.ResetBindings(true);
                        SaveSetting();
                    }
                }
            }
            else if (e.Data.GetDataPresent("UniformResourceLocator"))
            {
                String url=e.Data.GetData(DataFormats.Text).ToString();
                var dlg = new AddToolForm();
                dlg.toolPath = url;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    AppSetting.OtherTool item = new() { ToolName = dlg.toolName, ToolPath = dlg.toolPath };
                    appsetting.OtherTools.Add(item);
                    OtherToolsSource.ResetBindings(true);
                    SaveSetting();
                }
            }
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            if (listViewMod.SelectedItems.Count > 0)
            {
                var dll_store_path = GetDllStorePath();
                foreach (ListViewItem item in listViewMod.SelectedItems)
                {
                    ExecCommand(Path.Combine(dll_store_path, item.Text));            
                }
            }

        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (listViewMod.SelectedItems.Count == 0) return;

            var dll_store_path = GetDllStorePath();
            var str = "下記Modを削除します。";
            foreach (ListViewItem item in listViewMod.SelectedItems)
            {
                str += "\r\n  " + item.Text;
            }
            if (MessageBox.Show(str, "Modの削除", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            while (listViewMod.SelectedItems.Count > 0)
            {
                var modname = listViewMod.SelectedItems[0].Text;
                Directory.Delete(Path.Combine(dll_store_path, modname), true);
                listViewMod.SelectedItems[0].Remove();
            }

        }
    }

}
