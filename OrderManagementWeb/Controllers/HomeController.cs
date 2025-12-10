using System.Web.Mvc;

namespace OrderManagementWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home/Index (Dashboard)
        public ActionResult Index()
        {
            ViewBag.FullName = Session["FullName"];
            ViewBag.Username = Session["Username"];
            return View();
        }
    }
}
