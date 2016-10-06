using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Model;
using MvcMusicStore.Service;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre
                {
                    Name = "Disco"
                },
                new Genre
                {
                    Name ="Jazz"
                },
                new Genre
                {
                    Name = "Rock"
                }
            };
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreService = new GenreService();
            return View(genreService.Get(genre));
        }



        public ActionResult Details(int id)
        {
            var albumService = new AlbumService();
          Album album =   albumService.Get(id);
            return View(album);
        }
    }
}