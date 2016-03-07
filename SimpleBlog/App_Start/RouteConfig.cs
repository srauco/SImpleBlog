using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            var namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { Controller = "Auth", Action = "Login" },
                namespaces: namespaces
            );

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { Controller = "Posts", action = "index" },
                namespaces: namespaces
            );



        }
    }
}
