
namespace ModInstaller
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartSetting = new System.Windows.Forms.Button();
            this.FolderSetting = new System.Windows.Forms.Button();
            this.ModList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ListViewcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMod = new System.Windows.Forms.ToolStripMenuItem();
            this.Start = new System.Windows.Forms.Button();
            this.UpdateList = new System.Windows.Forms.Button();
            this.ShortcutType = new System.Windows.Forms.TextBox();
            this.exeType = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.TextBox();
            this.AmongUsMuteCaptureStatus = new System.Windows.Forms.TextBox();
            this.AmongUsMuteCapture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BetterCrewLinkStatus = new System.Windows.Forms.TextBox();
            this.BootAmongUsMuteCapture = new System.Windows.Forms.CheckBox();
            this.BootBetterCrewLink = new System.Windows.Forms.CheckBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewcontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartSetting
            // 
            this.StartSetting.Location = new System.Drawing.Point(14, 15);
            this.StartSetting.Margin = new System.Windows.Forms.Padding(4);
            this.StartSetting.Name = "StartSetting";
            this.StartSetting.Size = new System.Drawing.Size(240, 29);
            this.StartSetting.TabIndex = 0;
            this.StartSetting.Text = "AmongUs ショートカットの指定";
            this.StartSetting.UseVisualStyleBackColor = true;
            this.StartSetting.Click += new System.EventHandler(this.StartSetting_Click);
            // 
            // FolderSetting
            // 
            this.FolderSetting.Location = new System.Drawing.Point(14, 51);
            this.FolderSetting.Margin = new System.Windows.Forms.Padding(4);
            this.FolderSetting.Name = "FolderSetting";
            this.FolderSetting.Size = new System.Drawing.Size(240, 29);
            this.FolderSetting.TabIndex = 1;
            this.FolderSetting.Text = "Among Us.exeの指定";
            this.FolderSetting.UseVisualStyleBackColor = true;
            this.FolderSetting.Click += new System.EventHandler(this.FolderSetting_Click);
            // 
            // ModList
            // 
            this.ModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.ModList.ContextMenuStrip = this.ListViewcontextMenuStrip;
            this.ModList.GridLines = true;
            this.ModList.HideSelection = false;
            this.ModList.Location = new System.Drawing.Point(14, 193);
            this.ModList.Margin = new System.Windows.Forms.Padding(4);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(706, 203);
            this.ModList.TabIndex = 3;
            this.ModList.UseCompatibleStateImageBehavior = false;
            this.ModList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mod名";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 600;
            // 
            // ListViewcontextMenuStrip
            // 
            this.ListViewcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenExplorer,
            this.DeleteMod});
            this.ListViewcontextMenuStrip.Name = "ListViewcontextMenuStrip";
            this.ListViewcontextMenuStrip.Size = new System.Drawing.Size(165, 48);
            // 
            // OpenExplorer
            // 
            this.OpenExplorer.Name = "OpenExplorer";
            this.OpenExplorer.Size = new System.Drawing.Size(164, 22);
            this.OpenExplorer.Text = "エクスプローラで開く";
            this.OpenExplorer.Click += new System.EventHandler(this.OpenExplorer_Click);
            // 
            // DeleteMod
            // 
            this.DeleteMod.Name = "DeleteMod";
            this.DeleteMod.Size = new System.Drawing.Size(164, 22);
            this.DeleteMod.Text = "MODの削除";
            this.DeleteMod.Click += new System.EventHandler(this.DeleteMod_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(436, 15);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(182, 68);
            this.Start.TabIndex = 4;
            this.Start.Text = "ゲーム開始";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // UpdateList
            // 
            this.UpdateList.Location = new System.Drawing.Point(13, 404);
            this.UpdateList.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateList.Name = "UpdateList";
            this.UpdateList.Size = new System.Drawing.Size(239, 29);
            this.UpdateList.TabIndex = 5;
            this.UpdateList.Text = "Modリストの更新";
            this.UpdateList.UseVisualStyleBackColor = true;
            this.UpdateList.Click += new System.EventHandler(this.UpdateList_Click);
            // 
            // ShortcutType
            // 
            this.ShortcutType.Location = new System.Drawing.Point(279, 19);
            this.ShortcutType.Margin = new System.Windows.Forms.Padding(4);
            this.ShortcutType.Name = "ShortcutType";
            this.ShortcutType.Size = new System.Drawing.Size(116, 23);
            this.ShortcutType.TabIndex = 6;
            // 
            // exeType
            // 
            this.exeType.Location = new System.Drawing.Point(279, 55);
            this.exeType.Margin = new System.Windows.Forms.Padding(4);
            this.exeType.Name = "exeType";
            this.exeType.Size = new System.Drawing.Size(116, 23);
            this.exeType.TabIndex = 7;
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(13, 162);
            this.infoText.Margin = new System.Windows.Forms.Padding(4);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(603, 23);
            this.infoText.TabIndex = 8;
            // 
            // AmongUsMuteCaptureStatus
            // 
            this.AmongUsMuteCaptureStatus.AllowDrop = true;
            this.AmongUsMuteCaptureStatus.Location = new System.Drawing.Point(279, 92);
            this.AmongUsMuteCaptureStatus.Margin = new System.Windows.Forms.Padding(4);
            this.AmongUsMuteCaptureStatus.Name = "AmongUsMuteCaptureStatus";
            this.AmongUsMuteCaptureStatus.Size = new System.Drawing.Size(116, 23);
            this.AmongUsMuteCaptureStatus.TabIndex = 10;
            // 
            // AmongUsMuteCapture
            // 
            this.AmongUsMuteCapture.Location = new System.Drawing.Point(14, 88);
            this.AmongUsMuteCapture.Margin = new System.Windows.Forms.Padding(4);
            this.AmongUsMuteCapture.Name = "AmongUsMuteCapture";
            this.AmongUsMuteCapture.Size = new System.Drawing.Size(240, 29);
            this.AmongUsMuteCapture.TabIndex = 9;
            this.AmongUsMuteCapture.Text = "AmongUsMuteCaptureの指定";
            this.AmongUsMuteCapture.UseVisualStyleBackColor = true;
            this.AmongUsMuteCapture.Click += new System.EventHandler(this.AmongUsMuteCapture_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "BetterCrewLinkの指定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BetterCrewLink_Click);
            // 
            // BetterCrewLinkStatus
            // 
            this.BetterCrewLinkStatus.AllowDrop = true;
            this.BetterCrewLinkStatus.Location = new System.Drawing.Point(279, 131);
            this.BetterCrewLinkStatus.Margin = new System.Windows.Forms.Padding(4);
            this.BetterCrewLinkStatus.Name = "BetterCrewLinkStatus";
            this.BetterCrewLinkStatus.Size = new System.Drawing.Size(116, 23);
            this.BetterCrewLinkStatus.TabIndex = 12;
            // 
            // BootAmongUsMuteCapture
            // 
            this.BootAmongUsMuteCapture.AutoSize = true;
            this.BootAmongUsMuteCapture.Location = new System.Drawing.Point(436, 97);
            this.BootAmongUsMuteCapture.Name = "BootAmongUsMuteCapture";
            this.BootAmongUsMuteCapture.Size = new System.Drawing.Size(199, 19);
            this.BootAmongUsMuteCapture.TabIndex = 13;
            this.BootAmongUsMuteCapture.Text = "AmongUsMuteCaptureを起動する";
            this.BootAmongUsMuteCapture.UseVisualStyleBackColor = true;
            this.BootAmongUsMuteCapture.CheckedChanged += new System.EventHandler(this.BootAmongUsMuteCapture_CheckedChanged);
            // 
            // BootBetterCrewLink
            // 
            this.BootBetterCrewLink.AutoSize = true;
            this.BootBetterCrewLink.Location = new System.Drawing.Point(436, 133);
            this.BootBetterCrewLink.Name = "BootBetterCrewLink";
            this.BootBetterCrewLink.Size = new System.Drawing.Size(162, 19);
            this.BootBetterCrewLink.TabIndex = 14;
            this.BootBetterCrewLink.Text = "BetterCrew-Linkを起動する";
            this.BootBetterCrewLink.UseVisualStyleBackColor = true;
            this.BootBetterCrewLink.CheckedChanged += new System.EventHandler(this.BootBetterCrewLink_CheckedChanged);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(542, 404);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(38, 15);
            this.VersionLabel.TabIndex = 15;
            this.VersionLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Copyright (C) 2021 こう。";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.BootBetterCrewLink);
            this.Controls.Add(this.BootAmongUsMuteCapture);
            this.Controls.Add(this.BetterCrewLinkStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AmongUsMuteCaptureStatus);
            this.Controls.Add(this.AmongUsMuteCapture);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.exeType);
            this.Controls.Add(this.ShortcutType);
            this.Controls.Add(this.UpdateList);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.FolderSetting);
            this.Controls.Add(this.StartSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Among Us Mod管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ListViewcontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartSetting;
        private System.Windows.Forms.Button FolderSetting;
        private System.Windows.Forms.ListView ModList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button UpdateList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox ShortcutType;
        private System.Windows.Forms.TextBox exeType;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.TextBox AmongUsMuteCaptureStatus;
        private System.Windows.Forms.Button AmongUsMuteCapture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BetterCrewLinkStatus;
        private System.Windows.Forms.CheckBox BootAmongUsMuteCapture;
        private System.Windows.Forms.CheckBox BootBetterCrewLink;
        private System.Windows.Forms.ContextMenuStrip ListViewcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenExplorer;
        private System.Windows.Forms.ToolStripMenuItem DeleteMod;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label1;
    }
}

