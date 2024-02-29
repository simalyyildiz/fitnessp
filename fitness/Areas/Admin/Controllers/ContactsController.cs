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
    public class ContactsController : Controller
    {
        private AcademyContext db = new AcademyContext();

        // GET: Admin/Contacts
        public ActionResult Index()
        {
            return View(db.Contacts.FirstOrDefault());
        }

        // GET: Admin/Contacts/Details/5

        // GET: Admin/Contacts/Edit/5
        public ActionResult Edit(int id)
        {

            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Admin/Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                Contact editContact = db.Contacts.Find(contact.Id);
                editContact.Title = contact.Title;
                editContact.Email = contact.Email;
                editContact.Phone = contact.Phone;

                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(contact);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}