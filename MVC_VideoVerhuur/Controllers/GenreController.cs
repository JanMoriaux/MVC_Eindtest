using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VideoVerhuur.Services;

namespace MVC_VideoVerhuur.Controllers
{
    public class GenreController : Controller
    {
        private VideoService db = new VideoService();
        // GET: Genre
        public ActionResult Index()
        {
            if (Session["klant"] != null)
            {
                var alleGenres = db.GenreLijst();
                return View(alleGenres);
            }
            else
                return RedirectToAction("Index", "Home");
        }
        public ActionResult Detail(int id)
        {
            if (Session["klant"] != null)
            {
                var genre = db.GetGenreById(id);
                var films = db.GetFilmsByGenreId(id);
                ViewBag.Genre = genre;
                return View(films);
            }
            else
                return RedirectToAction("Index", "Home");
        }
    }
}