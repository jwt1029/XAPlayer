using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Timer : Form
    {
        public int min = 0;
        public Timer()
        {
            InitializeComponent();
            hours.SelectedIndex = 0;
            minutes.SelectedIndex = 1;
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Done.Visible = false;
            hours.Visible = false;
            minutes.Visible = false;

            if (select.Text == "(직접 입력)")
            {
                Done.Enabled = true;
                for (int i = this.Size.Height; i <= 119; i++)
                {
                    this.Size = new Size(307, i);
                    System.Threading.Thread.Sleep(5);
                }
            }
            else
            {
                if (select.SelectedIndex == 0)
                    min = -1;
                #region Resize Form
                /*
                    Done.Enabled = false;
                    for (int i = this.Size.Height; i >= 73; i--)
                    {
                        this.Size = new Size(307, i);
                        System.Threading.Thread.Sleep(5);
                    }*/
                #endregion
                if (select.SelectedIndex == 1)
                    min = 5;
                if (select.SelectedIndex == 2)
                    min = 10;
                if (select.SelectedIndex == 3)
                    min = 15;
                if (select.SelectedIndex == 4)
                    min = 30;
                if (select.SelectedIndex == 5)
                    min = 60;
                if (select.SelectedIndex == 6)
                    min = 90;
                if (select.SelectedIndex == 7)
                    min = 120;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            Done.Visible = true;
            hours.Visible = true;
            minutes.Visible = true; 
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Timer_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Timer_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Timer_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Timer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            min = int.Parse(hours.Text) * 60 + int.Parse(minutes.Text);
            this.Close();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            select.Text = "(선택해주세요)";
        }

        private void select_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                for (int i = 100; i > 40; i--)
                {
                    this.Opacity = (double)i / (double)100;
                    System.Threading.Thread.Sleep(10);
                }
                this.Close();
            }
        }
    }
}
