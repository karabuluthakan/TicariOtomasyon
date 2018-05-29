using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicariOtomasyon.CLASS
{
    public class SQL
    {
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = HKNKRBLT\\MSSQLSERVER2016; Initial Catalog = TicariOtomasyon; Integrated Security = True");
            conn.Open();
            return conn;
        }
    }
}
