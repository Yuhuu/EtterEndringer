using OnlineWebShop.DAL;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;


namespace webshop
{
  public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
      Database.SetInitializer(new OnlineShopDbInitializer());
      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
    }
}
