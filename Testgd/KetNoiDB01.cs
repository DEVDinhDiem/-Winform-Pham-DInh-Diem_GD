using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testgd
{
   
    public partial class KetNoiDB01 : Form
    {
        

        public KetNoiDB01()
        {
            InitializeComponent();
        }
        //private bool kiemtratontai()
        //{
        //    bool tatkt = false;
        //    string maso = tbId.Text;
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("select*from customer", conn);
        //    SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from customer where id='" + maso + "'", conn);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt_kiemTra = new DataTable();
        //    da_kiemtra.Fill(dt_kiemTra);
        //    if (dt_kiemTra.Rows.Count > 0)
        //    {
        //        tatkt = true;
        //    }
        //    da_kiemtra.Dispose();
        //    return tatkt;
        //    //while (dr.Read())
        //    //{
        //    //    if (maso == dr.GetString(0))
        //    //    {
        //    //        tatkt = true;
        //    //        break;
        //    //    }
        //    //}
        //    conn.Close();
        //    return tatkt;
        //}
        private void btNew_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            conn.Open();
                  
                if (tbId.Text == "" || tbName.Text == "")
            {
                MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //if (kiemtratontai())
                //{
                //    MessageBox.Show("ID đã tồn tại !");
                //}
                
                {
                    SqlCommand cmd = new SqlCommand("insert into Customer values(" + tbId.Text + ",'" + tbName.Text + "')", conn);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
                    tbId.Text = ""; tbName.Text = "";
                }

               
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            conn.Open();
            
            string message = "Bạn Có muốn xoá không";
            string title = "xoá Sinh Vien";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from Customer where id =" + tbId.Text, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                int idx = dgvCustomer.CurrentCell.RowIndex;
                int index = 0;
                dgvCustomer.Rows.RemoveAt(index);
                tbId.Text = ""; tbName.Text = "";
            }    
            else
            {
                //không làm gì cả
            }               
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            conn.Open();

            if (tbId.Text == "" || tbName.Text == "")
            {
                MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update customer set Name='" + tbName.Text + "'where id=" + tbId.Text, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select*from customer", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
            //    }
            //}
            
            //conn.Close();
        }

        private void KetNoiDB01_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }

            conn.Close();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text=dgvCustomer.Rows[idx].Cells[1].Value.ToString();
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
