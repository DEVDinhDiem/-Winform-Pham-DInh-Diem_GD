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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void DB03_Click(object sender, EventArgs e)
        {
            KetnoiDB03 BaiDB03 = new KetnoiDB03();
            BaiDB03.Show();
        }
    }
}
