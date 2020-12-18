using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppDemo1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "thunder",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Thunder", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "myview",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "MyView", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "multiple",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Multiple", id = UrlParameter.Optional }
            );
        }
    }
}
