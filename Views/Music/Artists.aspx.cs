using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Mvc.Models;
using System.Web.Routing;

namespace Mvc.Views.Music
{
    public partial class Artists :  ViewPage< List<Artist> >  //ViewPage 
    {
        protected override void OnLoad(EventArgs e)
        {
            // Create the menu
            AddMenu();

            ArtistList.DataSource = ViewData.Model;
            // With the loosely coupled object collection, ViewData needs
            // to cast
            //ArtistList.DataSource = (List<Artist>)ViewData.Model;
            ArtistList.DataBind();
        }

        /// <summary>
        /// Create a simple alphabetic menu for navigation
        /// </summary>
        private void AddMenu()
        {
            // Build alphabetic menu
            for(char c = 'A'; c <= 'Z'; c++)
            {
                string link3 = Html.RouteLink(c.ToString(), new RouteValueDictionary(new { letter = c.ToString() }));
                string link2 = Html.ActionLink(c.ToString(), "ByName", "ByNameCotroller");
                //string link2 = Html.RouteLink(c.ToString(), "ArtistRoute", new RouteValueDictionary(new { controller = "Music", letter = c.ToString() }));

                string link = Html.ActionLink(c.ToString(), "Artists", new RouteValueDictionary( new { controller = "Music", id = c.ToString() }) );

                Menu.Controls.Add(new LiteralControl(link));
                // Add seperator
                if(c != 'Z')
                    Menu.Controls.Add(new LiteralControl(" | "));
            }
        }
    }
}
