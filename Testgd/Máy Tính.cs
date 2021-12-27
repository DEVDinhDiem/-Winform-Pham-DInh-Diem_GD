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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        //private void button_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "0")
        //        textBox1.Clear();
        //    Button btnNumber = (Button)sender;
        //    textBox1.Text += btnNumber.Text;
        //}
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void tinhtoan_click(object sender, EventArgs e)
        {

            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = System.Convert.ToString(results) + " " + operation;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Double a;
            a = Convert.ToDouble(textBox1.Text) * (-1.0);
            textBox1.Text = System.Convert.ToString(a);

        }
    }
}
