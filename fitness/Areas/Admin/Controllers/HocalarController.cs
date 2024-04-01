using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{
    public class HocalarController : Controller
    {
        AcademyContext context = new AcademyContext();
        private AcademyContext db = new AcademyContext();
        // GET: Admin/Hocalar



        public ActionResult Index()   
        {
            return View(db.Hocalar);
        }


        // GET: Admin/Contacts/Details/5

        // GET: Admin/Contacts/Edit/5
        public ActionResult Hocalar(string fullname ,  string email , string phone , DateTime dogumtarihi)
        {
            Hocalar hocalar = new Hocalar()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                DogumTarihi = dogumtarihi,
            };
            return View(hocalar);
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