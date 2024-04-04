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

        AcademyContext context = new AcademyContext();
        private AcademyContext db = new AcademyContext();
        // GET: Admin/Kayıt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kayıt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayıt(Users users)
        {
            if (db.Users.Any(x => x.FullName == users.FullName))
            {
                ViewBag.Notigication = "Hesabınız tamamlanmıştır";
                return View();
            }
            else
            {
                db.Users.Add(users);
                db.SaveChanges();

                Session["FullName"] = users.FullName.ToString();
                Session["Phone"] = users.Phone.ToString();
                Session["Email"] = users.Email.ToString();
                Session["Password"] = users.Password.ToString();

                return RedirectToAction("Giris", "Home");
            }
        }


    }
}