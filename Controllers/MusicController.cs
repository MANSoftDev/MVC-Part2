using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class MusicController : Controller
    {
        public MusicController()
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

        public ActionResult ArtistsByLetter(string letter)
        {
            return View("Artists", DataContext.GetArtists(letter));
        }

        /// <summary>
        /// Action for displaying albums
        /// </summary>
        /// <param name="id">ID of artist</param>
        public ActionResult Albums(int id)
        {
            ViewData["Name"] = DataContext.GetArtistById(id).name;
            return View(DataContext.GetAlbumsForArtist(id));
        }

        /// <summary>
        /// Action for displaying songs
        /// </summary>
        /// <param name="id">ID of album</param>
        public ActionResult Songs(int id)
        {
            ViewData["Name"] = DataContext.GetAlbumById(id).name;
            return View("Songs", DataContext.GetSongsForAlbum(id));
        }

        #region Properties

        private MusicDataContext DataContext { get; set; }

        #endregion
    }
}
