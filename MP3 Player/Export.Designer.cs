namespace MP3_Player
{
    partial class Export
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.openBt = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 148);
            this.listBox1.TabIndex = 0;
            this.listBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Export_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "저장위치";
            // 
            // pathText
            // 
            this.pathText.Enabled = false;
            this.pathText.Location = new System.Drawing.Point(72, 204);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(279, 21);
            this.pathText.TabIndex = 2;
            this.pathText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Export_PreviewKeyDown);
            // 
            // openBt
            // 
            this.openBt.Location = new System.Drawing.Point(353, 203);
            this.openBt.Name = "openBt";
            this.openBt.Size = new System.Drawing.Size(25, 23);
            this.openBt.TabIndex = 4;
            this.openBt.Text = "...";
            this.openBt.UseVisualStyleBackColor = true;
            this.openBt.Click += new System.EventHandler(this.openBt_Click);
            this.openBt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Export_PreviewKeyDown);
            // 
            // saveBt
            // 
            this.saveBt.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.saveBt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveBt.Location = new System.Drawing.Point(395, 203);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(48, 23);
            this.saveBt.TabIndex = 6;
            this.saveBt.Text = "save";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            this.saveBt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Export_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "아래 파일들을 저장합니다";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 236);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(431, 23);
            this.progressBar.TabIndex = 8;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(458, 283);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.openBt);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Export";
            this.Text = "Export";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Export_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Export_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Export_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Export_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button openBt;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker worker;
    }
}