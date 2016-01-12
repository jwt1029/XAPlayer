namespace MP3_Player
{
    partial class Timer
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
            this.select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.ComboBox();
            this.minutes = new System.Windows.Forms.ComboBox();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select.ForeColor = System.Drawing.SystemColors.Info;
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "(설정 안함)",
            "5분 후 종료",
            "10분 후 종료",
            "15분 후 종료",
            "30분 후 종료",
            "1시간 후 종료",
            "1시간 30분 후 종료",
            "2시간 후 종료",
            "(직접 입력)"});
            this.select.Location = new System.Drawing.Point(26, 41);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(255, 20);
            this.select.TabIndex = 0;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            this.select.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.select_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura XBlk BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseUp);
            // 
            // hours
            // 
            this.hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hours.FormattingEnabled = true;
            this.hours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hours.Location = new System.Drawing.Point(92, 73);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(50, 20);
            this.hours.TabIndex = 2;
            // 
            // minutes
            // 
            this.minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutes.FormattingEnabled = true;
            this.minutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minutes.Location = new System.Drawing.Point(160, 73);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(50, 20);
            this.minutes.TabIndex = 2;
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Gulim", 8F);
            this.Done.Location = new System.Drawing.Point(-1, 101);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(308, 18);
            this.Done.TabIndex = 3;
            this.Done.Text = "set";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(307, 73);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Timer_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hours;
        private System.Windows.Forms.ComboBox minutes;
        private System.Windows.Forms.Button Done;
    }
}