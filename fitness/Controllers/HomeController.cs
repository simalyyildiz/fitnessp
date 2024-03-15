﻿using fitness.Models;
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

        //[HttpPost]
        //public ActionResult ContactMessage(string fullname, string email, string message)
        //{
        //    ContactMessage contactMessage = new ContactMessage()
        //    {

        //        FullName = fullname,
        //        Email = email,
        //        Description = message,

        //    };
        //    context.ContactMessages.Add(contactMessage);
        //    context.SaveChanges();
        //    Contact contacts = context.Contacts.FirstOrDefault();
        //    return View(contacts);
        //}
        public ActionResult Contact(string title, string email, string phone, string message)
        {
            // Yeni bir Contact nesnesi oluşturarak gelen değerleri atıyoruz.
            Contact contact = new Contact
            {
                Title = title,
                Email = email,
                Phone = phone,
                Description = message
            };

            try
            {
                // Contact nesnesini veritabanına ekliyoruz.
                context.Contacts.Add(contact);
                context.SaveChanges();

                // Kullanıcı başarıyla eklenmişse, başka bir sayfaya yönlendiriyoruz.
                return RedirectToAction("BasariSayfasi", "ControllerAdi");
            }
            catch (Exception ex)
            {
                // Eğer bir hata oluşursa, hata mesajını göstermek için ViewBag kullanabiliriz.
                ViewBag.ErrorMessage = "Kullanıcı eklenirken bir hata oluştu: " + ex.Message;

                // Hata durumunda kullanıcıyı aynı sayfada tutabiliriz.
                return View();
            }
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
      public ActionResult Users(string fullname, string email, string phone, string password, string paket)
        {
            Users users = new Users()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                Paket = paket,
            };
            context.Users.Add(users);
            context.SaveChanges();
            Users users1 = context.Users.FirstOrDefault();
            return View(users1);
        }

        public ActionResult Kullanici(String email, string password)
        {

            Users users = new Users()
            {
                Email = email,
                Password = password,
            };
            //var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            //if (user != null)
            //{

            //    Session["UserId"] = user.UserId;


            //    return RedirectToAction("Home", "Giris");
            //}
            //else
            //{

            //    ViewBag.ErrorMessage = "Giriş bilgileri hatalı.";
               
            return View();
            //}


        }
        public ActionResult Giris()
        {
            return View();
        }

     }
}

