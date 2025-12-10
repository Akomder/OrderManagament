using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OrderManagementWeb.Models;
using OrderManagementWeb.Models.ViewModels;

namespace OrderManagementWeb.Controllers
{
    /// <summary>
    /// Handles user authentication and authorization
    /// </summary>
    public class AccountController : Controller
    {
        private OrderManagementContext db = new OrderManagementContext();

        /// <summary>
        /// Displays the login page
        /// </summary>
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Processes login form submission
        /// NOTE: In production, passwords should be hashed using a secure algorithm (e.g., BCrypt, PBKDF2)
        /// This implementation uses plain text for demonstration purposes only
        /// </summary>
        /// <param name="model">Login credentials</param>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // SECURITY WARNING: This uses plain text password comparison
                // In production, use: BCrypt.Verify(model.Password, user.PasswordHash)
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

        /// <summary>
        /// Logs out the current user
        /// </summary>
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
