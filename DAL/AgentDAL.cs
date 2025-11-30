using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DAL
{
    public class AgentDAL
    {
        // Get all agents
        public DataTable GetAgents()
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "SELECT * FROM Agent";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Insert new agent
        public void AddAgent(string name, string address)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "INSERT INTO Agent(AgentName, Address) VALUES(@n, @a)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@a", address);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update agent
        public void UpdateAgent(int id, string name, string address)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "UPDATE Agent SET AgentName=@n, Address=@a WHERE AgentID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@a", address);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete agent
        public void DeleteAgent(int id)
        {
            using (SqlConnection con = DBHelper.GetConnection())
            {
                string query = "DELETE FROM Agent WHERE AgentID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
