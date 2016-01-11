﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mlib;

namespace MP3_Player
{
    public partial class Form1 : Form
    {
        protected IrrKlang.ISoundEngine irrKlangEngine;
        protected IrrKlang.ISound currentlyPlayingSound;

        [DllImport("user32")]
        private static extern long ShowScrollBar(long hwnd, long wBar, long bShow);
        long SB_HORZ = 0;

        private bool pause = true;
        private List<Fmanage> fileList = new List<Fmanage>();   // Manage files
        private bool alive = true;      // check program is alive
        private int playingNum;         // number of music list
        private bool running = false;   // check music running
        private float volume = 1.0f;
        private List<MusicList> listFromFile;
        private int m;
        private int s;

        #region Form1()
        /// <summary>
        /// Form1 created & started
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ShowScrollBar(musiclistView.Handle.ToInt64(), SB_HORZ, 0);
            prevBt.Image = buttonList.Images[0];
            playBt.Image = buttonList.Images[2];
            stopBt.Image = buttonList.Images[6];
            nextBt.Image = buttonList.Images[8];
            listFromFile = MusicListFile.readFile("savedList.xnp");
            setList();
            musicList.SelectedIndex = 0;

            irrKlangEngine = new IrrKlang.ISoundEngine();
            //0 2 6 8
            //ListViewItem Item = new ListViewItem(new string[] { "1", "nameA", "00:00" });
            //musiclistView.Items.Add(Item);
        }

        private void setList()
        {
            foreach (MusicList list in listFromFile)
            {
                musicList.Items.Add(list.name);
            }
        }

        /*
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(AlbumImage.Image);
            Color color = b.GetPixel(e.X, e.Y);
            if (!(color.R == 0 && color.G == 0 && color.B == 0 && color.A == 0))
                MessageBox.Show("멍멍ㅇ멍멍멍ㅁㅓㅇ멍!!");
        }*/
        #endregion

        #region Change buttons' icon
        /// <summary>
        /// Change button icon when mouse hover or leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseHover(object sender, EventArgs e)
        {
            string name = ((PictureBox)sender).Name;
            if (name == "prevBt")
                prevBt.Image = buttonList.Images[1];
            if (name == "playBt")
            {
                if (currentlyPlayingSound == null)
                    playBt.Image = buttonList.Images[3];
                else
                {
                    if (currentlyPlayingSound.Paused)
                        playBt.Image = buttonList.Images[3];
                    else
                        playBt.Image = buttonList.Images[5];
                }
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
                if (currentlyPlayingSound == null)
                    playBt.Image = buttonList.Images[2];
                else
                {
                    if (currentlyPlayingSound.Paused)
                        playBt.Image = buttonList.Images[2];
                    else
                        playBt.Image = buttonList.Images[4];
                }
            }
            if (name == "stopBt")
                stopBt.Image = buttonList.Images[6];
            if (name == "nextBt")
                nextBt.Image = buttonList.Images[8];
        }
        #endregion

        private void playBt_Click(object sender, EventArgs e)
        {
            if (musiclistView.Items.Count == 0)
                return;
            pause = !pause;
            if (currentlyPlayingSound == null)
            {
                if (musiclistView.SelectedIndices.Count == 0)
                    playingNum = 0;
                else
                    playingNum = musiclistView.SelectedIndices[0];
                playMusic(fileList[playingNum].info.FullName);
                // 
                playBt.Image = buttonList.Images[5];
            }
            else
            {
                currentlyPlayingSound.Paused = !currentlyPlayingSound.Paused;

                // If pause clicked
                if (currentlyPlayingSound.Paused)
                {
                    playBt.Image = buttonList.Images[3];
                }
                // If play clicked
                else
                {
                    playBt.Image = buttonList.Images[5];
                }
            }
        }

