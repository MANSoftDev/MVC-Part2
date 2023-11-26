using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Mvc;
using Mvc.Models;
using System.Web.Routing;

namespace Mvc.Controllers
{
    public class ArtistController : Controller
    {
        public ArtistController()
        {
            DataContext = new MusicDataContext();
        }

        /// <summary>
        /// Default action for this controller
        /// </summary>
        public ActionResult Index()
        {
            return View("Artists", DataContext.GetArtists("A"));
        }

        /// <summary>
        /// Action for displaying albums for artist
        /// </summary>
        /// <param name="name">Name of artist</param>
        public ActionResult AlbumsByArtistName(string name)
        {
            ViewData["Name"] = name;
            return View("Albums", DataContext.GetAlbumsForArtistByName(name));
        }

        /// <summary>
        /// Action for displaying albums for artist
        /// </summary>
        /// <param name="id">Artist ID</param>
        public ActionResult AlbumsByArtistId(int id)
        {
            if(id == 0)
                return RedirectToRoute("Default", new RouteValueDictionary(new { controller = "Music", action = "Index"}));

            ViewData["Name"] = DataContext.GetArtistById(id).name;
            return View("Albums", DataContext.GetAlbumsForArtist(id));
        }

        #region Properties

        private MusicDataContext DataContext { get; set; }

        #endregion
    }
}
