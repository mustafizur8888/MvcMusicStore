using System.Collections.Generic;
using System.Linq;
using MvcMusicStore.Model;


namespace MvcMusicStore.Service
{
    public class AlbumService
    {

        private readonly MusicStoreEntites _db = new MusicStoreEntites();

        public List<Album> GetAll()
        {
            List<Album> albums = _db.Albums.ToList();
            return albums;
        }

        public Album Get(int id)
        {
            Album album = _db.Albums.Find(id);
            return album;
        }


    }

    public class GenreService
    {
        private readonly MusicStoreEntites _db = new MusicStoreEntites();

        public List<Genre> GetAll()
        {
            List<Genre> genres = _db.Genres.Include("Albums").ToList();
            return genres;
        }

        public Genre Get(string name)
        {
            Genre genre = _db.Genres.Include("Albums").Single(x => x.Name == name);
            return genre;
        }

    }
}
