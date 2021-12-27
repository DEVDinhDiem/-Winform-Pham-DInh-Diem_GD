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
    public partial class Bai09 : Form
    {
        int count = 0;
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();
        Timer tmEgg = new Timer();
        Timer tmChicken = new Timer();

        int xBasket = 300;
        int yBasket = 370;
        int xDeltaBasket = 30;

        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5;

        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 3;
        public Bai09()
        {
            InitializeComponent();
        }

        private void Bai09_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 20;
            tmEgg.Tick += tmEgg_tick;
            tmEgg.Start();

            tmChicken.Interval = 20;
            tmChicken.Tick += tmChicken_tick;
            tmChicken.Start();

            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.ImageLocation= @"D:\Ảnh\ro.png";

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(70, 70);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.ImageLocation = @"D:\Ảnh\egg_gold.jpg";

            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);
            pbChicken.ImageLocation = @"D:\Ảnh\bird.jpg";
         
        }

        private void tmChicken_tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;
            pbChicken.Location = new Point(xChicken, yChicken);          
        }
        private void tmEgg_tick(object sender, EventArgs e)
        {
           
            yEgg += yDeltaEgg;
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                count--;
                pbEgg.ImageLocation = @"D:\Ảnh\egg_broken.png";
                tmEgg.Stop();
                if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
                {
                    string message = "Game Over";
                    string title = "Thông Báo";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        // không làm gì cả
                    }
                }
            }


            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                tmCount.Start();
                count++;
                yEgg = 30;
                xEgg = pbChicken.Location.X;                
            }
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                yEgg = 30;
                xEgg = pbChicken.Location.X;
                pbEgg.ImageLocation = @"D:\Ảnh\egg_gold.jpg";
            }
            pbEgg.Location = new Point(xEgg, yEgg);
            
        }
        private void tmCount_Tick(object sender, EventArgs e)
        {

            label1.Text = count.ToString();
        }
        private void Bai09_KeyDown(object sender, KeyEventArgs e)
        {      
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;
            if (e.KeyValue == 37 & xBasket > 0)
                xBasket -= xDeltaBasket;
            pbBasket.Location = new Point(xBasket, yBasket);
        }

       
    }
}
