using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetExam
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{ProductId}",
                defaults: new { controller = "Product", action = "Index", ProductId = UrlParameter.Optional }
            );
        }
    }
}