        private void playMusic(string path)
        {
            if (currentlyPlayingSound != null)
            {
                running = false;
                currentlyPlayingSound.Stop();
                currentlyPlayingSound = null;
            }
            running = true;

            TagLib.File f = TagLib.File.Create(path);
             m = f.Properties.Duration.Minutes;
             s = f.Properties.Duration.Seconds;
            titleText.Text = f.Tag.Title;
            if (f.Tag.Pictures.Length != 0)
                AlbumImage.Image = ByteToImage(f.Tag.Pictures[0].Data.Data);
            else
                AlbumImage.Image = Properties.Resources.Disk;
            
            artistText.Text = f.Tag.FirstArtist;
            timeText.Text = m + ":" + s;

            currentlyPlayingSound = irrKlangEngine.Play2D(path);
            Thread thread = new Thread(new ThreadStart(progressBar));
            thread.Start();
            Thread checkEnd = new Thread(new ThreadStart(checkMusicEnd));
            checkEnd.Start();
            currentlyPlayingSound.Volume = volume;
        }

        private void progressBar()
        {
            uint totalLength = currentlyPlayingSound.PlayLength;
            int totalTime = m * 60 + s;
            while (alive && running)
            {
                try
                {
                    setLabelSize(RunningTime, new Size((int)((double)currentlyPlayingSound.PlayPosition / (double)totalLength * 187), 10));
                    int now = (int)((double)currentlyPlayingSound.PlayPosition / (double)totalLength * (m*60+s));
                    playingTime.Text = now/60 + ":" + now%60 + "/" + m + ":" + s;
                    //RunningTime.Size = new Size((int)((double)currentlyPlayingSound.PlayPosition / (double)totalLength * 187), 10);
                    Thread.Sleep(10);
                }
                catch
                {
                    break;
                }
            }
        }

