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
                Classes editUsers = db.Classes.Find(classes.id);
                editUsers.Title = classes.Title;
                editUsers.Title2 = classes.Title2;
                editUsers.Title3 = classes.Title3;
                editUsers.ImgUrl1 = classes.ImgUrl1;
                editUsers.ImgUrl2 = classes.ImgUrl2;
                editUsers.ImgUrl3 = classes.ImgUrl3;
                editUsers.Description1 = classes.Description1;
                editUsers.Description2 = classes.Description2;
                editUsers.Description3 = classes.Description3;
                editUsers.PopulerTitle = classes.PopulerTitle;

                db.SaveChanges();
                return RedirectToAction("ekip");
            }
            return View(classes);
        }
    }
}