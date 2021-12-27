using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_Hinh_3_Lop
{
   public class CustomerDAL : DBConnection{            
            public  List<CustomerBEL> ReadCustomer()
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
            SqlCommand cmd = new SqlCommand("Select_Student", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //tạo đối tượng command
            SqlCommand cmd = new SqlCommand()
            {
                CommandText = "spGetCustomer",
                Connection = conn,
                CommandType = CommandType.StoredProcedure
            };
            //khai báo các thuộc tính của tham số
            SqlParameter param = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Value = 101,
                Direction = ParameterDirection.Input
            };
            //thêm tham số vào đối tượng SqlCommand
            cmd.Parameters.Add(param);


            //List<CustomerBEL> lstCus = new List<CustomerBEL>();
            //    while (reader.Read())
            //    {
            //        CustomerBEL cus = new CustomerBEL();
            //        cus.Id = int.Parse(reader["id"].ToString());
            //        cus.Name = reader["name"].ToString();
            //        lstCus.Add(cus);
            //    }
            conn.Close();
            //return lstCus;
        }
        public void DeleteCustomer(CustomerBEL cus)
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from customer where id=@id", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void NewCustomer(CustomerBEL cus)
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into customer values(@id,@name)", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void EditCustomer(CustomerBEL cus)
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update customer set Name=@name where id=@id", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.ExecuteNonQuery();
                conn.Close();

            
          
        }
       
    }
}


