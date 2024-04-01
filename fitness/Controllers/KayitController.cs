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
        AcademyContext context = new AcademyContext();

        // GET: Kayit
        public ActionResult Kayit()
        {
            Users user = new Users();
            return View(user);
        }

        // POST: /User/Kayit
        [HttpPost]
        public ActionResult Kayit(string fullname, string email, string phone, string password, string paket, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat , string adres, DateTime? dogumtarihi)
        {
            Users user = new Users()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                Paket = paket,
                Adres = adres,
                DogumTarihi = dogumtarihi,
                Baslangic = baslangic,
                Premium = premium,
                Profosyonel = profosyonel,
                BaslangicFiyat = baslangicfiyat,
                PremiumFiyat = premiumfiyat,
                ProfosyonelFiyat = profosyonelfiyat
            };

            context.Users.Add(user);
            context.SaveChanges();

            return View(user);
        }
        [HttpPost]
        public ActionResult Kayit(FormCollection formValues)
        {
            Users user = new Users
            {
                FullName = formValues["FullName"],
                Email = formValues["Email"],
                Phone = formValues["Phone"],
                // Assign other form values here
            };

            context.Users.Add(user);
            context.SaveChanges();

            return View(user);
        }
    }
}