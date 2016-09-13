using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VideoVerhuur.Services;
using MVC_VideoVerhuur.Models;

namespace MVC_VideoVerhuur.Controllers
{
    public class VerhuurController : Controller
    {
        private VideoService db = new VideoService();
        // GET: Verhuur        

        public ActionResult AddToBasket(int id)
        {
            if (Session["klant"] != null)
            {
                var film = db.GetFilmById(id);
                Session[id.ToString()] = film;
                return RedirectToAction("Basket");
            }
            else
                return RedirectToAction("Index", "Home");
        }
        public ActionResult Basket()
        {
            if (Session["klant"] != null)
            {
                int filmId;
                var films = new List<Film>();
                foreach (var item in Session.Keys)
                {
                    if (int.TryParse((string)item, out filmId))
                    {
                        films.Add(db.GetFilmById(filmId));
                    }
                }
                return View(films);
            }
            else
                return RedirectToAction("Index", "Home");
        }
        public ActionResult DeleteFromBasket(int id)
        {
            if (Session["klant"] != null)
            {
                var film = db.GetFilmById(id);
                return View(film);
            }
            else
                return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult ExecuteDelete(int id)
        {
            if (Session["klant"] != null)
            {
                Session.Remove(id.ToString());
                return RedirectToAction("Basket");
            }
            else
                return RedirectToAction("Index", "Home");
        }
        public ActionResult Afrekenen()
        {
            if (Session["klant"] != null)
            {
                int filmId;
                List<Film> films = new List<Film>();
                var klant = (Klant)(Session["klant"]);
                foreach (var item in Session.Keys)
                {
                    if (int.TryParse(item.ToString(), out filmId))
                    {
                        films.Add(db.GetFilmById(filmId));
                        db.RentMovie(filmId, klant.KlantNr);
                    }
                }

                ViewBag.Klant = klant;
                Session.Clear();
                return View(films);
            }
            else
                return RedirectToAction("Index", "Home");
        }
    }
}