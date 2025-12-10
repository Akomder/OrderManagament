using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using OrderManagementWeb.Models;

namespace OrderManagementWeb.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private OrderManagementContext db = new OrderManagementContext();

        // GET: Agent
        public ActionResult Index(string searchString)
        {
            var agents = db.Agents.Where(a => a.IsActive);

            if (!String.IsNullOrEmpty(searchString))
            {
                agents = agents.Where(a => a.AgentName.Contains(searchString) 
                                        || a.AgentCode.Contains(searchString)
                                        || a.Email.Contains(searchString));
            }

            return View(agents.OrderBy(a => a.AgentName).ToList());
        }

        // GET: Agent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgentName,AgentCode,Email,Phone,Address,IsActive")] Agent agent)
        {
            if (ModelState.IsValid)
            {
                // Check if agent code already exists
                if (db.Agents.Any(a => a.AgentCode == agent.AgentCode))
                {
                    ModelState.AddModelError("AgentCode", "Agent Code already exists.");
                    return View(agent);
                }

                agent.CreatedDate = DateTime.Now;
                db.Agents.Add(agent);
                db.SaveChanges();
                TempData["Success"] = "Agent created successfully.";
                return RedirectToAction("Index");
            }

            return View(agent);
        }

        // GET: Agent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agent agent = db.Agents.Find(id);
            if (agent == null)
            {
                return HttpNotFound();
            }
            return View(agent);
        }

        // POST: Agent/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgentId,AgentName,AgentCode,Email,Phone,Address,IsActive,CreatedDate")] Agent agent)
        {
            if (ModelState.IsValid)
            {
                // Check if agent code already exists for other agents
                if (db.Agents.Any(a => a.AgentCode == agent.AgentCode && a.AgentId != agent.AgentId))
                {
                    ModelState.AddModelError("AgentCode", "Agent Code already exists.");
                    return View(agent);
                }

                db.Entry(agent).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Success"] = "Agent updated successfully.";
                return RedirectToAction("Index");
            }
            return View(agent);
        }

        // POST: Agent/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Agent agent = db.Agents.Find(id);
                if (agent != null)
                {
                    agent.IsActive = false;
                    db.Entry(agent).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Agent deactivated successfully." });
                }
                return Json(new { success = false, message = "Agent not found." });
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
