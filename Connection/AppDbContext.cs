using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
   public class AppDbContext
    {
        readonly string con = "Server=DESKTOP-F7ML9LC\\SQLEXPRESS;Database=Steam;Trusted_Connection=True;";
        SqlConnection sqlConnection;
        public AppDbContext()
        {
            sqlConnection = new SqlConnection(con);
        }
        public int Nonquery(string command)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
    }
}
