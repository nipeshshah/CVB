using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVB.Controllers
{
    [RoutePrefix("CVBuilder")]
    public class CVBuilderController : Controller
    {
        // GET: CVBuilder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Build()
        {
            return View();
        }

        [Route("BuildFinalize/{template}")]
        public ActionResult BuildFinalize(string template)
        {
            if (string.IsNullOrEmpty(template))
            {
                return View("Build");
            }
            ViewBag.Template = template;
            return View();
        }

        public ActionResult Share()
        {
            return View();
        }
    }
}