using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Controllers
{
    public class EkipController : Controller
    {

        private AcademyContext db = new AcademyContext();

        // GET: Ekip
        public ActionResult Ekip()
        {
            var classes = db.Classes.ToList();

            if (classes == null || !classes.Any())
            {
                return HttpNotFound();
            }
            return View(classes);
        }


        public ActionResult Edit(int id)
        {

            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Classes classes)
        {
            if (ModelState.IsValid)
            {
                Classes editEkip = db.Classes.Find(classes.id);
                editEkip.Title = classes.Title;
                editEkip.Title2 = classes.Title2;
                editEkip.Title3 = classes.Title3;
                editEkip.ImgUrl1 = classes.ImgUrl1;
                editEkip.ImgUrl2 = classes.ImgUrl2;
                editEkip.ImgUrl3 = classes.ImgUrl3;
                editEkip.Description1 = classes.Description1;
                editEkip.Description2 = classes.Description2;
                editEkip.Description3 = classes.Description3;
                editEkip.PopulerTitle = classes.PopulerTitle;

                db.SaveChanges();
                return RedirectToAction("ekip");
            }
            return View(classes);
        }
    }
}