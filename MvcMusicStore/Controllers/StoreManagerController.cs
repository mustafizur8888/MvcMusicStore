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

        private readonly AlbumService _albumService = new AlbumService();
        // GET: StoreManager
        public ActionResult Index()
        {

            List<Album> albums = _albumService.GetAll();
            return View(albums);
        }

        public ActionResult Details(int id)
        {
            Album album = _albumService.Get(id);
            return View(album);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Album album = _albumService.Get(id);
            return View(album);
        }
        [HttpPost]
        public ActionResult Delete(Album model)
        {
            _albumService.Delete(model);
            return RedirectToAction("Index");
        }
    }


    //public ActionResult Create()
    //{
    //    return View();
    //}

}