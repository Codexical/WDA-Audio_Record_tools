using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordAudio
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public int themeCol;

        private void Form6_Load(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themeCol = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themeCol = 1;
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            themeCol = 2;
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            themeCol = 3;
            this.Close();
        }

    }
}
