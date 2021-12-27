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
    public partial class Bai07 : Form
    {

        
        int selectedRow;
        List<SinhVien> lstSinhVien { get; set; }
        public Bai07()
        {
            
            lstSinhVien = GetSinhVien();
            InitializeComponent();
        }

        private List<SinhVien> GetSinhVien()
        {
            List<SinhVien> lstSinhVien = new List<SinhVien>();
            SinhVien ObjSinhVien = new SinhVien();
            ObjSinhVien.MaSV = 01;
            ObjSinhVien.TenSV = "Pham Dinh Diem";
            ObjSinhVien.NgaySinh = DateTime.Now;
            ObjSinhVien.NoiSinh = "HCM";
            ObjSinhVien.GioiTinh = false;
            lstSinhVien.Add(ObjSinhVien);

            ObjSinhVien = new SinhVien();
            ObjSinhVien.MaSV = 02;
            ObjSinhVien.TenSV = "Pham Dinh Diem";
            ObjSinhVien.NgaySinh = DateTime.Now;
            ObjSinhVien.NoiSinh = "Binh Dinh";
            ObjSinhVien.GioiTinh = true;
            lstSinhVien.Add(ObjSinhVien);

            ObjSinhVien = new SinhVien();
            ObjSinhVien.MaSV = 03;
            ObjSinhVien.TenSV = "Pham Dinh Diem";
            ObjSinhVien.NgaySinh = DateTime.Now;
            ObjSinhVien.NoiSinh = "BD";
            ObjSinhVien.GioiTinh = true;
            lstSinhVien.Add(ObjSinhVien);

            return lstSinhVien;
        }
        private void Bai07_Load(object sender, EventArgs e)
        {
            var sv = this.lstSinhVien;
            dataGridView1.DataSource = sv;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                var objSV = dataGridView1.SelectedRows[0].DataBoundItem as SinhVien;
                txtMaSV.Text = objSV.MaSV.ToString();
                txtHoTen.Text = objSV.TenSV.ToString();
                dtNgaySinh.Value = objSV.NgaySinh;
                txtNoiSinh.Text = objSV.NoiSinh.ToString();
                cbGioiTinh.Checked = objSV.GioiTinh;
            }
            catch(Exception)
            {
                throw;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            SinhVien objSinhVien = new SinhVien();
            if (txtMaSV.Text == "" || txtHoTen.Text == "")
                MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                /*
                for (int i = 0; i < lstSinhVien.MaSV.Count; i++) //tạo vòng lặp từ hàng đầu tiên đến hàng cuối cùng có dữ liệu trong listview
                {
                    if (txtMaSV.Text == lstSinhVien.MaSV[1].Count.Text)  //nếu dữ liệu của text trùng với hàng thứ i thì xuất câu thông báo
                    {
                        MessageBox.Show("Trùng cmnr !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else*/
                    {

                objSinhVien.MaSV = int.Parse(txtMaSV.Text);
                        objSinhVien.TenSV = txtHoTen.Text;
                        objSinhVien.NgaySinh = dtNgaySinh.Value;
                        objSinhVien.NoiSinh = txtNoiSinh.Text;

                        if (cbGioiTinh.Checked)
                        {
                            objSinhVien.GioiTinh = true;

                        }
                        lstSinhVien.Add(objSinhVien);

                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = lstSinhVien;
                        dataGridView1.DataSource = bSource;
                    txtHoTen.Text = "";
                    txtMaSV.Text = "";
                    txtNoiSinh.Text = "";
                    cbGioiTinh.Checked = false;
                }
                
               
            }
                  
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
          
              
            
            if (txtMaSV.Text == "" || txtHoTen.Text == "")
                MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
                newDataRow.Cells[0].Value = txtMaSV.Text;
                newDataRow.Cells[1].Value = txtHoTen.Text;
                newDataRow.Cells[2].Value = dtNgaySinh.Text;
                if (cbGioiTinh.Checked)
                {
                    newDataRow.Cells[3].Value = true;
                }
                newDataRow.Cells[4].Value = txtNoiSinh.Text;
            }
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            string message = "Bạn Có muốn xoá không";
            string title = "xoá Sinh Vien";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                    txtHoTen.Text = "";
                    txtMaSV.Text = "";
                    txtNoiSinh.Text = "";
                    cbGioiTinh.Checked= false;
                }
            }
            else
            {
                // không làm gì cả
            }                   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*Cach Khac*/
            //string message = "Bạn Có muốn Thoát không";
            //string title = "Thoát Chương Trình";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(message, title, buttons);
            //if (result == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            //else
            //{
            //    //không lm gì hết

            //}
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
