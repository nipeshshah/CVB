using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string token)
        {
            //return View();
            if (token != null && User.Identity.IsAuthenticated)
            {
                ViewBag.Token = token;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}