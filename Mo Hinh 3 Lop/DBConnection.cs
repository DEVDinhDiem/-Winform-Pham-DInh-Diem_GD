using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mo_Hinh_3_Lop
{
   public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=Sal;User Id=sa;Password=sa";
            return conn;
        }
    }
    
}
