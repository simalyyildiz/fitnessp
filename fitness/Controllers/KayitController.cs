using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Controllers
{
    public class KayitController : Controller
    {
        private AcademyContext db = new AcademyContext();

        AcademyContext context = new AcademyContext();

        // GET: Kayit
        //    public ActionResult Kayit()
        //    {
        //        Users user = db.Users.FirstOrDefault(x=>x.id>0);
        //        return View(user);
        //    }

        //    // POST: /User/Kayit
        //    [HttpPost]
        //    public ActionResult Kayit(Users user1)
        //    {
        //        //Users user = new Users()
        //        //{
        //        //    FullName = fullname,
        //        //    Email = email,
        //        //    Phone = phone,
        //        //    Password = password,
        //        //    Paket = paket,
        //        //    Adres = adres,
        //        //    DogumTarihi = dogumtarihi,
        //        //    Baslangic = baslangic,
        //        //    Premium = premium,
        //        //    Profosyonel = profosyonel,
        //        //    BaslangicFiyat = baslangicfiyat,
        //        //    PremiumFiyat = premiumfiyat,
        //        //    ProfosyonelFiyat = profosyonelfiyat,

        //        //};

        //      //  context.Users.Add(user);
        //        context.SaveChanges();
        //        return null;
        //       // return View(user);
        //    }
        //    [HttpPost]
        //    public ActionResult Kayit(FormCollection formValues)
        //    {
        //        Users user = new Users
        //        {
        //            FullName = formValues["FullName"],
        //            Email = formValues["Email"],
        //            Phone = formValues["Phone"],
        //            // Assign other form values here
        //        };

        //        context.Users.Add(user);
        //        context.SaveChanges();

        //        return View(user);
        //    }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(Users users)
        {
            if(db.Users.Any(x=>x.FullName == users.FullName))
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