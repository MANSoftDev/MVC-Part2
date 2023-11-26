using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Mvc.Models;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mvc.Views.Music
{
    public partial class Albums : ViewPage<List<Album>>
    {
        protected override void OnLoad(EventArgs e)
        {
            AddMenu();

            ArtistName.Text = ViewData["Name"].ToString();
            AlbumList.DataSource = ViewData.Model;
            AlbumList.DataBind();
        }

        /// <summary>
        /// Create a simple alphabetic menu for navigation
        /// </summary>
        private void AddMenu()
        {
            // Build alphabetic menu
            for(char c = 'A'; c <= 'Z'; c++)
            {
                string link = Html.ActionLink(c.ToString(), "Artists", new RouteValueDictionary(new { controller = "Music", id = c.ToString() }));

                Menu.Controls.Add(new LiteralControl(link));
                // Add seperator
                if(c != 'Z')
                    Menu.Controls.Add(new LiteralControl(" | "));
            }
        }
    }
}