        delegate void safeSetLabelSize(Label label, Size size);
        private void setLabelSize(Label label, Size size)
        {
            if (label.InvokeRequired)
                label.Invoke(new safeSetLabelSize(setLabelSize), label, size);
            else
                label.Size = size;
        }

        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));

            Bitmap bm = null;
            try
            {
                bm = new Bitmap(mStream, false);
            }
            catch (ArgumentException e)
            {
                return null;
            }
            mStream.Dispose();
            if (bm.Size.Width > 80 || bm.Size.Height > 80)
            {
                if (bm.Size.Width > bm.Size.Height)
                {
                    double per = (double)bm.Size.Width / (double)80;   //resize persent
                    Bitmap bmap = new Bitmap(bm, new Size(80, (int)((double)bm.Size.Height / per)));
                    return bmap;
                }
                else
                {
                    double per = (double)bm.Size.Height / (double)80;   //resize persent
                    Bitmap bmap = new Bitmap(bm, new Size((int)((double)bm.Size.Width / per), 80));
                    return bmap;
                }
            }
            return bm;
        }

        private void checkMusicEnd()
        {
            while (alive && running)
            {
                if (currentlyPlayingSound.Finished)
                {
                    playingNum++;
                    changeMusic();
                    break;
                }
            }
        }

        private void changeMusic()
        {
            running = false;
            if (playingNum == fileList.Count || playingNum == -1)
                playingNum = 0;
            playMusic(fileList[playingNum].info.FullName);
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
            if (currentlyPlayingSound!= null && !currentlyPlayingSound.Paused)
            {
                running = false;
                currentlyPlayingSound.Stop();
                currentlyPlayingSound = null;
                playBt.Image = buttonList.Images[2];
            }
        }

        private void prevBt_Click(object sender, EventArgs e)
        {
            playingNum--;
            changeMusic();
        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            playingNum++;
            changeMusic();
        }

        #region MusiclistView Setting
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
                TagLib.File f = TagLib.File.Create(str);
                int m = f.Properties.Duration.Minutes;
                int s = f.Properties.Duration.Seconds;

                fileList.Add(new Fmanage(new FileInfo(str), fileList.Count + 1, m, s));
                #region ShellFileDuration
                /*
                ShellFile so = ShellFile.FromFilePath(str);
                double nanoseconds;
                double.TryParse(so.Properties.System.Media.Duration.Value.ToString(), out nanoseconds);
                int secs = (int)(nanoseconds / 10000000);
                */
                #endregion

                int idx = fileList.Count - 1;
                ListViewItem Item = new ListViewItem(new string[] { fileList[idx].no.ToString(), fileList[idx].info.Name, m + ":" + s });
                musiclistView.Items.Add(Item);
                foreach(MusicList music in listFromFile)
                {
                    if(music.name == musicList.Text)
                        music.list.Add(str);
                }
            }
            List<string> datas = new List<string>();
            foreach (MusicList music in listFromFile)
            {
                datas.Add("<" + music.name + ">");
                foreach(string str in music.list)
                    datas.Add("\t" + str);
            }
            File.WriteAllText("savedList.xnp", String.Join("\r\n", datas.ToArray()), Encoding.UTF8);
        }

        private void musiclistView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.musiclistView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void musiclistView_MouseHover(object sender, EventArgs e)
        {
            musiclistView.Select();
        }

        private void musiclistView_MouseLeave(object sender, EventArgs e)
        {
            playBt.Select();
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(currentlyPlayingSound != null)
                currentlyPlayingSound.Paused = true;
            alive = false;
        }

        private void musiclistView_DoubleClick(object sender, EventArgs e)
        {
            stopBt_Click(new object(), new EventArgs());
            playBt_Click(new object() , new EventArgs());
        }

        bool run = false;
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Thread move = new Thread(new ThreadStart(moveButton));
            run = true;
            move.Start();
        }

        private void moveButton()
        {

            while (run)
            {
                int pos = MousePosition.X - this.Location.X - 20;
                if (pos != button2.Location.X && 155 <= pos && pos <= 239)
                {
                    button2.Location = new Point(pos, button2.Location.Y);
                    volume = (pos - 155) * 100 / 84 / 100.0f;
                    if (currentlyPlayingSound != null)
                    {
                        currentlyPlayingSound.Volume = volume;
                    }
                    //this.Opacity = (double)(pos - 224) / 100;
                }
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            run = false;
        }

        private void playingPositionChanged(object sender, MouseEventArgs e)
        {
            // 4 ~ 181
            int position = (e.X - 4) * 100 / 181;
            currentlyPlayingSound.PlayPosition = (uint)(currentlyPlayingSound.PlayLength * position / 100);
        }

        private void musicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            musiclistView.Items.Clear();
            fileList.Clear();
            int index = musicList.SelectedIndex;
            foreach (string str in listFromFile[index].list)
            {
                TagLib.File f = TagLib.File.Create(str);
                int m = f.Properties.Duration.Minutes;
                int s = f.Properties.Duration.Seconds;

                fileList.Add(new Fmanage(new FileInfo(str), fileList.Count + 1, m, s));
                int idx = fileList.Count - 1;
                ListViewItem Item = new ListViewItem(new string[] { fileList[idx].no.ToString(), fileList[idx].info.Name, m + ":" + s });
                musiclistView.Items.Add(Item);
            }
            if (fileList.Count != 0)
            {
                musiclistView.Items[0].Focused = true;
                musiclistView.Items[0].Selected = true;
            }
        }

        private void playBt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                playBt_Click(null, null);
        }

        private void musiclistView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                musiclistView_DoubleClick(null, null);
                playBt.Select();
            }
            if (e.KeyCode == Keys.Space)
                playBt_Click(null, null);
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            List<string> datas = new List<string>();
            foreach (MusicList music in listFromFile)
            {
                datas.Add("<" + music.name + ">");
                if (music.name == musicList.Text)
                {
                    music.list.RemoveAt(musiclistView.SelectedIndices[0]);
                    fileList.RemoveAt(musiclistView.SelectedIndices[0]);
                    musiclistView.Items.RemoveAt(musiclistView.SelectedIndices[0]);
                }
                foreach (string str in music.list)
                    datas.Add("\t" + str);
            }
            File.WriteAllText("savedList.xnp", String.Join("\r\n", datas.ToArray()), Encoding.UTF8);
        }
    }
}
