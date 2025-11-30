using System;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DAL
{
    public class OrderDAL
    {
        // Get all orders with agent name
        public DataTable GetOrders()
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = @"
                    SELECT O.OrderID, O.OrderDate, A.AgentName
                    FROM [Order] O
                    JOIN Agent A ON A.AgentID = O.AgentID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Insert order and return new OrderID
        public int CreateOrder(DateTime orderDate, int agentId)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = @"
                    INSERT INTO [Order](OrderDate, AgentID)
                    VALUES(@d, @aid);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d", orderDate);
                cmd.Parameters.AddWithValue("@aid", agentId);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Delete order
        public void DeleteOrder(int orderId)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "DELETE FROM [Order] WHERE OrderID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", orderId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
