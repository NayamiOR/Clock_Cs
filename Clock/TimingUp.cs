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
    public partial class TimingUp : Form
    {

        int s=0, min=0, h=0;//秒分钟小时

        private void TimingUp_Load(object sender, EventArgs e)
        {
            Clock.TUState(true);
        }

        private void TimingUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clock.TUState(false);
        }

        public TimingUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s >= 60) { s = 0; min++; }
            if (min >= 60) { min = 0;h++; }
            if (h >= 10) { h = 0; }
            this.label1.Text=h+"小时"+min+"分钟"+s+"秒";
        }
    }
}
