using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OrderManagementWeb.Models;
using OrderManagementWeb.Models.ViewModels;

namespace OrderManagementWeb.Controllers
{
    public class AccountController : Controller
    {
        private OrderManagementContext db = new OrderManagementContext();

        // GET: Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
                
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, model.RememberMe);
                    Session["UserId"] = user.UserId;
                    Session["Username"] = user.Username;
                    Session["FullName"] = user.FullName;
                    Session["Role"] = user.Role;
                    
                    return RedirectToAction("Index", "Home");
                }
                
                ModelState.AddModelError("", "Invalid username or password.");
            }

            return View(model);
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
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
