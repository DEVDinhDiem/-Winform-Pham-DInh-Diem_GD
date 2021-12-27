using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.DAO

{
   public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DINHDIEM\SQLEXPRESS;Initial Catalog=QLBH;User Id=sa;Password=sa";
            return conn;
        }
    }
}
