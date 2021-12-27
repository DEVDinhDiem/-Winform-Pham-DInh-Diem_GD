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
    public partial class Test : Form
    {
        int selectedRow;
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = "Bạn Có muốn thêm không";
            string title = "Thêm Sinh Vien";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int sv = dataGridView1.Rows.Add();
                dataGridView1.Rows[sv].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[sv].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[sv].Cells[2].Value = textBox3.Text;
            }
            else
            {
                // Do something  
                //}
                //for (int i = 0; i < dt.Rows.Count - 1; i++)
                //{
                //    if (int.Parse(dt.Rows[i]["ID_Function"].ToString()) == 13)
                //    {
                //        for (int j = i + 1; j < dt.Rows.Count; j++)
                //        {
                //            string b = dt.Rows[j]["ID_Function"].ToString();
                //            if (dt.Rows[i]["ID_Function"].ToString() == b)
                //            {
                //                CheckBox chkdell = (CheckBox)GridView1.Rows[j].Cells[3].FindControl("CheckBox1");
                //                chkdell.Visible = false;
                //            }
                //        }
                //    }
                //}


            }
        }
    }
}
