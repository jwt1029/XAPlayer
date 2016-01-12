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

namespace MP3_Player
{
    public partial class Export : Form
    {
        private string path;
        private List<string> lists = new List<string>();
        public Export(List<Fmanage> list)
        {
            InitializeComponent();
            foreach (Fmanage f in list)
            {
                lists.Add(f.info.FullName);
                listBox1.Items.Add(f.info.Name);
            }
        }

        private void openBt_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderDialog.SelectedPath;
                pathText.Text = path;
                saveBt.ForeColor = SystemColors.ControlText;

                saveBt.Enabled = true;
            }
        }
        private void saveBt_Click(object sender, EventArgs e)
        {
            if (pathText.Text == "")
                MessageBox.Show("경로를 설정해주세요!");
            else
            {
                for (int i = 241; i <= 273; i++)
                {
                    this.Size = new Size(458, i);
                    System.Threading.Thread.Sleep(10);
                }
                worker.RunWorkerAsync();
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i =0;i<lists.Count;i++)
            {
                FileStream DISKIO = new FileStream(path + "\\" + listBox1.Items[i], FileMode.OpenOrCreate, FileAccess.Write);
                lists[i] += " . . . ";
                worker.ReportProgress(0);
                long cnt = 0;
                int pct = 0;
                long length = new FileInfo(lists[i]).Length;
                FileStream dataStream = new FileStream(lists[i], FileMode.Open, FileAccess.Read);
                byte[] buff = new byte[102400];
                int c = 0;
                while ((c = dataStream.Read(buff, 0, 10400)) > 0)
                {
                    DISKIO.Write(buff, 0, c);
                    DISKIO.Flush();
                    cnt += c;
                    pct = (int)((cnt * 100) / length);
                    if (pct == -1)
                        return;
                    worker.ReportProgress(pct);
                }
                dataStream.Close();

                lists[i] += " Complete!";
                listBox1.Items[i] = new string[] {lists[i]}[0];
                DISKIO.Close();
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(path);
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Export_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Export_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Export_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}
