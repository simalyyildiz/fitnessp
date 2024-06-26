﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{
    public class AnaSayfaAboutController : Controller
    {
        private AcademyContext db = new AcademyContext();

        // GET: Admin/About
        public ActionResult Index()
        {
            return View(db.Abouts.FirstOrDefault(x => x.id == 1));
        }



        // GET: Admin/Abouts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Abouts abouts = db.Abouts.Find(id);
            if (abouts == null)
            {
                return HttpNotFound();
            }
            return View(abouts);
        }

        // POST: Admin/Abouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Abouts abouts)
        {
            if (ModelState.IsValid)
            {
                Abouts editAbout = db.Abouts.Find(abouts.id);
                editAbout.Title = abouts.Title;
                editAbout.Description = abouts.Description;
                editAbout.Image1URL = abouts.Image1URL;
                editAbout.PopularDescription = abouts.PopularDescription;
                editAbout.PopularTitle = abouts.PopularTitle;

                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(abouts);
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
