namespace MP3_Player
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextBt = new System.Windows.Forms.PictureBox();
            this.stopBt = new System.Windows.Forms.PictureBox();
            this.playBt = new System.Windows.Forms.PictureBox();
            this.prevBt = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AlbumImage = new System.Windows.Forms.PictureBox();
            this.timerBt = new System.Windows.Forms.Button();
            this.randomBt = new System.Windows.Forms.Button();
            this.artistText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.musicList = new System.Windows.Forms.ComboBox();
            this.showmorelistBt = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RunningTime = new System.Windows.Forms.PictureBox();
            this.playingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timeShowLb = new System.Windows.Forms.Label();
            this.musiclistView = new MP3_Player.HiddenListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exportBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningTime)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Location = new System.Drawing.Point(100, 22);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(24, 12);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "title";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Location = new System.Drawing.Point(100, 59);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(29, 12);
            this.timeText.TabIndex = 1;
            this.timeText.Text = "time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextBt);
            this.groupBox1.Controls.Add(this.stopBt);
            this.groupBox1.Controls.Add(this.playBt);
            this.groupBox1.Controls.Add(this.prevBt);
            this.groupBox1.Location = new System.Drawing.Point(74, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // nextBt
            // 
            this.nextBt.Location = new System.Drawing.Point(82, 13);
            this.nextBt.Name = "nextBt";
            this.nextBt.Size = new System.Drawing.Size(20, 20);
            this.nextBt.TabIndex = 2;
            this.nextBt.TabStop = false;
            this.nextBt.Click += new System.EventHandler(this.nextBt_Click);
            this.nextBt.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.nextBt.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // stopBt
            // 
            this.stopBt.Location = new System.Drawing.Point(58, 13);
            this.stopBt.Name = "stopBt";
            this.stopBt.Size = new System.Drawing.Size(20, 20);
            this.stopBt.TabIndex = 2;
            this.stopBt.TabStop = false;
            this.stopBt.Click += new System.EventHandler(this.stopBt_Click);
            this.stopBt.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.stopBt.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // playBt
            // 
            this.playBt.Location = new System.Drawing.Point(32, 13);
            this.playBt.Name = "playBt";
            this.playBt.Size = new System.Drawing.Size(20, 20);
            this.playBt.TabIndex = 2;
            this.playBt.TabStop = false;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            this.playBt.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.playBt.MouseHover += new System.EventHandler(this.Button_MouseHover);
            this.playBt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playBt_PreviewKeyDown);
            // 
            // prevBt
            // 
            this.prevBt.Location = new System.Drawing.Point(6, 13);
            this.prevBt.Name = "prevBt";
            this.prevBt.Size = new System.Drawing.Size(20, 20);
            this.prevBt.TabIndex = 2;
            this.prevBt.TabStop = false;
            this.prevBt.Click += new System.EventHandler(this.prevBt_Click);
            this.prevBt.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.prevBt.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.AlbumImage);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.timerBt);
            this.groupBox2.Controls.Add(this.randomBt);
            this.groupBox2.Controls.Add(this.titleText);
            this.groupBox2.Controls.Add(this.artistText);
            this.groupBox2.Controls.Add(this.timeText);
            this.groupBox2.Location = new System.Drawing.Point(9, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // AlbumImage
            // 
            this.AlbumImage.Image = global::MP3_Player.Properties.Resources.Disk;
            this.AlbumImage.Location = new System.Drawing.Point(6, 20);
            this.AlbumImage.Name = "AlbumImage";
            this.AlbumImage.Size = new System.Drawing.Size(80, 80);
            this.AlbumImage.TabIndex = 0;
            this.AlbumImage.TabStop = false;
            // 
            // timerBt
            // 
            this.timerBt.Font = new System.Drawing.Font("Gulim", 8F);
            this.timerBt.Image = global::MP3_Player.Properties.Resources.timer;
            this.timerBt.Location = new System.Drawing.Point(201, 118);
            this.timerBt.Name = "timerBt";
            this.timerBt.Size = new System.Drawing.Size(31, 20);
            this.timerBt.TabIndex = 10;
            this.timerBt.UseVisualStyleBackColor = true;
            this.timerBt.Click += new System.EventHandler(this.timerBt_Click);
            // 
            // randomBt
            // 
            this.randomBt.Font = new System.Drawing.Font("Gulim", 8F);
            this.randomBt.Location = new System.Drawing.Point(231, 118);
            this.randomBt.Name = "randomBt";
            this.randomBt.Size = new System.Drawing.Size(31, 20);
            this.randomBt.TabIndex = 10;
            this.randomBt.UseVisualStyleBackColor = true;
            this.randomBt.Click += new System.EventHandler(this.randomBt_Click);
            // 
            // artistText
            // 
            this.artistText.AutoSize = true;
            this.artistText.Location = new System.Drawing.Point(99, 41);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(32, 12);
            this.artistText.TabIndex = 1;
            this.artistText.Text = "artist";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "가사 입니다\r\n입니다 가사\r\n다니입 사가";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 101);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "가사";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("NanumGothic", 7.5F);
            this.button1.Location = new System.Drawing.Point(462, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "가사 찾기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // musicList
            // 
            this.musicList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.musicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musicList.FormattingEnabled = true;
            this.musicList.Location = new System.Drawing.Point(277, 12);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(251, 20);
            this.musicList.TabIndex = 8;
            this.musicList.SelectedIndexChanged += new System.EventHandler(this.musicList_SelectedIndexChanged);
            // 
            // showmorelistBt
            // 
            this.showmorelistBt.Font = new System.Drawing.Font("Gulim", 8F);
            this.showmorelistBt.Location = new System.Drawing.Point(498, 138);
            this.showmorelistBt.Name = "showmorelistBt";
            this.showmorelistBt.Size = new System.Drawing.Size(31, 17);
            this.showmorelistBt.TabIndex = 10;
            this.showmorelistBt.Text = "▼";
            this.showmorelistBt.UseVisualStyleBackColor = true;
            // 
            // buttonList
            // 
            this.buttonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonList.ImageStream")));
            this.buttonList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonList.Images.SetKeyName(0, "prevOff.png");
            this.buttonList.Images.SetKeyName(1, "prevOn.png");
            this.buttonList.Images.SetKeyName(2, "playOff.png");
            this.buttonList.Images.SetKeyName(3, "playOn.png");
            this.buttonList.Images.SetKeyName(4, "pauseOff.png");
            this.buttonList.Images.SetKeyName(5, "pauseOn.png");
            this.buttonList.Images.SetKeyName(6, "stopOff.png");
            this.buttonList.Images.SetKeyName(7, "stopOn.png");
            this.buttonList.Images.SetKeyName(8, "nextOff.png");
            this.buttonList.Images.SetKeyName(9, "nextOn.png");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(158, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 11);
            this.label1.TabIndex = 4;
            this.label1.Text = "───────";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RunningTime);
            this.groupBox3.Controls.Add(this.playingTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(9, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 43);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // RunningTime
            // 
            this.RunningTime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RunningTime.Location = new System.Drawing.Point(4, 21);
            this.RunningTime.Margin = new System.Windows.Forms.Padding(0);
            this.RunningTime.Name = "RunningTime";
            this.RunningTime.Size = new System.Drawing.Size(182, 1);
            this.RunningTime.TabIndex = 14;
            this.RunningTime.TabStop = false;
            // 
            // playingTime
            // 
            this.playingTime.AutoSize = true;
            this.playingTime.Location = new System.Drawing.Point(191, 16);
            this.playingTime.Name = "playingTime";
            this.playingTime.Size = new System.Drawing.Size(67, 12);
            this.playingTime.TabIndex = 8;
            this.playingTime.Text = "00:00/00:00";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 10);
            this.label3.TabIndex = 6;
            this.label3.Text = "─────────────────────";
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playingPositionChanged);
            // 
            // removeBt
            // 
            this.removeBt.Font = new System.Drawing.Font("Gulim", 8F);
            this.removeBt.Location = new System.Drawing.Point(469, 138);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(31, 17);
            this.removeBt.TabIndex = 10;
            this.removeBt.Text = "-";
            this.removeBt.UseVisualStyleBackColor = true;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // addBt
            // 
            this.addBt.Font = new System.Drawing.Font("Gulim", 8F);
            this.addBt.Location = new System.Drawing.Point(440, 138);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(31, 17);
            this.addBt.TabIndex = 10;
            this.addBt.Text = "+";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timeShowLb
            // 
            this.timeShowLb.AutoSize = true;
            this.timeShowLb.Location = new System.Drawing.Point(277, 174);
            this.timeShowLb.Name = "timeShowLb";
            this.timeShowLb.Size = new System.Drawing.Size(0, 12);
            this.timeShowLb.TabIndex = 13;
            // 
            // musiclistView
            // 
            this.musiclistView.AllowDrop = true;
            this.musiclistView.BackColor = System.Drawing.SystemColors.Window;
            this.musiclistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.musiclistView.FullRowSelect = true;
            this.musiclistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.musiclistView.Location = new System.Drawing.Point(277, 38);
            this.musiclistView.Name = "musiclistView";
            this.musiclistView.Size = new System.Drawing.Size(251, 103);
            this.musiclistView.TabIndex = 11;
            this.musiclistView.UseCompatibleStateImageBehavior = false;
            this.musiclistView.View = System.Windows.Forms.View.Details;
            this.musiclistView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.musiclistView_ColumnWidthChanging);
            this.musiclistView.DragDrop += new System.Windows.Forms.DragEventHandler(this.musiclistView_DragDrop);
            this.musiclistView.DragEnter += new System.Windows.Forms.DragEventHandler(this.musiclistView_DragEnter);
            this.musiclistView.DoubleClick += new System.EventHandler(this.musiclistView_DoubleClick);
            this.musiclistView.MouseLeave += new System.EventHandler(this.musiclistView_MouseLeave);
            this.musiclistView.MouseHover += new System.EventHandler(this.musiclistView_MouseHover);
            this.musiclistView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.musiclistView_PreviewKeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "no";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "title";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "time";
            this.columnHeader3.Width = 49;
            // 
            // exportBt
            // 
            this.exportBt.Font = new System.Drawing.Font("Gulim", 8F);
            this.exportBt.Location = new System.Drawing.Point(411, 138);
            this.exportBt.Name = "exportBt";
            this.exportBt.Size = new System.Drawing.Size(31, 17);
            this.exportBt.TabIndex = 10;
            this.exportBt.UseVisualStyleBackColor = true;
            this.exportBt.Click += new System.EventHandler(this.exportBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(540, 296);
            this.Controls.Add(this.timeShowLb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.musiclistView);
            this.Controls.Add(this.exportBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.removeBt);
            this.Controls.Add(this.showmorelistBt);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AlbumImage;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.PictureBox prevBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox nextBt;
        private System.Windows.Forms.PictureBox stopBt;
        private System.Windows.Forms.PictureBox playBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label artistText;
        private System.Windows.Forms.ComboBox musicList;
        private System.Windows.Forms.Button showmorelistBt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList buttonList;
        private HiddenListView musiclistView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label playingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button randomBt;
        private System.Windows.Forms.Button timerBt;
        private System.Windows.Forms.PictureBox RunningTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label timeShowLb;
        private System.Windows.Forms.Button exportBt;




    }
}

