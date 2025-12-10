using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using OrderManagementWeb.Models;
using OrderManagementWeb.Models.ViewModels;

namespace OrderManagementWeb.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private OrderManagementContext db = new OrderManagementContext();

        // GET: Order
        public ActionResult Index(string searchString, DateTime? fromDate, DateTime? toDate, int? agentId, string status)
        {
            var orders = db.Orders.Include(o => o.Agent).Include(o => o.User).AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o => o.OrderNumber.Contains(searchString));
            }

            if (fromDate.HasValue)
            {
                orders = orders.Where(o => o.OrderDate >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                orders = orders.Where(o => o.OrderDate <= toDate.Value);
            }

            if (agentId.HasValue)
            {
                orders = orders.Where(o => o.AgentId == agentId.Value);
            }

            if (!String.IsNullOrEmpty(status))
            {
                orders = orders.Where(o => o.Status == status);
            }

            ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");
            ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" });

            return View(orders.OrderByDescending(o => o.OrderDate).ToList());
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            var viewModel = new OrderViewModel
            {
                OrderNumber = GenerateOrderNumber(),
                OrderDate = DateTime.Now
            };

            ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");
            ViewBag.Products = new SelectList(db.Products.Where(p => p.IsActive).OrderBy(p => p.ProductName), "ProductId", "ProductName");
            ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" });

            return View(viewModel);
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.OrderDetails == null || !viewModel.OrderDetails.Any())
                {
                    ModelState.AddModelError("", "Please add at least one order item.");
                    ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");
                    ViewBag.Products = new SelectList(db.Products.Where(p => p.IsActive).OrderBy(p => p.ProductName), "ProductId", "ProductName");
                    ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" });
                    return View(viewModel);
                }

                var order = new Order
                {
                    OrderNumber = viewModel.OrderNumber,
                    OrderDate = viewModel.OrderDate,
                    AgentId = viewModel.AgentId,
                    Status = viewModel.Status,
                    CreatedBy = Convert.ToInt32(Session["UserId"]),
                    CreatedDate = DateTime.Now
                };

                decimal totalAmount = 0;
                foreach (var detailVm in viewModel.OrderDetails.Where(d => d.ProductId > 0))
                {
                    var orderDetail = new OrderDetail
                    {
                        ProductId = detailVm.ProductId,
                        Quantity = detailVm.Quantity,
                        UnitPrice = detailVm.UnitPrice,
                        TotalPrice = detailVm.Quantity * detailVm.UnitPrice
                    };
                    order.OrderDetails.Add(orderDetail);
                    totalAmount += orderDetail.TotalPrice;
                }

                order.TotalAmount = totalAmount;

                db.Orders.Add(order);
                db.SaveChanges();

                TempData["Success"] = "Order created successfully.";
                return RedirectToAction("Index");
            }

            ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");
            ViewBag.Products = new SelectList(db.Products.Where(p => p.IsActive).OrderBy(p => p.ProductName), "ProductId", "ProductName");
            ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" });
            return View(viewModel);
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var order = db.Orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.OrderId == id.Value);
            if (order == null)
            {
                return HttpNotFound();
            }

            var viewModel = new OrderViewModel
            {
                OrderId = order.OrderId,
                OrderNumber = order.OrderNumber,
                OrderDate = order.OrderDate,
                AgentId = order.AgentId,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                OrderDetails = order.OrderDetails.Select(od => new OrderDetailViewModel
                {
                    OrderDetailId = od.OrderDetailId,
                    ProductId = od.ProductId,
                    ProductName = od.Product.ProductName,
                    Quantity = od.Quantity,
                    UnitPrice = od.UnitPrice,
                    TotalPrice = od.TotalPrice
                }).ToList()
            };

            ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName", order.AgentId);
            ViewBag.Products = new SelectList(db.Products.Where(p => p.IsActive).OrderBy(p => p.ProductName), "ProductId", "ProductName");
            ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" }, order.Status);

            return View(viewModel);
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrderViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.OrderDetails == null || !viewModel.OrderDetails.Any())
                {
                    ModelState.AddModelError("", "Please add at least one order item.");
                    ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");
                    ViewBag.Products = new SelectList(db.Products.Where(p => p.IsActive).OrderBy(p => p.ProductName), "ProductId", "ProductName");
                    ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" });
                    return View(viewModel);
                }

                var order = db.Orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.OrderId == viewModel.OrderId);
                if (order == null)
                {
                    return HttpNotFound();
                }

                order.OrderDate = viewModel.OrderDate;
                order.AgentId = viewModel.AgentId;
                order.Status = viewModel.Status;

                // Remove existing order details
                db.OrderDetails.RemoveRange(order.OrderDetails);

                // Add new order details
                decimal totalAmount = 0;
                foreach (var detailVm in viewModel.OrderDetails.Where(d => d.ProductId > 0))
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.OrderId,
                        ProductId = detailVm.ProductId,
                        Quantity = detailVm.Quantity,
                        UnitPrice = detailVm.UnitPrice,
                        TotalPrice = detailVm.Quantity * detailVm.UnitPrice
                    };
                    db.OrderDetails.Add(orderDetail);
                    totalAmount += orderDetail.TotalPrice;
                }

                order.TotalAmount = totalAmount;
                db.SaveChanges();

                TempData["Success"] = "Order updated successfully.";
                return RedirectToAction("Index");
            }

            ViewBag.Agents = new SelectList(db.Agents.Where(a => a.IsActive).OrderBy(a => a.AgentName), "AgentId", "AgentName");
            ViewBag.Products = new SelectList(db.Products.Where(p => p.IsActive).OrderBy(p => p.ProductName), "ProductId", "ProductName");
            ViewBag.Statuses = new SelectList(new[] { "Pending", "Processing", "Completed", "Cancelled" });
            return View(viewModel);
        }

        // GET: Order/Print/5
        public ActionResult Print(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var order = db.Orders
                .Include(o => o.Agent)
                .Include(o => o.OrderDetails.Select(od => od.Product))
                .FirstOrDefault(o => o.OrderId == id.Value);

            if (order == null)
            {
                return HttpNotFound();
            }

            return View(order);
        }

        // GET: Order/GetProductPrice
        [HttpGet]
        public JsonResult GetProductPrice(int productId)
        {
            var product = db.Products.Find(productId);
            if (product != null)
            {
                return Json(new { price = product.Price, name = product.ProductName }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { price = 0, name = "" }, JsonRequestBehavior.AllowGet);
        }

        private string GenerateOrderNumber()
        {
            var lastOrder = db.Orders.OrderByDescending(o => o.OrderId).FirstOrDefault();
            int nextNumber = 1;
            
            if (lastOrder != null)
            {
                var lastNumberStr = lastOrder.OrderNumber.Substring(lastOrder.OrderNumber.LastIndexOf('-') + 1);
                if (int.TryParse(lastNumberStr, out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }

            return $"ORD-{DateTime.Now.Year}-{nextNumber:D3}";
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
