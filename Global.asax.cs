using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc
{
    public class GlobalApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Handle request for http://www.mysite.com/Artist/U2 
            routes.MapRoute("ArtistByName", "Artist/{name}",
                new { controller = "Artist", action = "AlbumsByArtistName", name = "" },
                new { name = @"[a-zA-Z]{1,}" }
            );

            // Handle request for http://www.mysite.com/Artist/1394 
            routes.MapRoute("ArtistByID", "Artist/{id}",
                new { controller = "Artist", action = "AlbumsByArtistId", id = 0 },
                new { id = @"\d{1,}" }
            );

            // Handle request for http://www.mysite.com/Music/Artist/D 
            routes.MapRoute("ArtistByLetter", "Music/Artists/{letter}",
                new { controller = "Music", action = "ArtistsByLetter", letter = "A" },
                new { letter = @"[a-zA-Z]{1,}" }
            );

            // Handle request for http://www.mysite.com 
            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = 0 }
            );
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
