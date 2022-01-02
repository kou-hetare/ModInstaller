
namespace AmongUsModInstaller
{
    partial class AddToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSelectExe = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ツール名";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(65, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // buttonSelectExe
            // 
            this.buttonSelectExe.Location = new System.Drawing.Point(252, 10);
            this.buttonSelectExe.Name = "buttonSelectExe";
            this.buttonSelectExe.Size = new System.Drawing.Size(159, 23);
            this.buttonSelectExe.TabIndex = 2;
            this.buttonSelectExe.Text = "EXEの選択";
            this.buttonSelectExe.UseVisualStyleBackColor = true;
            this.buttonSelectExe.Click += new System.EventHandler(this.ButtonSelectExe_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(65, 42);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(680, 23);
            this.textBoxPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "パス";
            // 
            // buttonRegist
            // 
            this.buttonRegist.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRegist.Location = new System.Drawing.Point(670, 71);
            this.buttonRegist.Name = "buttonRegist";
            this.buttonRegist.Size = new System.Drawing.Size(75, 23);
            this.buttonRegist.TabIndex = 5;
            this.buttonRegist.Text = "登録";
            this.buttonRegist.UseVisualStyleBackColor = true;
            this.buttonRegist.Click += new System.EventHandler(this.ButtonRegist_Click);
            // 
            // AddToolForm
            // 
            this.AcceptButton = this.buttonRegist;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 98);
            this.Controls.Add(this.buttonRegist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonSelectExe);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddToolForm";
            this.Text = "外部ツールの登録";
            this.Load += new System.EventHandler(this.AddToolForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddToolForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddToolForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSelectExe;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegist;
    }
}