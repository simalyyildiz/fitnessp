using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Controllers
{

    public class ContactController : Controller
    {
        AcademyContext db = new AcademyContext();

        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
        // POST: /Contact/ContactModel
        [HttpPost]
        public ActionResult Contact(Contact contactModel)
        {
            if (contactModel is null)
            {
                return View(contactModel);
            }

            db.Contacts.Add(contactModel);
            db.SaveChanges();
            return RedirectToAction("Contact");
        }
    }
}