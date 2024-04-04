using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Controllers
{
    public class GirisController : Controller
    {
        AcademyContext context = new AcademyContext();
        private AcademyContext db = new AcademyContext();
        // GET: Giris
        public ActionResult Giris()
        {
            Users user = new Users
            {
                FullName = "John Doe",
                Paket = "Gold",
                QRCode = "123456"
            };

            return View(user);
        }

        public ActionResult Edit(Users users)
        {
            if (ModelState.IsValid)
            {
                Users editUsers = db.Users.Find(Users.Id);
                editUsers.FullName = users.FullName;
                editUsers.Email = users.Email;
                editUsers.Phone = users.Phone;
                editUsers.Paket = users.Paket;
                editUsers.Adres = users.Adres;
                editUsers.Baslangic = users.Baslangic;
                editUsers.Profosyonel = users.Profosyonel;
                editUsers.Premium = users.Premium;
                editUsers.BirAylık = users.BirAylık;
                editUsers.ÜçAylık = users.ÜçAylık;
                editUsers.AltıAylık = users.AltıAylık;
                editUsers.Onİki_Aylık = users.Onİki_Aylık;

                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(users);
        }
        public ActionResult Zaman()
        {
            var user = new List<Users>
    {
        new Users { FullName = "A", Baslangic = DateTime.Parse("2023-01-01"), Profosyonel = DateTime.Parse("2023-01-02"), Premium = DateTime.Parse("2023-01-03") , BirAylık = DateTime.Parse("2023-01-02") , ÜçAylık = DateTime.Parse("2023-01-02") ,  AltıAylık = DateTime.Parse("2023-01-02") ,  Onİki_Aylık = DateTime.Parse("2023-01-02")},
        new Users { FullName = "B", Baslangic = DateTime.Parse("2023-02-01"), Profosyonel = DateTime.Parse("2023-02-02"), Premium = DateTime.Parse("2023-02-03") , BirAylık = DateTime.Parse("2023-01-02") , ÜçAylık = DateTime.Parse("2023-01-02") ,  AltıAylık = DateTime.Parse("2023-01-02") ,  Onİki_Aylık = DateTime.Parse("2023-01-02")}
        // Daha fazla kullanıcı ekleyebilirsiniz
    };

            return View(user);
        }
    }
}