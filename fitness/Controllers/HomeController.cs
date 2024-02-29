using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fitness.Controllers
{
    public class HomeController : Controller
    {
        //private  FitnessDbContext context = new FitnessDbContext();
        //private object context;
        AcademyContext context = new AcademyContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string fullname, string email, string message)
        {
            ContactMessage contactMessage = new ContactMessage()
            {

                FullName = fullname,
                Email = email,
                Description = message, 

            };
            context.ContactMessages.Add(contactMessage);
            context.SaveChanges();
            Contact contacts = context.Contacts.FirstOrDefault();
            return View(contacts);
        }
        public ActionResult Ekip()
        {
            return View();
        }
        public ActionResult Fiyat()
        {
            return View();
        }
    }
}