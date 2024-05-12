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
        AcademyContext db = new AcademyContext();


        // GET: Admin/Contacts
        public ActionResult Index()
        {
            var contacts = db.Contacts.ToList(); // Kullanıcıları alın
            return View(contacts);
        }

    }
}