using MoHinh3Lop_Bai5.BAL;
using MoHinh3Lop_Bai5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoHinh3Lop_Bai5
{
    public partial class GUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        AreaBAL areBAL = new AreaBAL();
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach (CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            }
            List<AreaBEL> lstArea = areBAL.ReadAreaList();
            foreach (AreaBEL area in lstArea)
            {
                cbArea.Items.Add(area);
            }
            cbArea.DisplayMember = "name";
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int idx = e.RowIndex;
            //DataGridView row = dgvCustomer.Rows[idx];
            //if (row.Cells[0].Value != null)
            //{
            //    tbId.Text = row.Cells[0].Value.ToString();
            //    tbName.Text = row.Cells[1].Value.ToString();
            //    cbArea.Text = row.Cells[2].Value.ToString();
            //}
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbName.Text == "")

                MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cusBAL.NewCustomer(cus);
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.Area.Name);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbName.Text == "")

                MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cusBAL.EditCustomer(cus);

                DataGridViewRow row = dgvCustomer.CurrentRow;

                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
            cbArea.Text= dgvCustomer.Rows[idx].Cells[2].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string message = "Bạn Có muốn xoá không";
            string title = "xoá Sinh Vien";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cusBAL.DeleteCustomer(cus);
                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows.RemoveAt(idx);
            }
            else
            { //}
            }
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
    } 
}
