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
    public partial class Clock : Form
    {
        //检查TimingUp和TimingDown窗口是否已经打开
        bool TUpOpen = false;
        bool TDownOpen = false;
        public Clock()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();//显示当前时间
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new TimingDown();
            if (TDownOpen == false)//如果已经开启则不打开新窗口
            {
                frm.Show();
                TDownOpen = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new TimingUp();
            frm.Show();
        }
    }
}
