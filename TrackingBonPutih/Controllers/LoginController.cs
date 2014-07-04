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
            if (Session["user"] != null)
                return RedirectToAction("../Home");

            return View();
        }

        [HttpPost]
        public ActionResult Index(user checkLogin)
        {
            user loginState = null;
            trackingEntities context = new trackingEntities();
            if (ModelState.IsValid)
            {
                IEnumerable<user> result = from b in context.users
                                           where b.NPK == checkLogin.NPK && b.PASS == checkLogin.PASS
                                           select b;
                IEnumerable<pos> listPos = from p in context.pos
                                           select p;
                
                if (result.Count() > 0)
                {
                    foreach (var userLogin in result)
                    {
                        loginState = userLogin;
                    }
                    Session["user"] = loginState;
                    Session["listPos"] = listPos;
                    return RedirectToAction("../Home/Index");;
                }

                else
                    ModelState.AddModelError("", "username / password salah");
            
            }
            
            return View(checkLogin);
        }

    }
}
