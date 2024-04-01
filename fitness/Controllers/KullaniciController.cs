using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Controllers
{
    public class KullaniciController : Controller
    {
        AcademyContext context = new AcademyContext();

        // GET: Kullanici
        public ActionResult Kullanici()
        {
            return View();
        }

        // POST: /User/Kullanici
        [HttpPost]
        public ActionResult Kullanici(string fullname, string email, string phone, string password, string paket, string qrcode, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat)
        {
            Users user = new Users()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                Paket = paket,
                QRCode = qrcode,
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
    }
}