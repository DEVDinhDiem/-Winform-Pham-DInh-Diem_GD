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
    public partial class Bai02 : Form
    {
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;
        public Bai02()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(300, 300);
            pb.Location = new Point(x, y);
            this.Controls.Add(pb);
            pb.ImageLocation = @"d:\Ảnh\1234.png";
        }
    }
}
