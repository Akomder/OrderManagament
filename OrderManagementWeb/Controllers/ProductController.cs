using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using OrderManagementWeb.Models;

namespace OrderManagementWeb.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private OrderManagementContext db = new OrderManagementContext();

        // GET: Product
        public ActionResult Index(string searchString)
        {
            var products = db.Products.Where(p => p.IsActive);

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.ProductName.Contains(searchString) 
                                            || p.ProductCode.Contains(searchString));
            }

            return View(products.OrderBy(p => p.ProductName).ToList());
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductName,ProductCode,Price,Stock,Description,IsActive")] Product product)
        {
            if (ModelState.IsValid)
            {
                // Check if product code already exists
                if (db.Products.Any(p => p.ProductCode == product.ProductCode))
                {
                    ModelState.AddModelError("ProductCode", "Product Code already exists.");
                    return View(product);
                }

                product.CreatedDate = DateTime.Now;
                db.Products.Add(product);
                db.SaveChanges();
                TempData["Success"] = "Product created successfully.";
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,ProductName,ProductCode,Price,Stock,Description,IsActive,CreatedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                // Check if product code already exists for other products
                if (db.Products.Any(p => p.ProductCode == product.ProductCode && p.ProductId != product.ProductId))
                {
                    ModelState.AddModelError("ProductCode", "Product Code already exists.");
                    return View(product);
                }

                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Success"] = "Product updated successfully.";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Product product = db.Products.Find(id);
                if (product != null)
                {
                    product.IsActive = false;
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Product deactivated successfully." });
                }
                return Json(new { success = false, message = "Product not found." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error: " + ex.Message });
            }
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
