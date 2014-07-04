using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackingBonPutih.Models;

namespace TrackingBonPutih.Controllers
{
    public class ManajemenUserController : Controller
    {
        //
        // GET: /ManajemenUser/
       

        public ActionResult TambahUser()
        {
            trackingEntities context = new trackingEntities();
            IEnumerable<departeman> listDept = from d in context.departemen
                                               select d;

            ViewData["listDept"] = listDept;
            
            return View();
        }

        [HttpPost]
        public ActionResult TambahUser(user userSignUp)
        {
            trackingEntities context = new trackingEntities();
            IEnumerable<departeman> listDept = from d in context.departemen
                                               select d;

            ViewData["listDept"] = listDept;
            return View();
        }

        public ActionResult ListUser()
        {
            return View();
        }
    }
}
