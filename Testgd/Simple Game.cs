﻿using System;
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
    public partial class Bai08 : Form
    {
        PictureBox pbEgg = new PictureBox();
        Timer tmEgg = new Timer();
        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 3;
        public Bai08()
        {
            InitializeComponent();
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDelta;
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
                pbEgg.ImageLocation = @"D:\Ảnh\egg_broken.png";
           
            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void Bai08_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            //pbEgg.Image = Image.FromFile("../../Images/egg_gold.jpg");
            pbEgg.ImageLocation = @"D:\Ảnh\egg_gold.jpg";
        }
    }
}
