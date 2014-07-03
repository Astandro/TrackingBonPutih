using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackingBonPutih.Models;

namespace TrackingBonPutih.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user checkLogin)
        {
            trackingEntities context = new trackingEntities();
            if (ModelState.IsValid)
            {
                IEnumerable<user> result = from b in context.users
                                           where b.NPK == checkLogin.NPK && b.PASS == checkLogin.PASS
                                           select b;
            
                if(result.Count() > 0)
                    return View("../Home/Index");
                else
                    ModelState.AddModelError("", "username / password salah");
            
            }
            
            return View(checkLogin);
        }

    }
}
