using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebTestJavaScriptsRoute
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
               name: "JavaScripts",
                   //url: "{controller}/{action}/{id}",
                   url: "{*.}",
               defaults: new { controller = "Home", action = "HomeTwo", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "IndexTwo", id = UrlParameter.Optional }
            );
        }
    }
}
