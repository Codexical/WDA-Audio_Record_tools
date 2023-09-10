using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace RecordAudio
{
    public partial class Form3 : Form
    {

        public string s;
        bool status = false;
        bool isWndMove;
        int curr_x, curr_y;
        public int themeColor;


        public Form3()
        {
            InitializeComponent();
        }

        private void changeColor()
        {
            if (themeColor == 4)
            {
                button2.BackgroundImage = AudioRecord.Properties.Resources.record;
                button3.BackgroundImage = AudioRecord.Properties.Resources.stop;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                CLOSE_button.ForeColor = Color.Black;
                titleLabel.ForeColor = Color.Black;
                this.BackColor = Color.WhiteSmoke;
                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                CLOSE_button.BackColor = Color.FromArgb(224, 224, 224);
                titleLabel.BackColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                button2.BackgroundImage = null;
                button3.BackgroundImage = null;
                if (themeColor == 0)
                {
                    button1.ForeColor = Color.Black;
                    button2.ForeColor = Color.Black;
                    button3.ForeColor = Color.Black;
                    CLOSE_button.ForeColor = Color.Black;
                    titleLabel.ForeColor = Color.Black;
                    this.BackColor = Color.WhiteSmoke;
                    button1.BackColor = Color.WhiteSmoke;
                    button2.BackColor = Color.WhiteSmoke;
                    button3.BackColor = Color.WhiteSmoke;
                    CLOSE_button.BackColor = Color.FromArgb(224, 224, 224);
                    titleLabel.BackColor = Color.FromArgb(224, 224, 224);
                }
                else if (themeColor == 1)
                {
                    button1.ForeColor = Color.WhiteSmoke;
                    button2.ForeColor = Color.WhiteSmoke;
                    button3.ForeColor = Color.WhiteSmoke;
                    CLOSE_button.ForeColor = Color.WhiteSmoke;
                    titleLabel.ForeColor = Color.WhiteSmoke;
                    this.BackColor = Color.FromArgb(30, 30, 30);
                    button1.BackColor = Color.FromArgb(30, 30, 30);
                    button2.BackColor = Color.FromArgb(30, 30, 30);
                    button3.BackColor = Color.FromArgb(30, 30, 30);
                    CLOSE_button.BackColor = Color.FromArgb(64, 64, 64);
                    titleLabel.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (themeColor == 2)
                {
                    button1.ForeColor = Color.Black;
                    button2.ForeColor = Color.Black;
                    button3.ForeColor = Color.Black;
                    CLOSE_button.ForeColor = Color.Black;
                    titleLabel.ForeColor = Color.Black;
                    this.BackColor = Color.FromArgb(255, 255, 64);
                    button1.BackColor = Color.FromArgb(255, 255, 64);
                    button2.BackColor = Color.FromArgb(255, 255, 64);
                    button3.BackColor = Color.FromArgb(255, 255, 64);
                    CLOSE_button.BackColor = Color.FromArgb(255, 255, 128);
                    titleLabel.BackColor = Color.FromArgb(255, 255, 128);
                }
                else if (themeColor == 3)
                {
                    button1.ForeColor = Color.Yellow;
                    button2.ForeColor = Color.Yellow;
                    button3.ForeColor = Color.Yellow;
                    CLOSE_button.ForeColor = Color.Yellow;
                    titleLabel.ForeColor = Color.Yellow;
                    this.BackColor = Color.FromArgb(30, 30, 30);
                    button1.BackColor = Color.FromArgb(30, 30, 30);
                    button2.BackColor = Color.FromArgb(30, 30, 30);
                    button3.BackColor = Color.FromArgb(30, 30, 30);
                    CLOSE_button.BackColor = Color.FromArgb(64, 64, 64);
                    titleLabel.BackColor = Color.FromArgb(64, 64, 64);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(x, y);
            this.button1.Text = s;
            changeColor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = true;
            Form1 parentForm = (Form1)this.Owner;
            parentForm.status = 1;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status = true;
            Form1 parentForm = (Form1)this.Owner;
            parentForm.status = 0;
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!status)
            {
                Form1 parentForm = (Form1)this.Owner;
                parentForm.status = 0;
            }
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.curr_x = e.X;
                this.curr_y = e.Y;
                this.isWndMove = true;
            }

        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isWndMove)
                this.Location = new Point(this.Left + e.X - this.curr_x, this.Top + e.Y - this.curr_y);
        }

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            this.isWndMove = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                button1.ForeColor = Color.White;
                button1.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                button1.ForeColor = Color.Yellow;
                button1.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.Yellow;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.WhiteSmoke;
            }
            else if (themeColor == 1)
            {
                button1.ForeColor = Color.WhiteSmoke;
                button1.BackColor = Color.FromArgb(30, 30, 30);
            }
            else if (themeColor == 2)
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.FromArgb(255, 255, 64);
            }
            else if (themeColor == 3)
            {
                button1.ForeColor = Color.Yellow;
                button1.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                button2.ForeColor = Color.White;
                button2.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                button2.ForeColor = Color.Yellow;
                button2.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.Yellow;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.WhiteSmoke;
            }
            else if (themeColor == 1)
            {
                button2.ForeColor = Color.WhiteSmoke;
                button2.BackColor = Color.FromArgb(30, 30, 30);
            }
            else if (themeColor == 2)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.FromArgb(255, 255, 64);
            }
            else if (themeColor == 3)
            {
                button2.ForeColor = Color.Yellow;
                button2.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                button3.ForeColor = Color.White;
                button3.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                button3.ForeColor = Color.Yellow;
                button3.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.Yellow;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.WhiteSmoke;
            }
            else if (themeColor == 1)
            {
                button3.ForeColor = Color.WhiteSmoke;
                button3.BackColor = Color.FromArgb(30, 30, 30);
            }
            else if (themeColor == 2)
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.FromArgb(255, 255, 64);
            }
            else if (themeColor == 3)
            {
                button3.ForeColor = Color.Yellow;
                button3.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void CLOSE_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                CLOSE_button.ForeColor = Color.White;
                CLOSE_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                CLOSE_button.ForeColor = Color.Black;
                CLOSE_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                CLOSE_button.ForeColor = Color.Yellow;
                CLOSE_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                CLOSE_button.ForeColor = Color.Black;
                CLOSE_button.BackColor = Color.Yellow;
            }
        }

        private void CLOSE_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                CLOSE_button.ForeColor = Color.Black;
                CLOSE_button.BackColor = Color.FromArgb(224, 224, 224);
            }
            else if (themeColor == 1)
            {
                CLOSE_button.ForeColor = Color.White;
                CLOSE_button.BackColor = Color.FromArgb(64, 64, 64);
            }
            else if (themeColor == 2)
            {
                CLOSE_button.ForeColor = Color.Black;
                CLOSE_button.BackColor = Color.FromArgb(255, 255, 128);
            }
            else if (themeColor == 3)
            {
                CLOSE_button.ForeColor = Color.Yellow;
                CLOSE_button.BackColor = Color.FromArgb(64, 64, 64);
            }
        }


        private void CLOSE_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
