using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Testgd
{
    public partial class KetnoiDB03 : Form
    {
        public KetnoiDB03()
        {
            InitializeComponent();
        }

        private void KetnoiDB03_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sal;User Id=sa;Password=sa";
            conn.Open();
            
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select_Sale";
            cmd.CommandType = CommandType.StoredProcedure;
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
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            //conn.Open();

            //if (tbId.Text == "" || tbName.Text == "")
            //{
            //    MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    //if (kiemtratontai())
            //    //{
            //    //    MessageBox.Show("ID đã tồn tại !");
            //    //}

            //    {
            //        SqlCommand cmd = new SqlCommand("insert into Customer values(@id,@name)", conn);
            //        cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            //        cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));
            //        //cmd.Connection = conn;
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
            //        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
            //        tbId.Text = ""; tbName.Text = "";
            //    }


            //}
            //sử dụng lớp SqlConnection để tạo chuỗi kết nối
            SqlConnection con = new SqlConnection();
  
            //gọi chuỗi kết nối ở file App.config bằng thuộc tính ConnectionString

            //con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            //Chỗ này tạm thời có thể gán cứng chuỗi kết nối
            try
            {
                //khỏi tạo instance của class SqlCommand
                SqlCommand cmd = new SqlCommand();
                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spInsertCustomer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = 105;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = "Tin";
                //cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = "tin@gmail.com";
                //cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = "1234123148";
                //mở chuỗi kết nối
                con.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                con.Close();

                Console.WriteLine("Them Khach Hang thanh cong !!!");
            }
            catch (Exception a)
            {
                Console.WriteLine("Co loi xay ra !!!" + a);
            }
            // dóng chuỗi kết nối
            finally
            {
                con.Close();
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
            //    conn.Open();

            //    if (tbId.Text == "" || tbName.Text == "")
            //    {
            //        MessageBox.Show("Vui Lòng Không Để Trống MaSV,TENSV", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        SqlCommand cmd = new SqlCommand("update customer set Name=@name where id=@id", conn);
            //        cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            //        cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        int idx = dgvCustomer.CurrentCell.RowIndex;
            //        dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            //    }

            //sử dụng lớp SqlConnection để tạo chuỗi kết nối
            SqlConnection con = new SqlConnection();
            //gọi chuỗi kết nối ở file App.config bằng thuộc tính ConnectionString
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            //Chỗ này tạm thời có thể gán cứng chuỗi kết nối
            try
            {
                //khỏi tạo instance của class SqlCommand
                SqlCommand cmd = new SqlCommand();
                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spUpdateCustomer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = 105;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = "Linh";

                //mở chuỗi kết nối
                con.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                con.Close();

                Console.WriteLine("Sua Khach Hang thanh cong !!!");
            }
            catch (Exception a)
            {
                Console.WriteLine("Co loi xay ra !!!" + a);
            }
            // dóng chuỗi kết nối
            finally
            {
                con.Close();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale;User Id=sa;Password=sa";
        //    conn.Open();

        //    string message = "Bạn Có muốn xoá không";
        //    string title = "xoá Sinh Vien";
        //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        //    DialogResult result = MessageBox.Show(message, title, buttons);
        //    if (result == DialogResult.Yes)
        //    {
        //        SqlCommand cmd = new SqlCommand("delete from Customer where id =@id", conn);
        //        cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
        //        cmd.ExecuteNonQuery();
        //        conn.Close();
        //        int idx = dgvCustomer.CurrentCell.RowIndex;
        //        int index = 0;
        //        dgvCustomer.Rows.RemoveAt(index);
        //        tbId.Text = ""; tbName.Text = "";
        //    }
        //    else
        //    {
        //        //không làm gì cả
        //    }
        //sử dụng lớp SqlConnection để tạo chuỗi kết nối
        SqlConnection con = new SqlConnection();
            //gọi chuỗi kết nối ở file App.config bằng thuộc tính ConnectionString
     
            //Chỗ này tạm thời có thể gán cứng chuỗi kết nối
            try
            {
                //khỏi tạo instance của class SqlCommand
                SqlCommand cmd = new SqlCommand();
        //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spDeleteCustomer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
 
                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = 105;
                //mở chuỗi kết nối
                con.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                con.Close();
 
                Console.WriteLine("Xoa khác hàng thanh cong !!!");
            }
            catch (Exception a)
            {
                Console.WriteLine("Co loi xay ra !!!" + a);
            }
            // dóng chuỗi kết nối
            finally
{
    con.Close();
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
