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
    public partial class Bai06 : Form
    {
        PictureBox pbBasket = new PictureBox();
        int xBasket = 300;
        int yBasket = 500;
        int xDelta = 30;
        //PictureBox pbEgg = new PictureBox();
        //Timer tmEgg = new Timer();
        //int xEgg = 300;
        //int yEgg = 0;
        //int xDelta = 3;
        //int yDelta = 3;
        public Bai06()
        {
            InitializeComponent();
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.ImageLocation = @"d:\Ảnh\ro.jpg";
            //tmEgg.Interval = 10;
            //tmEgg.Tick += timer1_Tick;
            //tmEgg.Start();

            //pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbEgg.Size = new Size(100, 100);
            //pbEgg.Location = new Point(xEgg, yEgg);
            //pbEgg.BackColor = Color.Transparent;
            //this.Controls.Add(pbEgg);
            ////pbEgg.Image = Image.FromFile("../../Images/egg_gold.jpg");
            //pbEgg.ImageLocation = @"D:\Ảnh\egg_gold.jpg";
        }
       

        private void Bai06_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDelta;
            if (e.KeyValue == 37 & xBasket > 0)
                xBasket -= xDelta;
            pbBasket.Location = new Point(xBasket, yBasket);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //yEgg += yDelta;
            //if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            //    pbEgg.ImageLocation = @"D:\Ảnh\egg_broken.png";

            //pbEgg.Location = new Point(xEgg, yEgg);
        }

    }
}
