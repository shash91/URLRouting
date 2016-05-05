using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

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
            /* routes.MapRoute("AddControllerRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", Id = UrlParameter.Optional},
                 new[] { "UrlsAndroutes.Additionalcontrollers" });

             routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", Id = UrlParameter.Optional },
                new[] { "UrlsAndroutes.Controllers" });*/

            /*    Route myRoute = routes.MapRoute("AddControllerRoute", "Home/{action}/{id}/{*catchall}",
                    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                    new[] { "UrlsAndroutes.Additionalcontrollers" }
                    );
                myRoute.DataTokens["UseNamespaceFallback"] = false;*/

            //Constraining routes to a specific values
            /*routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new { controller = "^H.*",action="^Index$|^About$" },
                new[] { "UrlsAndroutes.Controllers" });*/


            //Constraining a route using HTTP Methods

            /*   routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                    new { controller = "^H.*", action = "Index|About", httpMethod = new HttpMethodConstraint("GET") },
                    new[] { "UrlsAndroutes.Controllers" });*/

            //using customconstrain

            routes.MapRoute("ChromeRoute", "{*catchall}",

                new { controller = "Home", action = "Index" },
                new
                {
                    customConstraint = new UserAgentConstraint("Chrome")
                },
                new[] { "UrlsAndRoutes.AdditionalControllers" }
                );

            routes.MapRoute("Myroute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new[] { "UrlsAndroutes.Controllers" });

        }
    }
}