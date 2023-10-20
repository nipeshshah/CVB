using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBHandler.Database;
using Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using CVB.Models;

namespace CVB.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginSuccess(string returnUrl)
        {
            var userId = User.Identity.GetUserId();
            var model = new IndexViewModel
            {
                Email = new DBHandler.Database.dbresumebuilderEntities().AspNetUsers.Where(t => t.Id == userId).First().Email,
                MemberId = new Helpers.Helper().security.EncryptString(userId.ToString()),
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        

        public ActionResult ProfilePic()
        {
            return View();
        }
        public ActionResult PersonalInfo()
        {

            return View();
        }
        public ActionResult Language()
        {
            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
        public ActionResult Qualification()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Skills()
        {
            return View();
        }
        public ActionResult Certification()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult PublicProfile()
        {
            return View();
        }
        public ActionResult Patents()
        {
            return View();
        }
        public ActionResult Copyrights()
        {
            return View();
        }
        public ActionResult Awards()
        {
            return View();
        }
        public ActionResult Hobbies()
        {
            return View();
        }
    }
}