using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DAL

{
    public class ItemDAL
    {
        public DataTable GetItems()
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "SELECT * FROM Item";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool AddItem(string name, string size, decimal price)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string q = "INSERT INTO Item(ItemName, Size, UnitPrice) VALUES(@n, @s, @p)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", size);
                cmd.Parameters.AddWithValue("@p", price);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool UpdateItem(int itemID, string name, string size, decimal price)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string q = "UPDATE Item SET ItemName = @n, Size = @s, UnitPrice = @p WHERE ItemID = @id";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id", itemID);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", size);
                cmd.Parameters.AddWithValue("@p", price);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool DeleteItem(int itemID)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string q = "DELETE FROM Item WHERE ItemID = @id";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id", itemID);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
