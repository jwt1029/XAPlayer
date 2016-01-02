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
            this.artistText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.musicList = new System.Windows.Forms.ComboBox();
            this.showmorelistBt = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.ImageList(this.components);
            this.musiclistView = new MP3_Player.HiddenListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImage)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(63, 104);
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
            this.groupBox2.Controls.Add(this.AlbumImage);
            this.groupBox2.Controls.Add(this.groupBox1);
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
            this.groupBox4.Location = new System.Drawing.Point(12, 162);
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
            this.musicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musicList.FormattingEnabled = true;
            this.musicList.Items.AddRange(new object[] {
            "최근 들은 음악"});
            this.musicList.Location = new System.Drawing.Point(277, 12);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(251, 20);
            this.musicList.TabIndex = 8;
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
            // musiclistView
            // 
            this.musiclistView.AllowDrop = true;
            this.musiclistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.musiclistView.FullRowSelect = true;
            this.musiclistView.Location = new System.Drawing.Point(277, 38);
            this.musiclistView.Name = "musiclistView";
            this.musiclistView.Size = new System.Drawing.Size(251, 103);
            this.musiclistView.TabIndex = 11;
            this.musiclistView.UseCompatibleStateImageBehavior = false;
            this.musiclistView.View = System.Windows.Forms.View.Details;
            this.musiclistView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.musiclistView_ColumnWidthChanging);
            this.musiclistView.DragDrop += new System.Windows.Forms.DragEventHandler(this.musiclistView_DragDrop);
            this.musiclistView.DragEnter += new System.Windows.Forms.DragEventHandler(this.musiclistView_DragEnter);
            this.musiclistView.MouseLeave += new System.EventHandler(this.musiclistView_MouseLeave);
            this.musiclistView.MouseHover += new System.EventHandler(this.musiclistView_MouseHover);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 271);
            this.Controls.Add(this.musiclistView);
            this.Controls.Add(this.showmorelistBt);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

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




    }
}

