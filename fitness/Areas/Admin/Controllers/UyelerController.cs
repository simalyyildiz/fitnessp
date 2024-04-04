using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{
    public class UyelerController : Controller
    {
        AcademyContext context = new AcademyContext();
        private AcademyContext db = new AcademyContext();

        // GET: Admin/Uyeler
        // GET: Admin/Uyeler
        // GET: Admin/Uyeler
        public ActionResult Index()
        {
            List<Users> users = db.Users.ToList();
            return View(users);
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