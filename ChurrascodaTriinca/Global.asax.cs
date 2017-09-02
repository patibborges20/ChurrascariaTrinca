using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using ChurrascodaTriinca.App_Start;

namespace ChurrascodaTriinca
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
