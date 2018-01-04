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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Batiments()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Wiki()
        {
            ViewBag.Message = "test";

            return View();
        }
    }
}