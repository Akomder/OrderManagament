using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderManagementWeb.Models.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Please select an agent")]
        [Display(Name = "Agent")]
        public int AgentId { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Display(Name = "Total Amount")]
        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        public List<OrderDetailViewModel> OrderDetails { get; set; }

        public OrderViewModel()
        {
            OrderDate = DateTime.Now;
            Status = "Pending";
            OrderDetails = new List<OrderDetailViewModel>();
        }
    }

    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }

        [Required(ErrorMessage = "Please select a product")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Unit Price")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Line Total")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }
    }
}
