using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using fitness.Models;

namespace fitness.Controllers
{
 
    public class UsersController : Controller
    {
        AcademyContext entity = new AcademyContext();
        // GET: Users
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Users credantials)
        {
            bool userExist = entity.Users.Any(x => x.Email == credantials.Email && x.Password == credantials.Password);
            Users u = entity.Users.FirstOrDefault(x => x.Email == credantials.Email && x.Password == credantials.Password);

            if (userExist)
            {
                FormsAuthentication.SetAuthCookie(u.Email, false);
                return RedirectToAction("Giris", "Giris");

            }
            ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış.");
            return View();

        }
        [HttpPost]
        public ActionResult Signup(Users userinfo)
        {
            entity.Users.Add(userinfo);
            entity.SaveChanges();
            return RedirectToAction("Login");
        }
        public ActionResult User()
        {
            return View();
        }
    }
}