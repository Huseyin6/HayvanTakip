using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanTakip.Classes
{
    class sqlslemler
    {
        private static SqlConnection GetSqlConnection()
        {
            // Veritabanı bağlantı kurar.
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D1P3ETA; Initial Catalog=CiflikDB; Integrated Security=True;");
            conn.Open();
            return conn;
        }
        public static object ExecuteScalar(string sqlString)
        {
            SqlCommand command = new SqlCommand(sqlString, GetSqlConnection());
            return command.ExecuteScalar();
        }
        public static void ExecuteNonQuery(string sqlString)
        {
            SqlCommand command = new SqlCommand(sqlString, GetSqlConnection());
            command.ExecuteNonQuery();
        }
        public static DataTable GetDatatable(string sqlString)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlString, GetSqlConnection());
            adapter.Fill(ds);
            return ds.Tables[0];
        }
      
    }
}
