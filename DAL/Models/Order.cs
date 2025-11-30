using System;

namespace DAL.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int AgentID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
