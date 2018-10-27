using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FortKnox
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "FortKnox.Controllers" }
            );

            routes.MapRoute(
               name: "Area_Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Area", action = "Index", id = UrlParameter.Optional }
               //namespaces: new string[] { "FortKnox.Areas.Procesos.Controllers" }
           );

        }
    }
}
