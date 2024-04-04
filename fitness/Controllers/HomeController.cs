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
        private AcademyContext db = new AcademyContext();

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
        //   [HttpPost]

        //public ActionResult Contact(string title, string email, string phone, string message)
        //{
        //    Contact contact = new Contact
        //    {
        //        Title = title,
        //        Email = email,
        //        Phone = phone,
        //        Description = message
        //    };
        //    context.Contacts.Add(contact);
        //    context.SaveChanges();
        //    Contact contacts = context.Contacts.FirstOrDefault();
        //    return View("Contact", contacts);


        //}
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

        public ActionResult Ekip()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Fiyat()
        {
           
            var fiyatlar = context.Users.FirstOrDefault(); 

            if (fiyatlar != null)
            {
                return View(fiyatlar);
            }
            else
            {
                ViewBag.ErrorMessage = "Fiyat bilgisi bulunamadı.";
                return View();
            }
        }




        public ActionResult Fiyat(DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string premiumfiyat, string profosyonelfiyat)
        {
            Users users = new Users()
            {
                Baslangic = baslangic,
                Premium = premium,
                Profosyonel = profosyonel,
                BaslangicFiyat = baslangicfiyat,
                PremiumFiyat = premiumfiyat,
                ProfosyonelFiyat = profosyonelfiyat,
            };
            return View(users);
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
        [HttpPost]
         public ActionResult Users(string fullname, string email, string phone, string password, string paket, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat /*DateTime? baslangicfiyat, DateTime? premiumfiyat, DateTime? profosyonelfiyat*/)
        {
        //   if (baslangic == null || premium == null || profosyonel == null || baslangicfiyat == null || premiumfiyat == null || profosyonelfiyat == null)
        // {
        //// Eksik parametreler olduğunda hatayı işleyin
        //    return View(); // Hata sayfasına yönlendirme yapabilirsiniz
        // }

        Users users = new Users()
       {
        FullName = fullname,
        Email = email,
        Phone = phone,
        Password = password,
        Paket = paket,
        Baslangic = baslangic.Value,
        Premium = premium.Value,
        Profosyonel = profosyonel.Value,
        BaslangicFiyat = baslangicfiyat,
        PremiumFiyat = premiumfiyat,
        ProfosyonelFiyat = profosyonelfiyat,
        //BaslangicFiyat = baslangicfiyat.Value.ToString("yyyy-MM-dd") + " 3000",
        //PremiumFiyat = premiumfiyat.Value.ToString("yyyy-MM-dd") + " 4500", 
        //ProfosyonelFiyat = profosyonelfiyat.Value.ToString("yyyy-MM-dd") + " 5200"
       };
      context.Users.Add(users);
      context.SaveChanges();
      Users users1 = context.Users.FirstOrDefault();
      return View(users1);
       }

        //    public ActionResult Kullanici(string fullname, string email, string phone, string password, string paket, string qrcode, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat)
        //    {
        //        // Kodunuz buraya gelecek


        //        // Veritabanından kullanıcıları alın
        //        Users users = new Users()
        //        {
        //            FullName = fullname,
        //            Email = email,
        //            Phone = phone,
        //            Password = password,
        //            Paket = paket,
        //            QRCode = qrcode,
        //            Baslangic = baslangic,
        //            Premium = premium,
        //            Profosyonel = profosyonel,
        //            BaslangicFiyat = baslangicfiyat,
        //            PremiumFiyat = premiumfiyat,
        //            ProfosyonelFiyat = profosyonelfiyat,
        //            //BaslangicFiyat = baslangicfiyat.HasValue ? baslangicfiyat.Value.ToString("yyyy-MM-dd") + " 3000" : null,
        //            //PremiumFiyat = premiumfiyat.HasValue ? premiumfiyat.Value.ToString("yyyy-MM-dd") + " 4500" : null,
        //            //ProfosyonelFiyat = profosyonelfiyat.HasValue ? profosyonelfiyat.Value.ToString("yyyy-MM-dd") + " 5200" : null

        //        };

        //        return View(users); // Kullanıcıları görünüme gönderin
        //    }
        //    public ActionResult Giris()
        //    {
        //        var user = new Users
        //        {
        //            FullName = "John Doe",
        //            Paket = "Gold", 
        //            QRCode = "123456" 
        //        };

        //        return View(user);
        //    }

        //    [HttpPost]

        //    public ActionResult Kayit(string fullname, string email, string phone, string password, string paket, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat)
        //    {

        //        Users users = new Users()
        //        {
        //            FullName = fullname,
        //            Email = email,
        //            Phone = phone,
        //            Password = password,
        //            Paket = paket,
        //            Baslangic = baslangic,
        //            Premium = premium,
        //            Profosyonel = profosyonel,
        //            BaslangicFiyat = baslangicfiyat,
        //            PremiumFiyat = premiumfiyat,
        //            ProfosyonelFiyat = profosyonelfiyat,
        //        };
        //        context.Users.Add(users);
        //        context.SaveChanges();
        //        Users users1 = context.Users.FirstOrDefault();
        //        return View(users1);
        //    }


        // GET: /User/Kullanici
        //[HttpPost]
        //public ActionResult Kullanici(string fullname, string email, string phone)
        //{
        //    var user = context.Users.FirstOrDefault(u => u.FullName == fullname && u.Email == email && u.Phone == phone);

        //    if (user != null)
        //    {
        //        return RedirectToAction("Giris", "Home");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "Girilen bilgilere sahip bir kullanıcı bulunamadı.");
        //        return View();
        //    }
        //}



        public ActionResult Kullanici()
        {
            Session.Clear();
            return RedirectToAction("Giris" , "Home");
        }


        [HttpGet]
        public ActionResult Kullanicii()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Kullanici( Users users)
        {
            var checkLogin = db.Users.Where(x => x.FullName.Equals(users.FullName) && x.Password.Equals(users.Password)).FirstOrDefault();
        if (checkLogin != null)
            {
                Session["FullName"] = users.FullName.ToString();
                Session["Password"] = users.Password.ToString();
                return RedirectToAction("Giris ", "Home");
            }
        else
            {
                ViewBag.Notification = "Kullanıcı Bilgileri Hatalı";
            }
            return View();
        }

        // POST: /User/Kullanici
        //[HttpPost]
        //public ActionResult Kullanici(string fullname, string email, string phone, string password, string paket, string qrcode, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat)
        //{
        //    Users user = new Users()
        //    {
        //        FullName = fullname,
        //        Email = email,
        //        Phone = phone,
        //        Password = password,
        //        Paket = paket,
        //        QRCode = qrcode,
        //        Baslangic = baslangic,
        //        Premium = premium,
        //        Profosyonel = profosyonel,
        //        BaslangicFiyat = baslangicfiyat,
        //        PremiumFiyat = premiumfiyat,
        //        ProfosyonelFiyat = profosyonelfiyat
        //    };

        //    context.Users.Add(user);
        //    context.SaveChanges();
        //    Users users = context.Users.FirstOrDefault();

        //    return RedirectToAction("Giris", "Home");
        //}

        // GET: /User/Giris
        public ActionResult Giris()
        {
             Users user = new Users
            {
                FullName = " ",
                Paket = "",
                QRCode = ""
            };

            return View(user);
        }


        public ActionResult Kayit()
        {
             return View();
        }

        // POST: /User/Kayit
        [HttpPost]
        public ActionResult Kayit(string fullname, string email, string phone, string password, string paket, DateTime? baslangic, DateTime? profosyonel, DateTime? premium, string baslangicfiyat, string profosyonelfiyat, string premiumfiyat)
        {
             Users user = new Users()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                Paket = paket,
                Baslangic = baslangic,
                Premium = premium,
                Profosyonel = profosyonel,
                BaslangicFiyat = baslangicfiyat,
                PremiumFiyat = premiumfiyat,
                ProfosyonelFiyat = profosyonelfiyat
            };

             context.Users.Add(user);
            context.SaveChanges();

             return View(user);
        }
    }
}

