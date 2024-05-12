using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Areas.Admin.Controllers
{
    public class KayıtController : Controller
    {
        AcademyContext entity = new AcademyContext();
        AcademyContext context = new AcademyContext();
        private AcademyContext db = new AcademyContext();
        // GET: Admin/Kayıt

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Users userinfo)
        {
            entity.Users.Add(userinfo);
            entity.SaveChanges();
            return RedirectToAction("Signup");
        }

    }
}

 