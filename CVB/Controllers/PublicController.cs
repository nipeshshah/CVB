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
        [Route("public/{templateId}/cv/{publicurl}")]
        public ActionResult Index(int templateId, string publicurl)
        {
            //Get User & Template from Public Url
            //Get Template and User Profile from Url
            //Build Resume and Display
            return View();
        }
    }
}