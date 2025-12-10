using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBHelper
    {
        private static string connString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=OrderManagementDb;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}
