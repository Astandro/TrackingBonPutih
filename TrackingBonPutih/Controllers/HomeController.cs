using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackingBonPutih.Models;

namespace TrackingBonPutih.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            user checkSession = (user)Session["user"];
            if (checkSession == null)
                return RedirectToAction("../Login/Index");
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
