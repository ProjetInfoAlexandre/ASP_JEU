using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPJEU.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Accueil()
        {
            return View();
        }

        public ActionResult Vaisseaux()
        {
            ViewBag.Message = "La page d'achat des vaisseaux.";

            return View();
        }

        public ActionResult Batiments()
        {
            ViewBag.Message = "La page d'achat des bâtiments";

            return View();
        }

        public ActionResult Wiki()
        {
            ViewBag.Message = "Le wiki pour tout savoir sur ce jeu !";

            return View();
        }
    }
}