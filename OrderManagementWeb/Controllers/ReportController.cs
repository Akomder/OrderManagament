using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using OrderManagementWeb.Models;
using OrderManagementWeb.Models.ViewModels;

namespace OrderManagementWeb.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private OrderManagementContext db = new OrderManagementContext();

        // GET: Report/BestSellingItems
        public ActionResult BestSellingItems(DateTime? fromDate, DateTime? toDate)
        {
            var viewModel = new BestSellingItemsViewModel
            {
                FromDate = fromDate,
                ToDate = toDate
            };

            if (fromDate.HasValue || toDate.HasValue)
            {
                var query = db.OrderDetails
                    .Include(od => od.Order)
                    .Include(od => od.Product)
                    .AsQueryable();

                if (fromDate.HasValue)
                {
                    query = query.Where(od => od.Order.OrderDate >= fromDate.Value);
                }

                if (toDate.HasValue)
                {
                    query = query.Where(od => od.Order.OrderDate <= toDate.Value);
                }

                viewModel.Items = query
                    .GroupBy(od => new { od.Product.ProductId, od.Product.ProductName })
                    .Select(g => new BestSellingItemReport
                    {
                        ProductName = g.Key.ProductName,
                        TotalQuantity = g.Sum(od => od.Quantity),
                        TotalRevenue = g.Sum(od => od.TotalPrice)
                    })
                    .OrderByDescending(x => x.TotalQuantity)
                    .ToList();
            }

            return View(viewModel);
        }

        // GET: Report/CustomerPurchases
        public ActionResult CustomerPurchases(int? agentId, DateTime? fromDate, DateTime? toDate)
        {
            var viewModel = new CustomerPurchasesViewModel
            {
                AgentId = agentId,
                FromDate = fromDate,
                ToDate = toDate
            };

            ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");

            if (agentId.HasValue)
            {
                var agent = db.Agents.Find(agentId.Value);
                if (agent != null)
                {
                    viewModel.AgentName = agent.AgentName;

                    var query = db.OrderDetails
                        .Include(od => od.Order)
                        .Include(od => od.Product)
                        .Where(od => od.Order.AgentId == agentId.Value);

                    if (fromDate.HasValue)
                    {
                        query = query.Where(od => od.Order.OrderDate >= fromDate.Value);
                    }

                    if (toDate.HasValue)
                    {
                        query = query.Where(od => od.Order.OrderDate <= toDate.Value);
                    }

                    viewModel.Purchases = query
                        .Select(od => new CustomerPurchaseReport
                        {
                            OrderNumber = od.Order.OrderNumber,
                            OrderDate = od.Order.OrderDate,
                            ProductName = od.Product.ProductName,
                            Quantity = od.Quantity,
                            Amount = od.TotalPrice
                        })
                        .OrderByDescending(x => x.OrderDate)
                        .ToList();
                }
            }

            return View(viewModel);
        }

        // GET: Report/PurchaseSummary
        public ActionResult PurchaseSummary(DateTime? fromDate, DateTime? toDate)
        {
            var viewModel = new PurchaseSummaryViewModel
            {
                FromDate = fromDate,
                ToDate = toDate
            };

            if (fromDate.HasValue || toDate.HasValue)
            {
                var query = db.Orders
                    .Include(o => o.Agent)
                    .Include(o => o.OrderDetails)
                    .AsQueryable();

                if (fromDate.HasValue)
                {
                    query = query.Where(o => o.OrderDate >= fromDate.Value);
                }

                if (toDate.HasValue)
                {
                    query = query.Where(o => o.OrderDate <= toDate.Value);
                }

                viewModel.Summary = query
                    .GroupBy(o => new { o.Agent.AgentId, o.Agent.AgentName })
                    .Select(g => new PurchaseSummaryReport
                    {
                        AgentName = g.Key.AgentName,
                        TotalOrders = g.Count(),
                        TotalItems = g.Sum(o => o.OrderDetails.Sum(od => od.Quantity)),
                        TotalAmountSpent = g.Sum(o => o.TotalAmount)
                    })
                    .OrderByDescending(x => x.TotalAmountSpent)
                    .ToList();
            }

            return View(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
