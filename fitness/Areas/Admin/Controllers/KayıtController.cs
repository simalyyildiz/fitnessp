using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fitness.Areas.Admin.Controllers
{
    public class KayıtController : Controller
    {
        // GET: Admin/Kayıt
        public ActionResult Index()
        {
            return View();
        }
    }
}