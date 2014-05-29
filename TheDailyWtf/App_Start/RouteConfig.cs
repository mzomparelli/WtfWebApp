﻿using System.Web.Mvc;
using System.Web.Routing;

namespace TheDailyWtf
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NewArticle",
                url: "admin/new-article",
                defaults: new { controller = "Admin", action = "CreateArticle" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "Search",
                url: "search",
                defaults: new { controller = "Home", action = "Search" }
            );

            routes.MapRoute(
                name: "ViewArticle",
                url: "articles/{articleSlug}",
                defaults: new { controller = "Articles", action = "ViewArticle" }
            );

            routes.MapRoute(
                name: "ViewArticlesByMonth",
                url: "articles/{year}/{month}",
                defaults: new { controller = "Articles", action = "ViewArticlesByMonth" }
            );

            routes.MapRoute(
                name: "ViewArticlesBySeries",
                url: "series/{series}",
                defaults: new { controller = "Articles", action = "ViewArticlesBySeries" }
            );

            routes.MapRoute(
                name: "ViewArticlesBySeriesAndMonth",
                url: "series/{year}/{month}/{series}",
                defaults: new { controller = "Articles", action = "ViewArticlesBySeriesAndMonth" }
            );

            routes.MapRoute(
                name: "ViewAuthor",
                url: "authors/{authorSlug}",
                defaults: new { controller = "Authors", action = "ViewAuthor" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}