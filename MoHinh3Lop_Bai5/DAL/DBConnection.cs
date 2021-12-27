using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHinh3Lop_Bai5.DAL
{
    public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=sale5;User Id=sa;Password=sa";
            return conn;
        }
    }
    
}
