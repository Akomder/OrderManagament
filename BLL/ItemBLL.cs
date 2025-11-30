using System;
using System.Data;
using DAL;

namespace BLL
{
    public class ItemBLL
    {
        private ItemDAL dal = new ItemDAL();

        public DataTable GetItems()
        {
            return dal.GetItems();
        }

        public bool AddItem(string name, string size, decimal unitPrice)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Item name cannot be empty.");

            if (unitPrice <= 0)
                throw new Exception("Unit price must be greater than zero.");

            return dal.AddItem(name, size, unitPrice);
        }

        public bool UpdateItem(int itemID, string name, string size, decimal unitPrice)
        {
            if (itemID <= 0)
                throw new Exception("Invalid Item ID.");

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Item name cannot be empty.");

            if (unitPrice <= 0)
                throw new Exception("Unit price must be greater than zero.");

            return dal.UpdateItem(itemID, name, size, unitPrice);
        }

        public bool DeleteItem(int itemID)
        {
            if (itemID <= 0)
                throw new Exception("Invalid Item ID.");

            return dal.DeleteItem(itemID);
        }
    }
}
