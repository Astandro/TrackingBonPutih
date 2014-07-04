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
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            user checkSession = (user)Session["user"];
            if (checkSession == null)
                return RedirectToAction("../Login");
            
            return View();
        }

        public ActionResult Logout()
        {
            user checkSession = (user)Session["user"];
            if (checkSession == null)
                return RedirectToAction("../Login");

            Session["user"] = null;
            return RedirectToAction("../Login");
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
