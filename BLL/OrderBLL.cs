using System;
using System.Data;
using DAL;

namespace BLL
{
    public class OrderBLL
    {
        private OrderDAL dal = new OrderDAL();

        public DataTable GetOrders()
        {
            return dal.GetOrders();
        }

        public int CreateOrder(DateTime orderDate, int agentID)
        {
            if (agentID <= 0)
                throw new Exception("Invalid Agent ID.");

            if (orderDate > DateTime.Now.AddDays(1))
                throw new Exception("Order date cannot be in the future.");

            return dal.CreateOrder(orderDate, agentID);
        }

        public void DeleteOrder(int orderID)
        {
            if (orderID <= 0)
                throw new Exception("Invalid Order ID.");

            dal.DeleteOrder(orderID);
        }
    }
}
