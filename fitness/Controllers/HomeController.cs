using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Ekip()
        {
            return View();
        }
        public ActionResult Fiyat()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult User(string fullname, string email, string phone,string password, string paket)
        //{
        //    //Users users = new Users()
        //    //{
        //    //    FullName = fullname,
        //    //    Email = email,
        //    //    Phone = phone,
        //    //    Password = password,
        //    //    Paket = paket,
        //    //};
        //    //try
        //    //{
        //    //    context.Users.Add(users);
        //    //    context.SaveChanges();
        //    //    Users userss = context.Users.First();
        //    //    return View(users);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //    throw;
        //    //}
        //    return View(users);
        //}
      public ActionResult User(string fullname, string email, string phone, string password, string paket)
        {
            Users users = new Users()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                Paket = paket,
            };
            context.SaveChanges();
           
            return View(users);
        }
        public ActionResult Kullanici()
        {
            return View();
        }
        public ActionResult Giris()
        {
            return View();
        }
    }
}