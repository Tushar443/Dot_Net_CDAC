using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EFCode_First
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Departments",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Departments", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Employees",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
