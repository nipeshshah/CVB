using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVB.Controllers
{
    public class VacancyController : Controller
    {
        // GET: Vacancy
        public ActionResult Index()
        {
            return View();
        }
    }
}