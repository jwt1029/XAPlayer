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
    public partial class Form1 : Form
    {
        private bool pause = true;
        private List<FileInfo> fileList = new List<FileInfo>();

        public Form1()
        {
            InitializeComponent();
            musicList.Text = "최근 들은 음악";
            prevBt.Image = buttonList.Images[0];
            playBt.Image = buttonList.Images[2];
            stopBt.Image = buttonList.Images[6];
            nextBt.Image = buttonList.Images[8];
            //0 2 6 8
            //ListViewItem Item = new ListViewItem(new string[] { "1", "nameA", "00:00" });
            //musiclistView.Items.Add(Item);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(AlbumImage.Image);
            Color color = b.GetPixel(e.X, e.Y);
            if (!(color.R == 0 && color.G == 0 && color.B == 0 && color.A == 0))
                MessageBox.Show("멍멍ㅇ멍멍멍ㅁㅓㅇ멍!!");
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            string name = ((PictureBox)sender).Name;
            if (name == "prevBt")
                prevBt.Image = buttonList.Images[1];
            if (name == "playBt")
            {
                if (pause)
                    playBt.Image = buttonList.Images[3];
                else
                    playBt.Image = buttonList.Images[5];
            } 
            if (name == "stopBt")
                stopBt.Image = buttonList.Images[7];
            if (name == "nextBt")
                nextBt.Image = buttonList.Images[9];
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            string name = ((PictureBox)sender).Name;
            if (name == "prevBt")
                prevBt.Image = buttonList.Images[0];
            if (name == "playBt")
            {
                if (pause)
                    playBt.Image = buttonList.Images[2];
                else
                    playBt.Image = buttonList.Images[4];
            }
            if (name == "stopBt")
                stopBt.Image = buttonList.Images[6];
            if (name == "nextBt")
                nextBt.Image = buttonList.Images[8];
        }

        private void nextBt_Click(object sender, EventArgs e)
        {

        }

        private void playBt_Click(object sender, EventArgs e)
        {
            pause = !pause;
            if (pause)
                playBt.Image = buttonList.Images[3];
            else
                playBt.Image = buttonList.Images[5];
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                pause = true;
                playBt.Image = buttonList.Images[2];
            }
        }

        private void prevBt_Click(object sender, EventArgs e)
        {

        }

        private void musiclistView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void musiclistView_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string str in files)
            {
                fileList.Add(new FileInfo(str));
                ListViewItem Item = new ListViewItem(new string[] { "" + fileList.Count, fileList[fileList.Count - 1].Name, "00:00" });
                musiclistView.Items.Add(Item);
            }
        }
    }
}
