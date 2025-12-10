using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderManagementWeb.Models.ViewModels
{
    public class BestSellingItemsViewModel
    {
        [Display(Name = "From Date")]
        [DataType(DataType.Date)]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date")]
        [DataType(DataType.Date)]
        public DateTime? ToDate { get; set; }

        public List<BestSellingItemReport> Items { get; set; }

        public BestSellingItemsViewModel()
        {
            Items = new List<BestSellingItemReport>();
        }
    }

    public class BestSellingItemReport
    {
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Total Quantity Sold")]
        public int TotalQuantity { get; set; }

        [Display(Name = "Total Revenue")]
        [DataType(DataType.Currency)]
        public decimal TotalRevenue { get; set; }
    }

    public class CustomerPurchasesViewModel
    {
        [Display(Name = "Agent")]
        public int? AgentId { get; set; }

        [Display(Name = "From Date")]
        [DataType(DataType.Date)]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date")]
        [DataType(DataType.Date)]
        public DateTime? ToDate { get; set; }

        public string AgentName { get; set; }

        public List<CustomerPurchaseReport> Purchases { get; set; }

        public CustomerPurchasesViewModel()
        {
            Purchases = new List<CustomerPurchaseReport>();
        }
    }

    public class CustomerPurchaseReport
    {
        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
    }

    public class PurchaseSummaryViewModel
    {
        [Display(Name = "From Date")]
        [DataType(DataType.Date)]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date")]
        [DataType(DataType.Date)]
        public DateTime? ToDate { get; set; }

        public List<PurchaseSummaryReport> Summary { get; set; }

        public PurchaseSummaryViewModel()
        {
            Summary = new List<PurchaseSummaryReport>();
        }
    }

    public class PurchaseSummaryReport
    {
        [Display(Name = "Agent Name")]
        public string AgentName { get; set; }

        [Display(Name = "Total Orders")]
        public int TotalOrders { get; set; }

        [Display(Name = "Total Items")]
        public int TotalItems { get; set; }

        [Display(Name = "Total Amount Spent")]
        [DataType(DataType.Currency)]
        public decimal TotalAmountSpent { get; set; }
    }
}
