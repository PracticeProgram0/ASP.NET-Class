using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ROUTERDEMO
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
           // routes.MapRoute(
           //    name: "self",
           //    url: "Demo",
           //    defaults: new { controller = "Default", action = "Index" }
           //);
           // routes.MapRoute(
           //    name: "Routself",
           //    url: "about/{id}",
           //    defaults: new { controller = "Default", action = "about", id = UrlParameter.Optional }
           //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
