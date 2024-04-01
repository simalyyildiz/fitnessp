using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace fitness.Controllers
{
    public class FiyatController : Controller
    {
        AcademyContext context = new AcademyContext();

        // GET: Fiyat
        public ActionResult Fiyat()
        {

            var fiyatlar = context.Users.FirstOrDefault();

            if (fiyatlar != null)
            {
                return View(fiyatlar);
            }
            else
            {
                ViewBag.ErrorMessage = "Fiyat bilgisi bulunamadı.";
                return View();
            }
        }




        public ActionResult Fiyat(DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string premiumfiyat, string profosyonelfiyat)
        {
            Users users = new Users()
            {
                Baslangic = baslangic,
                Premium = premium,
                Profosyonel = profosyonel,
                BaslangicFiyat = baslangicfiyat,
                PremiumFiyat = premiumfiyat,
                ProfosyonelFiyat = profosyonelfiyat,
            };
            return View(users);
        }
    }
}