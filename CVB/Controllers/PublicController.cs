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
        [Route("public/{templateId}/cv/{publicUrl}/code/{code}")]
        public ActionResult Index(int templateId, string publicUrl, string code)
        {
            ViewBag.Template = templateId;
            ViewBag.PublicUrl = publicUrl;
            //Get User & Template from Public Url
            //Get Template and User Profile from Url
            //Build Resume and Display
            return View();
        }

        [Route("public/{templateId}/cv/{publicUrl}")]
        public ActionResult PassCodeVerification(string templateId, string publicUrl)
        {
            ViewBag.Template = templateId;
            ViewBag.PublicUrl = publicUrl;
            return View();
        }
    }
}