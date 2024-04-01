using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace fitness.Controllers
{
    public class ContactController : Controller
    {
        AcademyContext context = new AcademyContext();

        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        // POST: /Home/Contact
        [HttpPost]
        public ActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(model);
                context.SaveChanges();
                return RedirectToAction("ContactConfirmation");
            }

            return View(model);
        }

        public ActionResult ContactConfirmation()
        {
            return View();
        }

    }
}