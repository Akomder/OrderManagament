using System;
using System.Data;
using DAL;

namespace BLL
{
    public class OrderDetailBLL
    {
        private OrderDetailDAL dal = new OrderDetailDAL();

        public DataTable GetOrderDetails(int orderID)
        {
            if (orderID <= 0)
                throw new Exception("Invalid Order ID.");

            return dal.GetOrderDetails(orderID);
        }

        public void AddDetail(int orderID, int itemID, int qty, decimal unitAmount)
        {
            if (orderID <= 0) throw new Exception("Invalid Order ID.");
            if (itemID <= 0) throw new Exception("Invalid Item ID.");
            if (qty <= 0) throw new Exception("Quantity must be greater than 0.");
            if (unitAmount <= 0) throw new Exception("Unit amount must be greater than 0.");

            dal.AddDetail(orderID, itemID, qty, unitAmount);
        }

        public void DeleteDetail(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid Detail ID.");

            dal.DeleteDetail(id);
        }
    }
}
