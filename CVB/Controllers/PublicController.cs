using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVB.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public
        [Route("public/{username}/cv/{publicurl}")]
        public ActionResult Index(string username, string publicurl)
        {

            return View();
        }
    }
}