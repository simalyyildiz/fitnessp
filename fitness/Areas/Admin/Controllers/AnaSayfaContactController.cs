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
    public class AnaSayfaContactController : Controller
    {      
        AcademyContext db = new AcademyContext();
        // GET: Admin/AnaSayfaContact
        public ActionResult Index()
        {
            var model = db.Contacts.ToList();
            return View();
        }
        public ActionResult Guncelle()
        {
            return View();
        }
        // POST: Admin/Reservs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guncelle([Bind(Include = "title, email, phone, contactmessagetext")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }



        [HttpPost]
        public ActionResult Delete(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }

            db.Contacts.Remove(contact);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Sil(int id, int type)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }

            switch (type)
            {
                case 1:
                    contact.Title = "";
                    break;
                case 2:
                    contact.Email = "";
                    break;
                case 3:
                    contact.Phone = "";

                    break;
                case 4:
                    contact.ContactMessageText = "";
                    break;


            }
            db.Contacts.Remove(contact);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}