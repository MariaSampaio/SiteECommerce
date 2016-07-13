using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteECommerce.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Propos";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Retrouvez-nous";

            return View();
        }
    }
}