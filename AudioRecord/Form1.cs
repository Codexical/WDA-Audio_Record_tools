using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using RecordAudio;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form                      
    {
        //變數
        bool isRecording = false;
        bool isPlaying = false;
        public int status;
        bool isWndMove;
        int curr_x, curr_y;
        public int themeColor = 0;

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

        //設定錄音和撥放音檔的指令
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        //設定音量的指令
        /*[DllImport("user32.dll")]
        //public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        //private Process p = Process.GetCurrentProcess();
        //private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        //private const int APPCOMMAND_VOLUME_UP = 0x0a0000;
        //private const int APPCOMMAND_VOLUME_DOWN = 0x090000;
        //private const int WM_APPCOMMAND = 0x319;
        */


        //宣告錄音程序
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //主題變色
        private void changeColor()
        {
                REC_button.BackgroundImage = null;
                PLAY_button.BackgroundImage = null;
                STOP_button.BackgroundImage = null;
                DEL_button.BackgroundImage = null;
                col_button.BackgroundImage = null;
                pictureBox1.BackgroundImage = null;
                this.BackgroundImage = null;
                pictureBox1.BackColor = Color.Transparent;
                listBox1.BorderStyle = BorderStyle.FixedSingle;
                 if (themeColor == 0)
                {
                    REC_button.ForeColor = Color.Black;
                    PLAY_button.ForeColor = Color.Black;
                    STOP_button.ForeColor = Color.Black;
                    DEL_button.ForeColor = Color.Black;
                    col_button.ForeColor = Color.Black;
                    listBox1.ForeColor = Color.Black;
                    statusLabel.ForeColor = Color.Black;
                    titleLabel.ForeColor = Color.Black;
                    HIDE_button.ForeColor = Color.Black;
                    CLOSE_button.ForeColor = Color.Black;
                    REC_button.BackColor = Color.White;
                    PLAY_button.BackColor = Color.White;
                    STOP_button.BackColor = Color.White;
                    DEL_button.BackColor = Color.White;
                    col_button.BackColor = Color.White;
                    listBox1.BackColor = Color.White;
                    statusLabel.BackColor = Color.White;
                    this.BackColor = Color.White;
                    titleLabel.BackColor = Color.FromArgb(224, 224, 224);
                    HIDE_button.BackColor = Color.FromArgb(224, 224, 224);
                    CLOSE_button.BackColor = Color.FromArgb(224, 224, 224);
                }
                else if (themeColor == 1)
                {
                    REC_button.ForeColor = Color.White;
                    PLAY_button.ForeColor = Color.White;
                    STOP_button.ForeColor = Color.White;
                    DEL_button.ForeColor = Color.White;
                    col_button.ForeColor = Color.White;
                    listBox1.ForeColor = Color.White;
                    statusLabel.ForeColor = Color.White;
                    titleLabel.ForeColor = Color.White;
                    HIDE_button.ForeColor = Color.White;
                    CLOSE_button.ForeColor = Color.White;
                    REC_button.BackColor = Color.Black;
                    PLAY_button.BackColor = Color.Black;
                    STOP_button.BackColor = Color.Black;
                    DEL_button.BackColor = Color.Black;
                    col_button.BackColor = Color.Black;
                    listBox1.BackColor = Color.Black;
                    statusLabel.BackColor = Color.Black;
                    this.BackColor = Color.Black;
                    titleLabel.BackColor = Color.FromArgb(64, 64, 64);
                    HIDE_button.BackColor = Color.FromArgb(64, 64, 64);
                    CLOSE_button.BackColor = Color.FromArgb(64, 64, 64);

                }
                else if (themeColor == 2)
                {
                    REC_button.ForeColor = Color.Black;
                    PLAY_button.ForeColor = Color.Black;
                    STOP_button.ForeColor = Color.Black;
                    DEL_button.ForeColor = Color.Black;
                    col_button.ForeColor = Color.Black;
                    listBox1.ForeColor = Color.Black;
                    statusLabel.ForeColor = Color.Black;
                    titleLabel.ForeColor = Color.Black;
                    HIDE_button.ForeColor = Color.Black;
                    CLOSE_button.ForeColor = Color.Black;
                    REC_button.BackColor = Color.Yellow;
                    PLAY_button.BackColor = Color.Yellow;
                    STOP_button.BackColor = Color.Yellow;
                    DEL_button.BackColor = Color.Yellow;
                    col_button.BackColor = Color.Yellow;
                    listBox1.BackColor = Color.Yellow;
                    statusLabel.BackColor = Color.Yellow;
                    this.BackColor = Color.Yellow;
                    titleLabel.BackColor = Color.FromArgb(255, 255, 128);
                    HIDE_button.BackColor = Color.FromArgb(255, 255, 128);
                    CLOSE_button.BackColor = Color.FromArgb(255, 255, 128);
                }
                else if (themeColor == 3)
                {
                    REC_button.ForeColor = Color.Yellow;
                    PLAY_button.ForeColor = Color.Yellow;
                    STOP_button.ForeColor = Color.Yellow;
                    DEL_button.ForeColor = Color.Yellow;
                    col_button.ForeColor = Color.Yellow;
                    listBox1.ForeColor = Color.Yellow;
                    statusLabel.ForeColor = Color.Yellow;
                    titleLabel.ForeColor = Color.Yellow;
                    HIDE_button.ForeColor = Color.Yellow;
                    CLOSE_button.ForeColor = Color.Yellow;
                    REC_button.BackColor = Color.Black;
                    PLAY_button.BackColor = Color.Black;
                    STOP_button.BackColor = Color.Black;
                    DEL_button.BackColor = Color.Black;
                    col_button.BackColor = Color.Black;
                    listBox1.BackColor = Color.Black;
                    statusLabel.BackColor = Color.Black;
                    this.BackColor = Color.Black;
                    titleLabel.BackColor = Color.FromArgb(64, 64, 64);
                    HIDE_button.BackColor = Color.FromArgb(64, 64, 64);
                    CLOSE_button.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        //視窗初始化
        public Form1()
        {
            InitializeComponent();           
        }
        
        //軟體開啟時
        private void Form1_Load(object sender, EventArgs e)
        {
            Form4 childForm = new Form4();
            childForm.Owner = this;
            childForm.ShowDialog();
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(x, y);
            try
            {
                if (!Directory.Exists(@".\RecordFile"))//資料夾不存在要建立新的資料夾
                    Directory.CreateDirectory(@".\RecordFile");
                if (!File.Exists(@".\RecordFile\.DateData.txt"))//DateData.txt存放音檔日期，如果不存在要建立新的檔案，內容寫下end
                    using (StreamWriter sw = File.CreateText(@".\RecordFile\.DateData.txt"))
                    {
                        sw.WriteLine("end");
                        sw.WriteLine("0");
                    }
                StreamReader str = new StreamReader(@".\RecordFile\.DateData.txt");//讀取DateData.txt
                string ReadLine = str.ReadLine();
                this.listBox1.Items.Clear();//存放到軟體的listbox
                while (ReadLine != "end")//讀到end之後再跳出
                {
                    this.listBox1.Items.Add(ReadLine);
                    ReadLine = str.ReadLine();
                }
                ReadLine = str.ReadLine();
                themeColor = int.Parse(ReadLine);
                str.Close();
            }
            catch(Exception a)
            {
                this.Close();
            }
            this.statusLabel.Text = "狀態：";
            this.WindowState = FormWindowState.Normal;
            changeColor();
        }

        //軟體關閉時
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter str = new StreamWriter(@".\RecordFile\.DateData.txt");
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                    str.WriteLine(this.listBox1.Items[i].ToString());
                str.WriteLine("end");
                str.WriteLine(themeColor);
                str.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("程式已開啟");
            }
        }

        //按鈕觸發
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                REC_button.PerformClick();
            }
            else if (e.KeyCode == Keys.W)
            {
                PLAY_button.PerformClick();
            }
            else if (e.KeyCode == Keys.E)
            {
                STOP_button.PerformClick();
            }
            else if (e.KeyCode == Keys.R)
            {
                DEL_button.PerformClick();
            }
            else if (e.KeyCode == Keys.I && e.Control && e.Shift)
            {
                INFO_button.Visible = true;
                INFO_button.PerformClick();
                INFO_button.Visible = false;
            }
            else if (e.KeyCode == Keys.Right)
            {

            }
        }

        //開始錄音鈕按下
        private void REC_button_Click(object sender, EventArgs e)
        {
            if (!isRecording)//如果沒在錄音則執行，避免重複錄音
            {
                //確保系統音量變成靜音
                //SendMessageW(p.Handle, WM_APPCOMMAND, p.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);//系統聲音提高
                //SendMessageW(p.Handle, WM_APPCOMMAND, p.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);//系統聲音降低
                //SendMessageW(p.Handle, WM_APPCOMMAND, p.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);//系統聲音靜音

                //設定錄音格式
                mciSendString("set wave bitpersample 8", "", 0, 0);  //設為8位
                mciSendString("set wave samplespersec 44100", "", 0, 0);//設定頻率
                mciSendString("set wave channels 2", "", 0, 0);  //設為立體聲
                mciSendString("set wave format tag pcm", "", 0, 0);//設定PCM（脈衝編碼調製）
                mciSendString("open new type WAVEaudio alias movie", "", 0, 0); //開啟一個新的錄音檔案

                //開始錄音
                mciSendString("record movie", "", 0, 0);
                isRecording = true;
                this.statusLabel.Text = "狀態：錄音中";
                //跳到正在錄音的視窗
                Form2 childForm = new Form2();
                childForm.themeColor = themeColor;
                this.Hide();
                childForm.Owner = this;
                childForm.ShowDialog();
                //DialogResult Result = MessageBox.Show("錄音中...", "", MessageBoxButtons.OK);
                //DialogResult = MessageBoxEX.Show("狀態：錄音", "", MessageBoxButtons.YesNo, new string[] { "錄音中", "停止錄音" });

                if (isRecording)//如果已經正在錄音就不重複執行
                {
                    //設定檔案名稱
                    string nowDate = DateTime.Now.ToShortDateString(), nowTime = DateTime.Now.ToLongTimeString();
                    string[] nowDateData, nowTimeData;
                    if (nowDate[4] == '/')
                        nowDateData = nowDate.Split('/');
                    else
                        nowDateData = nowDate.Split('-');
                    if (nowTime[0] == '上')
                    {
                        string[] palse = nowTime.Split(' ');
                        nowTimeData = palse[1].Split(':');
                        //if (int.Parse(nowTimeData[0]) < 10) nowTimeData[0] = '0' + nowTimeData[0];
                    }
                    else if (nowTime[0] == '下')
                    {
                        string[] palse = nowTime.Split(' ');
                        nowTimeData = palse[1].Split(':');
                        nowTimeData[0] = (int.Parse(nowTimeData[0]) + 12).ToString();
                    }
                    else
                        nowTimeData = nowTime.Split(':');
                    if (nowTimeData[0].Length < 2)
                        nowTimeData[0] = '0' + nowTimeData[0];
                    string now = nowDateData[0] + "/" + nowDateData[1] + "/" + nowDateData[2] + " " +
                    nowTimeData[0] + ":" + nowTimeData[1];
                    if (this.listBox1.FindString(now) == -1)
                        this.listBox1.Items.Add(now);
                    now = nowDateData[0] + "年" + nowDateData[1] + "月" + nowDateData[2] + "日" +
                        nowTimeData[0] + "時" + nowTimeData[1] + "分";

                    //停止錄音和存檔
                    mciSendString("stop movie", "", 0, 0);
                    mciSendString("save movie " + @".\RecordFile\" + now + ".wav", "", 0, 0);
                    mciSendString("close movie", "", 0, 0);

                    isRecording = false;
                    this.statusLabel.Text = "狀態：結束錄音";
                    //SendMessageW(p.Handle, WM_APPCOMMAND, p.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
                    //SendMessageW(p.Handle, WM_APPCOMMAND, p.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
                    this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                }
                this.Show();
            }
        }

        //開始播放紐按下
        private void PLAY_button_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)//確保有選擇檔案
            {
                string[] timedata = this.listBox1.Items[this.listBox1.SelectedIndex].ToString().Split(' ');
                string[] nowDateData = timedata[0].Split('/');
                string[] nowTimeData = timedata[1].Split(':');
                string now = nowDateData[0] + "年" + nowDateData[1] + "月" + nowDateData[2] + "日" +
                nowTimeData[0] + "時" + nowTimeData[1] + "分";
                player.SoundLocation = @".\RecordFile\" + now + ".wav";
                player.Load();
                player.Play();
                this.statusLabel.Text = "狀態：播放 " + now;
                isPlaying = true;
            }
        }

        //停止播放紐按下
        private void STOP_button_Click(object sender, EventArgs e)
        {
            if (isPlaying)//確保有正在撥放
            {
                player.Stop();
                this.statusLabel.Text = "狀態：停止播放";
            }
        }

        //刪除紐按下
        private void DEL_button_Click(object sender, EventArgs e)
        {
            //確認是否有正確選取
            if (this.listBox1.SelectedIndex >= 0)
            {
                Form3 childForm2 = new Form3();
                childForm2.Owner = this;
                childForm2.s = "是否刪除：" + this.listBox1.Items[this.listBox1.SelectedIndex];
                childForm2.themeColor = themeColor;
                childForm2.ShowDialog();

                //DialogResult Result = MessageBoxEX.Show("狀態：錄音", "", MessageBoxButtons.YesNo, new string[] { "錄音中", "停止錄音" });
                //DialogResult Result = MessageBox.Show("是否刪除：" + this.listBox1.Items[this.listBox1.SelectedIndex], "刪除檔案", MessageBoxButtons.OKCancel);

                //if (Result == DialogResult.OK)
                if (status == 1)
                {
                    //尋找要刪除的檔案
                    string[] timedata = this.listBox1.Items[this.listBox1.SelectedIndex].ToString().Split(' ');
                    string[] nowDateData = timedata[0].Split('/');
                    string[] nowTimeData = timedata[1].Split(':');
                    string now = nowDateData[0] + "年" + nowDateData[1] + "月" + nowDateData[2] + "日" +
                    nowTimeData[0] + "時" + nowTimeData[1] + "分";
                    //刪除檔案
                    if (File.Exists(@".\RecordFile\" + now + ".wav"))
                        File.Delete(@".\RecordFile\" + now + ".wav");
                    if (this.listBox1.Items.Count == 1)
                        this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                    else if (this.listBox1.SelectedIndex != this.listBox1.Items.Count - 1)
                    {
                        int select = this.listBox1.SelectedIndex;
                        this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                        this.listBox1.SetSelected(select, true);
                    }
                    else if (this.listBox1.SelectedIndex == this.listBox1.Items.Count - 1)
                    {
                        this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                        this.listBox1.SetSelected(this.listBox1.Items.Count - 1, true);
                    }
                    this.statusLabel.Text = "狀態：刪除成功";
                }
            }
        }

        //資訊紐按下
        private void INFO_button_Click(object sender, EventArgs e)
        {
            Form5 childForm = new Form5();
            childForm.Owner = this;
            childForm.ShowDialog();
        }

        //關閉紐按下
        private void CLOSE_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //標題列按下
        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.curr_x = e.X;
                this.curr_y = e.Y;
                this.isWndMove = true;
            }

        }

        //標題列移動
        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isWndMove)
                this.Location = new Point(this.Left + e.X - this.curr_x, this.Top + e.Y - this.curr_y);
        }

        //標題列放開
        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            this.isWndMove = false;
        }

        //縮小按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //主題按鈕
        private void col_button_Click(object sender, EventArgs e)
        {
            Form6 childForm = new Form6();
            childForm.Owner = this;
            childForm.ShowDialog();
            themeColor = childForm.themeCol;
            changeColor();
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
                REC_button.BackColor = Color.White;
            }
            else if (themeColor == 1)
            {
                REC_button.ForeColor = Color.White;
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

        private void PLAY_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                PLAY_button.ForeColor = Color.White;
                PLAY_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                PLAY_button.ForeColor = Color.Black;
                PLAY_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                PLAY_button.ForeColor = Color.Yellow;
                PLAY_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                PLAY_button.ForeColor = Color.Black;
                PLAY_button.BackColor = Color.Yellow;
            }
        }

        private void PLAY_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                PLAY_button.ForeColor = Color.Black;
                PLAY_button.BackColor = Color.White;
            }
            else if (themeColor == 1)
            {
                PLAY_button.ForeColor = Color.White;
                PLAY_button.BackColor = Color.Black;
            }
            else if (themeColor == 2)
            {
                PLAY_button.ForeColor = Color.Black;
                PLAY_button.BackColor = Color.Yellow;
            }
            else if (themeColor == 3)
            {
                PLAY_button.ForeColor = Color.Yellow;
                PLAY_button.BackColor = Color.Black;
            }
        }

        private void STOP_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                STOP_button.ForeColor = Color.White;
                STOP_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                STOP_button.ForeColor = Color.Black;
                STOP_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                STOP_button.ForeColor = Color.Yellow;
                STOP_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                STOP_button.ForeColor = Color.Black;
                STOP_button.BackColor = Color.Yellow;
            }
        }

        private void STOP_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                STOP_button.ForeColor = Color.Black;
                STOP_button.BackColor = Color.White;
            }
            else if (themeColor == 1)
            {
                STOP_button.ForeColor = Color.White;
                STOP_button.BackColor = Color.Black;
            }
            else if (themeColor == 2)
            {
                STOP_button.ForeColor = Color.Black;
                STOP_button.BackColor = Color.Yellow;
            }
            else if (themeColor == 3)
            {
                STOP_button.ForeColor = Color.Yellow;
                STOP_button.BackColor = Color.Black;
            }
        }

        private void DEL_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                DEL_button.ForeColor = Color.White;
                DEL_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                DEL_button.ForeColor = Color.Black;
                DEL_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                DEL_button.ForeColor = Color.Yellow;
                DEL_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                DEL_button.ForeColor = Color.Black;
                DEL_button.BackColor = Color.Yellow;
            }
        }

        private void DEL_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                DEL_button.ForeColor = Color.Black;
                DEL_button.BackColor = Color.White;
            }
            else if (themeColor == 1)
            {
                DEL_button.ForeColor = Color.White;
                DEL_button.BackColor = Color.Black;
            }
            else if (themeColor == 2)
            {
                DEL_button.ForeColor = Color.Black;
                DEL_button.BackColor = Color.Yellow;
            }
            else if (themeColor == 3)
            {
                DEL_button.ForeColor = Color.Yellow;
                DEL_button.BackColor = Color.Black;
            }
        }

        private void col_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                col_button.ForeColor = Color.White;
                col_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                col_button.ForeColor = Color.Black;
                col_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                col_button.ForeColor = Color.Yellow;
                col_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                col_button.ForeColor = Color.Black;
                col_button.BackColor = Color.Yellow;
            }
        }

        private void col_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                col_button.ForeColor = Color.Black;
                col_button.BackColor = Color.White;
            }
            else if (themeColor == 1)
            {
                col_button.ForeColor = Color.White;
                col_button.BackColor = Color.Black;
            }
            else if (themeColor == 2)
            {
                col_button.ForeColor = Color.Black;
                col_button.BackColor = Color.Yellow;
            }
            else if (themeColor == 3)
            {
                col_button.ForeColor = Color.Yellow;
                col_button.BackColor = Color.Black;
            }
        }

        private void HIDE_button_MouseHover(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                HIDE_button.ForeColor = Color.White;
                HIDE_button.BackColor = Color.Black;
            }
            else if (themeColor == 1)
            {
                HIDE_button.ForeColor = Color.Black;
                HIDE_button.BackColor = Color.White;
            }
            else if (themeColor == 2)
            {
                HIDE_button.ForeColor = Color.Yellow;
                HIDE_button.BackColor = Color.Black;
            }
            else if (themeColor == 3)
            {
                HIDE_button.ForeColor = Color.Black;
                HIDE_button.BackColor = Color.Yellow;
            }
        }

        private void HIDE_button_MouseLeave(object sender, EventArgs e)
        {
            if (themeColor == 0)
            {
                HIDE_button.ForeColor = Color.Black;
                HIDE_button.BackColor = Color.FromArgb(224, 224, 224);
            }
            else if (themeColor == 1)
            {
                HIDE_button.ForeColor = Color.White;
                HIDE_button.BackColor = Color.FromArgb(64, 64, 64);
            }
            else if (themeColor == 2)
            {
                HIDE_button.ForeColor = Color.Black;
                HIDE_button.BackColor = Color.FromArgb(255, 255, 128);
            }
            else if (themeColor == 3)
            {
                HIDE_button.ForeColor = Color.Yellow;
                HIDE_button.BackColor = Color.FromArgb(64, 64, 64);
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
    }
}
