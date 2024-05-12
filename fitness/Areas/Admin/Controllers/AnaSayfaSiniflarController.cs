using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{
    public class AnaSayfaSiniflarController : Controller
    {
        private AcademyContext db = new AcademyContext();
        // GET: Admin/AnaSayfaSiniflar
        public ActionResult Index()
        {
            return View(db.Classes.FirstOrDefault(x => x.id == 1));
           
        }

        // GET: Admin/Abouts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }


        // POST: Admin/Abouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Classes classes)
        {
            if (ModelState.IsValid)
            {
                Classes editAbout = db.Classes.Find(classes.id);
                editAbout.Title = classes.Title;
                editAbout.Title2 = classes.Title2;
                editAbout.Title3 = classes.Title3;
                editAbout.Description1 = classes.Description1;
                editAbout.Description2 = classes.Description2;
                editAbout.Description3 = classes.Description3;
                editAbout.ImgUrl1 = classes.ImgUrl1;
                editAbout.ImgUrl2 = classes.ImgUrl2;
                editAbout.ImgUrl3 = classes.ImgUrl3;
                editAbout.jumDescription = classes.jumDescription;
                editAbout.jumTitle = classes.jumTitle;
               
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(classes);
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