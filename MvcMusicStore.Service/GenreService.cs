using System.Collections.Generic;
using System.Linq;
using MvcMusicStore.Model;

namespace MvcMusicStore.Service
{
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