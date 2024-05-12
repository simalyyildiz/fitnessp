using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Controllers
{
    public class AboutController : Controller
    {
        AcademyContext context = new AcademyContext();
        private AcademyContext db = new AcademyContext();

        public ActionResult About()
        {
            var abouts = db.Abouts.ToList();

            if (abouts == null || !abouts.Any())
            {
                return HttpNotFound();
            }
            return View(abouts);

        }
        public ActionResult Edit(int id)
        {

            Abouts abouts = db.Abouts.Find(id);
            if (abouts == null)
            {
                return HttpNotFound();
            }
            return View(abouts);
        }

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
                return RedirectToAction("about");
            }
            return View(abouts);
        }
    }
}
