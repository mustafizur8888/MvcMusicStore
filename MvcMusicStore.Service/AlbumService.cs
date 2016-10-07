using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MvcMusicStore.Model;


namespace MvcMusicStore.Service
{
    public class AlbumService
    {

        private readonly MusicStoreEntites _db = new MusicStoreEntites();

        public List<Album> GetAll()
        {
            List<Album> albums = _db.Albums.Include(a => a.Genre).Include(a => a.Artist).ToList();
            return albums;
        }

        public Album Get(int id)
        {
            Album album = _db.Albums.Include(a => a.Genre).Include(a => a.Artist).First(a => a.AlbumId == id);
            return album;
        }


    }
}
