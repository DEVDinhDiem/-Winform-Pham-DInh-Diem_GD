using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testgd
{
    public partial class Bai03 : Form
    {
        int second = 0;
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            label1.Text = second.ToString();

        }
    }
}
