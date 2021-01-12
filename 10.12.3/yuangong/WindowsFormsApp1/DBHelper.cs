using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DBHelper
    {
        public static string connSrt = "server=WINDOWS-FFNHC6M;database=TestDB;Integrated Security=True";
        public static SqlConnection conn = null;
        public static void InitConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connSrt);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (conn.State== ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        public static bool ExectuNonQuery(string sql)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}
