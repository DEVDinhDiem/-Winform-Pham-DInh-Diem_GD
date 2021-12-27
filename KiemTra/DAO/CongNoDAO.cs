using KiemTra.BLL;
using KiemTra.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.DAO
{
    public class CongNODAO : DBConnection
    {
        public List<CongNoBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from congno", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CongNoBEL> lstCus = new List<CongNoBEL>();
            while (reader.Read())
            {
                CongNoBEL cus = new CongNoBEL();
                cus.id = int.Parse(reader["makhachhang"].ToString());
                cus.name = reader["tenkhachhang"].ToString();
                cus.phone= reader["sodienthoai"].ToString();
                cus.tienno = reader["sotienno"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteCustomer(CongNoBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from congno where makhachhang=@makhachhang", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(CongNoBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into congno values(@makhachhang,@tenkhachhang,@sodienthoai,@sotienno)", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.id));
            cmd.Parameters.Add(new SqlParameter("@tenkhachhang", cus.name));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", cus.phone));
            cmd.Parameters.Add(new SqlParameter("@sotienno", cus.tienno));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(CongNoBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update congno set tenkhachhang=@tenkhachhang where makhachhang=@makhachhang", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.id));
            cmd.Parameters.Add(new SqlParameter("@tenkhachhang", cus.name));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", cus.phone));
            cmd.Parameters.Add(new SqlParameter("@sotienno", cus.tienno));
            cmd.ExecuteNonQuery();
            conn.Close();



        }

    }
}
