using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Model;
using MvcMusicStore.Service;

namespace MvcMusicStore.Controllers
{
    public class StoreManagerController : Controller
    {
        // GET: StoreManager
        public ActionResult Index()
        {

            AlbumService albumService = new AlbumService();
            List<Album> albums = albumService.GetAll();


            return View(albums);
        }

        public ActionResult Details(int id)
        {
            AlbumService albumService = new AlbumService();
            Album album = albumService.Get(id);
            return View(album);
        }
    }
}