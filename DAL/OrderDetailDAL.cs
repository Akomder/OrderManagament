using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DAL
{
    public class OrderDetailDAL
    {
        // Get order details for a specific order
        public DataTable GetOrderDetails(int orderId)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = @"
                    SELECT OD.ID, I.ItemName, OD.Quantity, OD.UnitAmount
                    FROM OrderDetail OD
                    JOIN Item I ON I.ItemID = OD.ItemID
                    WHERE OD.OrderID = @oid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@oid", orderId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Insert order detail
        public void AddDetail(int orderId, int itemId, int qty, decimal price)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = @"
                    INSERT INTO OrderDetail(OrderID, ItemID, Quantity, UnitAmount)
                    VALUES(@oid, @iid, @q, @p)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@oid", orderId);
                cmd.Parameters.AddWithValue("@iid", itemId);
                cmd.Parameters.AddWithValue("@q", qty);
                cmd.Parameters.AddWithValue("@p", price);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete order detail row
        public void DeleteDetail(int id)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "DELETE FROM OrderDetail WHERE ID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
