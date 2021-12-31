
namespace AmongUsModInstaller
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageGame = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStore = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewToolsGame = new System.Windows.Forms.DataGridView();
            this.ToolRun1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToolName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolPath1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonOtherTool = new System.Windows.Forms.RadioButton();
            this.radioButtonBetterCrewLink = new System.Windows.Forms.RadioButton();
            this.radioButtonAmongUsCapture = new System.Windows.Forms.RadioButton();
            this.radioButtonNoTool = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewMod = new System.Windows.Forms.ListView();
            this.ModName = new System.Windows.Forms.ColumnHeader();
            this.ModPath = new System.Windows.Forms.ColumnHeader();
            this.radioMod = new System.Windows.Forms.RadioButton();
            this.radioVanila = new System.Windows.Forms.RadioButton();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewToolSetting = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteTool = new System.Windows.Forms.Button();
            this.buttonAddTool = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBetterCrewLinkPath = new System.Windows.Forms.TextBox();
            this.buttonBetterCrewLonk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmongUsCapturePath = new System.Windows.Forms.TextBox();
            this.buttonAmongUsCapture = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAmongUsFolderOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExePlatform = new System.Windows.Forms.TextBox();
            this.buttonAmongUsExe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShortcutPlatform = new System.Windows.Forms.TextBox();
            this.buttonAmongUsShortcut = new System.Windows.Forms.Button();
            this.OtherToolsSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlSetting.SuspendLayout();
            this.tabPageGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToolsGame)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToolSetting)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherToolsSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.AllowDrop = true;
            this.tabControlSetting.Controls.Add(this.tabPageGame);
            this.tabControlSetting.Controls.Add(this.tabPageSetting);
            this.tabControlSetting.Location = new System.Drawing.Point(12, 12);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(776, 426);
            this.tabControlSetting.TabIndex = 0;
            this.tabControlSetting.SelectedIndexChanged += new System.EventHandler(this.tabControlSetting_SelectedIndexChanged);
            // 
            // tabPageGame
            // 
            this.tabPageGame.AllowDrop = true;
            this.tabPageGame.Controls.Add(this.label8);
            this.tabPageGame.Controls.Add(this.labelVersion);
            this.tabPageGame.Controls.Add(this.label7);
            this.tabPageGame.Controls.Add(this.pictureBox1);
            this.tabPageGame.Controls.Add(this.label6);
            this.tabPageGame.Controls.Add(this.textBoxStore);
            this.tabPageGame.Controls.Add(this.textBoxInfo);
            this.tabPageGame.Controls.Add(this.groupBox5);
            this.tabPageGame.Controls.Add(this.groupBox3);
            this.tabPageGame.Controls.Add(this.buttonGameStart);
            this.tabPageGame.Location = new System.Drawing.Point(4, 24);
            this.tabPageGame.Name = "tabPageGame";
            this.tabPageGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGame.Size = new System.Drawing.Size(768, 398);
            this.tabPageGame.TabIndex = 0;
            this.tabPageGame.Text = "GAME";
            this.tabPageGame.UseVisualStyleBackColor = true;
            this.tabPageGame.DragDrop += new System.Windows.Forms.DragEventHandler(this.TabPageGame_DragDrop);
            this.tabPageGame.DragEnter += new System.Windows.Forms.DragEventHandler(this.TabPageGame_DragEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Copyright 🄫 2021 こう。";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(486, 34);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(38, 15);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Among Us Mod管理ツール";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(687, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "GameStore";
            // 
            // textBoxStore
            // 
            this.textBoxStore.Location = new System.Drawing.Point(206, 25);
            this.textBoxStore.Name = "textBoxStore";
            this.textBoxStore.Size = new System.Drawing.Size(100, 23);
            this.textBoxStore.TabIndex = 4;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(206, 54);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(268, 23);
            this.textBoxInfo.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewToolsGame);
            this.groupBox5.Controls.Add(this.radioButtonOtherTool);
            this.groupBox5.Controls.Add(this.radioButtonBetterCrewLink);
            this.groupBox5.Controls.Add(this.radioButtonAmongUsCapture);
            this.groupBox5.Controls.Add(this.radioButtonNoTool);
            this.groupBox5.Location = new System.Drawing.Point(450, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 297);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "その他ツール";
            // 
            // dataGridViewToolsGame
            // 
            this.dataGridViewToolsGame.AllowUserToAddRows = false;
            this.dataGridViewToolsGame.AllowUserToDeleteRows = false;
            this.dataGridViewToolsGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToolsGame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolRun1,
            this.ToolName1,
            this.ToolPath1});
            this.dataGridViewToolsGame.Location = new System.Drawing.Point(7, 124);
            this.dataGridViewToolsGame.Name = "dataGridViewToolsGame";
            this.dataGridViewToolsGame.RowTemplate.Height = 25;
            this.dataGridViewToolsGame.Size = new System.Drawing.Size(299, 167);
            this.dataGridViewToolsGame.TabIndex = 4;
            // 
            // ToolRun1
            // 
            this.ToolRun1.DataPropertyName = "ToolRun";
            this.ToolRun1.FalseValue = "false";
            this.ToolRun1.HeaderText = "実行";
            this.ToolRun1.IndeterminateValue = "null";
            this.ToolRun1.Name = "ToolRun1";
            this.ToolRun1.TrueValue = "true";
            this.ToolRun1.Width = 60;
            // 
            // ToolName1
            // 
            this.ToolName1.DataPropertyName = "ToolName";
            this.ToolName1.HeaderText = "ツール名";
            this.ToolName1.Name = "ToolName1";
            this.ToolName1.ReadOnly = true;
            this.ToolName1.Width = 200;
            // 
            // ToolPath1
            // 
            this.ToolPath1.DataPropertyName = "ToolPath";
            this.ToolPath1.HeaderText = "ファイルパス";
            this.ToolPath1.Name = "ToolPath1";
            this.ToolPath1.ReadOnly = true;
            this.ToolPath1.Visible = false;
            // 
            // radioButtonOtherTool
            // 
            this.radioButtonOtherTool.AutoSize = true;
            this.radioButtonOtherTool.Location = new System.Drawing.Point(6, 98);
            this.radioButtonOtherTool.Name = "radioButtonOtherTool";
            this.radioButtonOtherTool.Size = new System.Drawing.Size(56, 19);
            this.radioButtonOtherTool.TabIndex = 3;
            this.radioButtonOtherTool.Text = "その他";
            this.radioButtonOtherTool.UseVisualStyleBackColor = true;
            // 
            // radioButtonBetterCrewLink
            // 
            this.radioButtonBetterCrewLink.AutoSize = true;
            this.radioButtonBetterCrewLink.Location = new System.Drawing.Point(6, 73);
            this.radioButtonBetterCrewLink.Name = "radioButtonBetterCrewLink";
            this.radioButtonBetterCrewLink.Size = new System.Drawing.Size(109, 19);
            this.radioButtonBetterCrewLink.TabIndex = 2;
            this.radioButtonBetterCrewLink.Text = "Better-CrewLink";
            this.radioButtonBetterCrewLink.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmongUsCapture
            // 
            this.radioButtonAmongUsCapture.AutoSize = true;
            this.radioButtonAmongUsCapture.Location = new System.Drawing.Point(6, 48);
            this.radioButtonAmongUsCapture.Name = "radioButtonAmongUsCapture";
            this.radioButtonAmongUsCapture.Size = new System.Drawing.Size(146, 19);
            this.radioButtonAmongUsCapture.TabIndex = 1;
            this.radioButtonAmongUsCapture.Text = "AmongUsMuteCapture";
            this.radioButtonAmongUsCapture.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoTool
            // 
            this.radioButtonNoTool.AutoSize = true;
            this.radioButtonNoTool.Checked = true;
            this.radioButtonNoTool.Location = new System.Drawing.Point(6, 23);
            this.radioButtonNoTool.Name = "radioButtonNoTool";
            this.radioButtonNoTool.Size = new System.Drawing.Size(77, 19);
            this.radioButtonNoTool.TabIndex = 0;
            this.radioButtonNoTool.TabStop = true;
            this.radioButtonNoTool.Text = "使用しない";
            this.radioButtonNoTool.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewMod);
            this.groupBox3.Controls.Add(this.radioMod);
            this.groupBox3.Controls.Add(this.radioVanila);
            this.groupBox3.Location = new System.Drawing.Point(6, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 303);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mod選択";
            // 
            // listViewMod
            // 
            this.listViewMod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModName,
            this.ModPath});
            this.listViewMod.HideSelection = false;
            this.listViewMod.Location = new System.Drawing.Point(7, 74);
            this.listViewMod.Name = "listViewMod";
            this.listViewMod.Size = new System.Drawing.Size(423, 223);
            this.listViewMod.TabIndex = 2;
            this.listViewMod.UseCompatibleStateImageBehavior = false;
            this.listViewMod.View = System.Windows.Forms.View.Details;
            this.listViewMod.SelectedIndexChanged += new System.EventHandler(this.ListViewMod_SelectedIndexChanged);
            // 
            // ModName
            // 
            this.ModName.Text = "Mod名";
            this.ModName.Width = 120;
            // 
            // ModPath
            // 
            this.ModPath.Text = "Path";
            this.ModPath.Width = 300;
            // 
            // radioMod
            // 
            this.radioMod.AutoSize = true;
            this.radioMod.Location = new System.Drawing.Point(7, 49);
            this.radioMod.Name = "radioMod";
            this.radioMod.Size = new System.Drawing.Size(74, 19);
            this.radioMod.TabIndex = 1;
            this.radioMod.Text = "Mod使用";
            this.radioMod.UseVisualStyleBackColor = true;
            this.radioMod.CheckedChanged += new System.EventHandler(this.RadioMod_CheckedChanged);
            // 
            // radioVanila
            // 
            this.radioVanila.AutoSize = true;
            this.radioVanila.Checked = true;
            this.radioVanila.Location = new System.Drawing.Point(7, 23);
            this.radioVanila.Name = "radioVanila";
            this.radioVanila.Size = new System.Drawing.Size(112, 19);
            this.radioVanila.TabIndex = 0;
            this.radioVanila.TabStop = true;
            this.radioVanila.Text = "Vanilla(Mod無し)";
            this.radioVanila.UseVisualStyleBackColor = true;
            this.radioVanila.CheckedChanged += new System.EventHandler(this.RadioVanila_CheckedChanged);
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Location = new System.Drawing.Point(6, 6);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(194, 71);
            this.buttonGameStart.TabIndex = 0;
            this.buttonGameStart.Text = "Among Us起動";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            this.buttonGameStart.Click += new System.EventHandler(this.ButtonGameStart_Click);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.AllowDrop = true;
            this.tabPageSetting.Controls.Add(this.groupBox4);
            this.tabPageSetting.Controls.Add(this.groupBox2);
            this.tabPageSetting.Controls.Add(this.groupBox1);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(768, 398);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "設定";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            this.tabPageSetting.DragDrop += new System.Windows.Forms.DragEventHandler(this.TabPageSetting_DragDrop);
            this.tabPageSetting.DragEnter += new System.Windows.Forms.DragEventHandler(this.TabPageSetting_DragEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewToolSetting);
            this.groupBox4.Controls.Add(this.buttonDeleteTool);
            this.groupBox4.Controls.Add(this.buttonAddTool);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxBetterCrewLinkPath);
            this.groupBox4.Controls.Add(this.buttonBetterCrewLonk);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxAmongUsCapturePath);
            this.groupBox4.Controls.Add(this.buttonAmongUsCapture);
            this.groupBox4.Location = new System.Drawing.Point(6, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(756, 231);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "その他ツール";
            // 
            // dataGridViewToolSetting
            // 
            this.dataGridViewToolSetting.AllowUserToAddRows = false;
            this.dataGridViewToolSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToolSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewToolSetting.Location = new System.Drawing.Point(87, 81);
            this.dataGridViewToolSetting.Name = "dataGridViewToolSetting";
            this.dataGridViewToolSetting.RowTemplate.Height = 25;
            this.dataGridViewToolSetting.Size = new System.Drawing.Size(663, 144);
            this.dataGridViewToolSetting.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ToolRun";
            this.Column1.HeaderText = "実行";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ToolName";
            this.Column2.HeaderText = "ツール名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ToolPath";
            this.Column3.HeaderText = "パス名";
            this.Column3.Name = "Column3";
            this.Column3.Width = 500;
            // 
            // buttonDeleteTool
            // 
            this.buttonDeleteTool.Location = new System.Drawing.Point(5, 110);
            this.buttonDeleteTool.Name = "buttonDeleteTool";
            this.buttonDeleteTool.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTool.TabIndex = 13;
            this.buttonDeleteTool.Text = "削除";
            this.buttonDeleteTool.UseVisualStyleBackColor = true;
            this.buttonDeleteTool.Click += new System.EventHandler(this.ButtonDeleteTool_Click);
            // 
            // buttonAddTool
            // 
            this.buttonAddTool.Location = new System.Drawing.Point(5, 80);
            this.buttonAddTool.Name = "buttonAddTool";
            this.buttonAddTool.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTool.TabIndex = 12;
            this.buttonAddTool.Text = "追加";
            this.buttonAddTool.UseVisualStyleBackColor = true;
            this.buttonAddTool.Click += new System.EventHandler(this.ButtonAddTool_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Path";
            // 
            // textBoxBetterCrewLinkPath
            // 
            this.textBoxBetterCrewLinkPath.Location = new System.Drawing.Point(223, 52);
            this.textBoxBetterCrewLinkPath.Name = "textBoxBetterCrewLinkPath";
            this.textBoxBetterCrewLinkPath.Size = new System.Drawing.Size(527, 23);
            this.textBoxBetterCrewLinkPath.TabIndex = 9;
            // 
            // buttonBetterCrewLonk
            // 
            this.buttonBetterCrewLonk.Location = new System.Drawing.Point(2, 51);
            this.buttonBetterCrewLonk.Name = "buttonBetterCrewLonk";
            this.buttonBetterCrewLonk.Size = new System.Drawing.Size(176, 23);
            this.buttonBetterCrewLonk.TabIndex = 8;
            this.buttonBetterCrewLonk.Text = "Better-CrewLinkの指定";
            this.buttonBetterCrewLonk.UseVisualStyleBackColor = true;
            this.buttonBetterCrewLonk.Click += new System.EventHandler(this.ButtonBetterCrewLonk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Path";
            // 
            // textBoxAmongUsCapturePath
            // 
            this.textBoxAmongUsCapturePath.Location = new System.Drawing.Point(223, 23);
            this.textBoxAmongUsCapturePath.Name = "textBoxAmongUsCapturePath";
            this.textBoxAmongUsCapturePath.Size = new System.Drawing.Size(527, 23);
            this.textBoxAmongUsCapturePath.TabIndex = 6;
            // 
            // buttonAmongUsCapture
            // 
            this.buttonAmongUsCapture.Location = new System.Drawing.Point(1, 22);
            this.buttonAmongUsCapture.Name = "buttonAmongUsCapture";
            this.buttonAmongUsCapture.Size = new System.Drawing.Size(177, 23);
            this.buttonAmongUsCapture.TabIndex = 5;
            this.buttonAmongUsCapture.Text = "AmongUs Captureの指定";
            this.buttonAmongUsCapture.UseVisualStyleBackColor = true;
            this.buttonAmongUsCapture.Click += new System.EventHandler(this.ButtonAmongUsCapture_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAmongUsFolderOpen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxExePath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxExePlatform);
            this.groupBox2.Controls.Add(this.buttonAmongUsExe);
            this.groupBox2.Location = new System.Drawing.Point(6, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AmongUsフォルダの登録";
            // 
            // buttonAmongUsFolderOpen
            // 
            this.buttonAmongUsFolderOpen.Location = new System.Drawing.Point(391, 23);
            this.buttonAmongUsFolderOpen.Name = "buttonAmongUsFolderOpen";
            this.buttonAmongUsFolderOpen.Size = new System.Drawing.Size(110, 23);
            this.buttonAmongUsFolderOpen.TabIndex = 5;
            this.buttonAmongUsFolderOpen.Text = "フォルダを開く";
            this.buttonAmongUsFolderOpen.UseVisualStyleBackColor = true;
            this.buttonAmongUsFolderOpen.Click += new System.EventHandler(this.ButtonAmongUsFolderOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path";
            // 
            // textBoxExePath
            // 
            this.textBoxExePath.Location = new System.Drawing.Point(55, 53);
            this.textBoxExePath.Name = "textBoxExePath";
            this.textBoxExePath.Size = new System.Drawing.Size(695, 23);
            this.textBoxExePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "プラットフォーム";
            // 
            // textBoxExePlatform
            // 
            this.textBoxExePlatform.Location = new System.Drawing.Point(233, 24);
            this.textBoxExePlatform.Name = "textBoxExePlatform";
            this.textBoxExePlatform.Size = new System.Drawing.Size(140, 23);
            this.textBoxExePlatform.TabIndex = 1;
            // 
            // buttonAmongUsExe
            // 
            this.buttonAmongUsExe.Location = new System.Drawing.Point(7, 23);
            this.buttonAmongUsExe.Name = "buttonAmongUsExe";
            this.buttonAmongUsExe.Size = new System.Drawing.Size(140, 23);
            this.buttonAmongUsExe.TabIndex = 0;
            this.buttonAmongUsExe.Text = "Among Us.exeの指定";
            this.buttonAmongUsExe.UseVisualStyleBackColor = true;
            this.buttonAmongUsExe.Click += new System.EventHandler(this.ButtonAmongUsExe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxShortcutPlatform);
            this.groupBox1.Controls.Add(this.buttonAmongUsShortcut);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AmongUsショートカットの登録";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "プラットフォーム";
            // 
            // textBoxShortcutPlatform
            // 
            this.textBoxShortcutPlatform.Location = new System.Drawing.Point(233, 24);
            this.textBoxShortcutPlatform.Name = "textBoxShortcutPlatform";
            this.textBoxShortcutPlatform.Size = new System.Drawing.Size(140, 23);
            this.textBoxShortcutPlatform.TabIndex = 1;
            // 
            // buttonAmongUsShortcut
            // 
            this.buttonAmongUsShortcut.Location = new System.Drawing.Point(7, 23);
            this.buttonAmongUsShortcut.Name = "buttonAmongUsShortcut";
            this.buttonAmongUsShortcut.Size = new System.Drawing.Size(140, 23);
            this.buttonAmongUsShortcut.TabIndex = 0;
            this.buttonAmongUsShortcut.Text = "ショートカットの指定";
            this.buttonAmongUsShortcut.UseVisualStyleBackColor = true;
            this.buttonAmongUsShortcut.Click += new System.EventHandler(this.ButtonAmongUsShortcut_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "AmongUsMod管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlSetting.ResumeLayout(false);
            this.tabPageGame.ResumeLayout(false);
            this.tabPageGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToolsGame)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToolSetting)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherToolsSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPageGame;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewMod;
        private System.Windows.Forms.ColumnHeader ModName;
        private System.Windows.Forms.ColumnHeader ModPath;
        private System.Windows.Forms.RadioButton radioMod;
        private System.Windows.Forms.RadioButton radioVanila;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExePlatform;
        private System.Windows.Forms.Button buttonAmongUsExe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShortcutPlatform;
        private System.Windows.Forms.Button buttonAmongUsShortcut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAmongUsFolderOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBetterCrewLinkPath;
        private System.Windows.Forms.Button buttonBetterCrewLonk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmongUsCapturePath;
        private System.Windows.Forms.Button buttonAmongUsCapture;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonOtherTool;
        private System.Windows.Forms.RadioButton radioButtonBetterCrewLink;
        private System.Windows.Forms.RadioButton radioButtonAmongUsCapture;
        private System.Windows.Forms.RadioButton radioButtonNoTool;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewToolsGame;
        public System.Windows.Forms.BindingSource OtherToolsSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ToolRun1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolPath1;
        private System.Windows.Forms.DataGridView dataGridViewToolSetting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonDeleteTool;
        private System.Windows.Forms.Button buttonAddTool;
    }
}

