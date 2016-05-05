﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        /* public static void RegisterRoutes(RouteCollection routes)
         {
             // Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
             //routes.Add("MyRoute", myRoute);
             routes.MapRoute("shopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });
             routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });
             routes.MapRoute("", "X{controller}/{action}");
             routes.MapRoute("MyRoute", "{Controller}/{action}", new { controller = "Home", action = "Index" });


            routes.MapRoute("", "public/{controller}/{action}",
                 new {controller="Home" ,action="Index"});
         }*/

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", Id = UrlParameter.Optional});
        }
    }
}