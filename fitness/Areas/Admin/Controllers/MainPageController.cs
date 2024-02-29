using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fitness.Areas.Admin.Controllers
{
    public class MainPageController : Controller
    {
        // GET: Admin/MainPage
        public ActionResult Index()
        {
            return View();
        }
    }
}