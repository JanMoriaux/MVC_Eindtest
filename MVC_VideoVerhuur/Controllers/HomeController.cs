using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VideoVerhuur.Models;
using MVC_VideoVerhuur.Services;

namespace MVC_VideoVerhuur.Controllers
{
    public class HomeController : Controller
    {
        private KlantService klantDb = new KlantService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var klant = klantDb.GetKlantByNaamAndPostCode(model.Naam, model.PostCode);
                Session["klant"] = klant;
            }
            return View("Index");
        }
        [HttpGet]
        public ActionResult Uitloggen()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}