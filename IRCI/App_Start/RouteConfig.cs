using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IRCI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Artikel", "Artikel/Index/{page}", new { controller = "Artikel", action = "Index", page = 0 }, new { page = @"\d+" });
            routes.MapRoute("CariArtikel", "Artikel/Cari/{filter}/{page}", new { controller = "Artikel", action = "Cari", filter = "wahyuni", page = 0 }, new {filter = @"[a-zA-Z]+", page = @"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
