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
using System.Runtime.InteropServices;

namespace RecordAudio
{
    public partial class Form2 : Form
    {
        //系統對於視窗縮小重新定義
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;// WS_MINIMIZEBOX
                cp.ClassStyle |= 0x8; //CS_DBLCLKS
                return cp;
            }
        }


        [DllImport("winmm.dll")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);


        public Form2()
        {
            InitializeComponent();
           
        }
        
        bool isWndMove;
        int curr_x, curr_y;
        bool isRec;
        //bool formstatus = false;
        public int themeColor;

        private void changeColor()
        {
                REC_button.BackgroundImage = null;
                button2.BackgroundImage = null;
                if (themeColor == 0)
                {
                    REC_button.ForeColor = Color.Black;
                    button2.ForeColor = Color.Black;
                    titleLabel.ForeColor = Color.Black;
                    this.BackColor = Color.WhiteSmoke;
                    REC_button.BackColor = Color.WhiteSmoke;
                    button2.BackColor = Color.WhiteSmoke;
                    titleLabel.BackColor = Color.FromArgb(224, 224, 224);
                }
                else if (themeColor == 1)
                {
                    REC_button.ForeColor = Color.WhiteSmoke;
                    button2.ForeColor = Color.WhiteSmoke;
                    titleLabel.ForeColor = Color.WhiteSmoke;
                    this.BackColor = Color.Black;
                    REC_button.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    titleLabel.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (themeColor == 2)
                {
                    REC_button.ForeColor = Color.Black;
                    button2.ForeColor = Color.Black;
                    titleLabel.ForeColor = Color.Black;
                    this.BackColor = Color.Yellow;
                    REC_button.BackColor = Color.Yellow;
                    button2.BackColor = Color.Yellow;
                    titleLabel.BackColor = Color.FromArgb(255, 255, 128);
                }
                else if (themeColor == 3)
                {
                    REC_button.ForeColor = Color.Yellow;
                    button2.ForeColor = Color.Yellow;
                    titleLabel.ForeColor = Color.Yellow;
                    this.BackColor = Color.Black;
                    REC_button.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    titleLabel.BackColor = Color.FromArgb(64, 64, 64);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Owner;
            parentForm.status = 2;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isRec = true;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width)/2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(x, y);
            changeColor();
            this.WindowState = FormWindowState.Normal;
            //formstatus = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void REC_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                REC_button.ForeColor = Color.White;
                REC_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                REC_button.ForeColor = Color.Black;
                REC_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                REC_button.ForeColor = Color.Yellow;
                REC_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                REC_button.ForeColor = Color.Black;
                REC_button.BackColor = Color.Yellow;
            }
        }

        private void REC_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                REC_button.ForeColor = Color.Black;
                REC_button.BackColor = Color.WhiteSmoke;
            }
            else if (themeColor == 1)
            {
                REC_button.ForeColor = Color.WhiteSmoke;
                REC_button.BackColor = Color.Black;
            }
            else if (themeColor == 2)
            {
                REC_button.ForeColor = Color.Black;
                REC_button.BackColor = Color.Yellow;
            }
            else if (themeColor == 3)
            {
                REC_button.ForeColor = Color.Yellow;
                REC_button.BackColor = Color.Black;
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
                button2.BackColor = Color.Black;
            }
            else if (themeColor == 2)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.Yellow;
            }
            else if (themeColor == 3)
            {
                button2.ForeColor = Color.Yellow;
                button2.BackColor = Color.Black;
            }
        }

        private void CLOSE_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
