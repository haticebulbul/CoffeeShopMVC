using CoffeeShop.Entity;
using CoffeeShop.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CoffeeShop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
  
            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer(new IdentityInitializer());

        }
    }
}
