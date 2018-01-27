using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // The order of custom routes here is most important. The default route should be kept 
            // last. In general routing moves from more specific to more generic. Generating routes
            // in this way is legacy way of doing. MVC5 came up with attributed routing which is
            // more clear way of defining routs. lets see it.

            //Lets enable attributed routing. This is done within controller.
            routes.MapMvcAttributeRoutes();

            ////Add custom route to map custom request like movies/released/year/month
            //routes.MapRoute("MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "movies", action = "ByReleaseDate" },
            //    //We can add contraints to parameters like year should be 4 digits and
            //    //month should be 2 digits.
            //    new {year=@"\d{4}",month=@"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
