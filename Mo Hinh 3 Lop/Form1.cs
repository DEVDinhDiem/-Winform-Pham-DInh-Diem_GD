using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_Hinh_3_Lop
{
    public partial class Form1 : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            
            foreach (CustomerBEL cus in lstCus)
            {
                
                dgvCustomer.Rows.Add(cus.Id, cus.Name);
            }

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cusBAL.NewCustomer(cus);
            dgvCustomer.Rows.Add(cus.Id, cus.Name);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;           
            cusBAL.DeleteCustomer(cus);
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            //CustomerBEL cus = (CustomerBEL)bsCus.Current;
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cusBAL.EditCustomer(cus);

            DataGridViewRow row = dgvCustomer.CurrentRow;
           
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;


        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có muốn Thoát", "Thoát Chương Trình", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            switch (result)
            {
                case DialogResult.No:
                    //
                    break;
                case DialogResult.Yes:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
        }
    }
}
