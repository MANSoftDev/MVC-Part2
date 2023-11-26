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
using System.Collections.Generic;

namespace Mvc.Models
{
    /// <summary>
    /// Partial class to extend functionality of class created by Linq to SQL
    /// </summary>
    public partial class MusicDataContext
    {
        /// <summary>
        /// Get artist by the given ID
        /// </summary>
        /// <param name="id">ID of artist to find</param>
        /// <returns><seealso cref="Artist"/> matching given ID</returns>
        public Artist GetArtistById(int id)
        {
            return Artists.Single(a => a.id == id);
        }

        /// <summary>
        /// Get list of artists 
        /// </summary>
        /// <param name="letter">Beginning letter of artists to find</param>
        /// <returns>Collection of <seealso cref="Artist"/> matching given letter</returns>
        public List<Artist> GetArtists(string letter)
        {
            return Artists.Where(a => string.Compare(a.name[0].ToString(), letter, true) == 0 ? true : false).ToList();
        }

        /// <summary>
        /// Get album by the given ID
        /// </summary>
        /// <param name="id">ID of album to find</param>
        /// <returns><seealso cref="Album"/> matching given ID</returns>
        public Album GetAlbumById(int id)
        {
            return Albums.Single(a => a.id == id);
        }

        /// <summary>
        /// Get albums for the given artist
        /// </summary>
        /// <param name="id">ID of artist to find albums for</param>
        /// <returns>Collection of <seealso cref="Album"/> matching artist's ID</returns>
        public List<Album> GetAlbumsForArtist(int id)
        {
            return Albums.Where(a => a.artist_id == id).ToList();
        }

        /// <summary>
        /// Get albums for the given artist
        /// </summary>
        /// <param name="id">ID of artist to find albums for</param>
        /// <returns>Collection of <seealso cref="Album"/> matching artist's ID</returns>
        public List<Album> GetAlbumsForArtistByName(string name)
        {
            return Albums.Where(a => a.Artist.name == name).ToList();
        }

        /// <summary>
        /// Get songs for the given album
        /// </summary>
        /// <param name="id">ID of album to find songs for</param>
        /// <returns>Collection of <seealso cref="Song"/> matching albums's ID</returns>
        public List<Song> GetSongsForAlbum(int id)
        {
            return Songs.Where(s => s.album_id == id).ToList();
        }
    }

}
