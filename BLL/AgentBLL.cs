using System;
using System.Data;
using DAL;

namespace BLL
{
    public class AgentBLL
    {
        private AgentDAL dal = new AgentDAL();

        public DataTable GetAgents()
        {
            return dal.GetAgents();
        }

        public void AddAgent(string name, string address)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Agent name cannot be empty.");

            dal.AddAgent(name, address);
        }

        public void UpdateAgent(int agentID, string name, string address)
        {
            if (agentID <= 0)
                throw new Exception("Invalid Agent ID.");

            dal.UpdateAgent(agentID, name, address);
        }

        public void DeleteAgent(int agentID)
        {
            if (agentID <= 0)
                throw new Exception("Invalid Agent ID.");

            dal.DeleteAgent(agentID);
        }
    }
}
