using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class TimingDown : Form
    {
        int s = 0, min = 0, h = 0;//秒分钟小时
        public TimingDown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void TimingDown_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = int.Parse(textBox3.Text);
            min = int.Parse(textBox2.Text);
            h = int.Parse(textBox1.Text);
            s--;
            if (s == 0&&min>=1) { s = 60; min--; }
            if (min == 0&&h>=1) { min = 60; h--; }
            if (h < 0) { h = 0; timer1.Enabled=false; }
            this.label1.Text = h + "小时" + min + "分钟" + s + "秒";
        }
    }
}
