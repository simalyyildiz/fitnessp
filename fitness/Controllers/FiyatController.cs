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
        private AcademyContext db = new AcademyContext();

        // GET: Admin/Uyeler
        // GET: Admin/Uyeler
        // GET: Admin/Uyeler
        public ActionResult Fiyat()
        {
            IEnumerable<Users> users = context.Users.ToList();
            return View(users); // Fiyat.cshtml görünümüne users listesini gönderin
        }




        // GET: Admin/Contacts/Details/5

        // GET: Admin/Contacts/Edit/5
        public ActionResult Edit(int id)
        {

            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Admin/Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Users users)
        {
            if (ModelState.IsValid)
            {
                Users editUsers = db.Users.Find(Users.Id);
                editUsers.BaslangicFiyat = users.BaslangicFiyat;
                //editUsers.C1Aylık = users.C1Aylık;
                //editUsers.C3Aylık = users.C3Aylık;
                //editUsers.C6Aylık = users.C6Aylık;
                //editUsers.C12Aylık = users.C12Aylık;
                //editUsers.C1Aylık_Fiyat = users.C1Aylık_Fiyat;
                //editUsers.C3Aylık_Fiyat = users.C3Aylık_Fiyat;
                //editUsers.C6Aylık_Fiyat = users.C6Aylık_Fiyat;
                //editUsers.C12Aylık_Fiyat = users.C12Aylık_Fiyat;
                editUsers.PremiumFiyat = users.PremiumFiyat;
                editUsers.ProfosyonelFiyat = users.ProfosyonelFiyat;
                editUsers.Baslangic = users.Baslangic;
                editUsers.Profosyonel = users.Profosyonel;
                editUsers.Premium = users.Premium;


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