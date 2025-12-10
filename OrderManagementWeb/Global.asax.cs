using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OrderManagementWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            
            // Log the error (in production, use a proper logging framework)
            System.Diagnostics.Debug.WriteLine($"Error: {exception?.Message}");
            
            // Clear the error
            Server.ClearError();
            
            // Redirect to error page
            Response.Redirect("~/Home/Index");
        }
    }
}
