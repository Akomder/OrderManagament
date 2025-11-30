using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        public bool CheckLogin(string user, string pass)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p AND Lock=0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 1;
            }
        }
    }
}
