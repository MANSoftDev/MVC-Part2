using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc.Models;
using System.Web.Routing;
using System.Web.UI;

namespace Mvc.Views.Music
{
    public partial class Songs : ViewPage<List<Song>>
    {
        protected override void OnLoad(EventArgs e)
        {
            AddMenu();

            AlbumName.Text = ViewData["Name"].ToString();

            SongList.DataSource = ViewData.Model;
            SongList.DataBind();
        }

        /// <summary>
        /// Create a simple alphabetic menu for navigation
        /// </summary>
        private void AddMenu()
        {
            // Build alphabetic menu
            for(char c = 'A'; c <= 'Z'; c++)
            {
                string link = Html.ActionLink(c.ToString(), "Artists", new RouteValueDictionary(new { controller = "Music", letter = c.ToString() }));

                Menu.Controls.Add(new LiteralControl(link));
                // Add seperator
                if(c != 'Z')
                    Menu.Controls.Add(new LiteralControl(" | "));
            }
        }
    }
}
