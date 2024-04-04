using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{


    public class FiyatlarController : Controller
    {

        private AcademyContext db = new AcademyContext();

        // GET: Admin/Fiyatlar
        public ActionResult Index()
        {
            var model = db.Users.ToList();

            return View(model);
        }

        public ActionResult Guncelle()
        {
            return View();
        }
        // POST: Admin/Reservs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guncelle([Bind(Include = "baslangic, profosyonel,premium,baslangicfiyat,premiumfiyat, profosyonelfiyat , onikiaylık, biraylık, üçaylık ," +
            " altıaylık ,biraylıkfiyat , üçaylıkfiyat , altıaylıkfiyat, onikiaylıkfiyat")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users);
        }



        [HttpPost]
        public ActionResult Delete(int id)
        {
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }

            db.Users.Remove(users);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
      
     
        //public ActionResult Sil(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Users users = db.Users.Find(id);
        //    if (users == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(users);
        //}

        // POST: Admin/Userss/Sil/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilConfirmed(int id)
        {
            Users users = db.Users.Find(id);
            db.Users.Remove(users);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

     
        public ActionResult Sil(int id,int type)
        {
            Users user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            switch (type)
            {
                case 1:
                    user.BaslangicFiyat ="";
                    break;
                case 2:
                    user.PremiumFiyat = "";
                    break; 
                case 3:
                    user.ProfosyonelFiyat = "";

                    break; 
                case 4:
                    user.BirAylıkFiyat = "";

                    break; 
                case 5:
                    user.ÜçAylıkFiyat = "";

                    break;
                case 6:
                    user.AltıAylıkFiyat = "";

                    break;
                case 7:
                    user.OnİkiAylıkFiyat = "";
                    break;

            }
            db.Users.Remove(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}


//public actionresult sil(int? id)
//{
//    if (id == null)
//    {
//        return new httpstatuscoderesult(httpstatuscode.badrequest);
//    }
//    users users = db.users.find(id);
//    if (users == null)
//    {
//        return httpnotfound();
//    }
//    return view(users);
//}

//[httppost]
//[validateantiforgerytoken]
//public actionresult sil(int id)
//{
//    users users = db.users.find(id);
//    db.users.remove(users);
//    db.savechanges();
//    return redirecttoaction("ındex");
//}
//        public ActionResult Sil(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Users users = db.Users.Find(id);
//            if (users == null)
//            {
//                return HttpNotFound();
//            }
//            return View(users);
//        }

//        [HttpPost, ActionName("Sil")]
//        [ValidateAntiForgeryToken]
//        public ActionResult SilConfirmed(int id)
//        {
//            Users users = db.Users.Find(id);
//            db.Users.Remove(users);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }
//public ActionResult Sil()
//{
//    return View();
//}
//public ActionResult Sil(int? id)
//{
//    if (id == null)
//    {
//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//    }
//    Users users = db.Users.Find(id);
//    if (users == null)
//    {
//        return HttpNotFound();
//    }
//    return View(users);
//}
//[HttpPost, ActionName("Sil")]
//[ValidateAntiForgeryToken]
//public ActionResult Silme(int id)
//{
//    Users users = db.Users.Find(id);
//    db.Users.Remove(users);
//    db.SaveChanges();
//    return RedirectToAction("Index");
//}
//[HttpGet]
//public ActionResult Guncelle(int? id)
//{
//    if (id == null)
//    {
//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//    }

//    Users users = db.Users.Find(id);

//    if (users == null)
//    {
//        return HttpNotFound();
//    }

//    // Make sure to populate a ViewModel or your actual user properties
//    // to properly handle the editing of the data
//    Users usersViewModel = new Users
//    {

//        BaslangicFiyat = users.BaslangicFiyat,
//        PremiumFiyat = users.PremiumFiyat,
//        ProfosyonelFiyat = users.ProfosyonelFiyat
//    };

//    return View(usersViewModel);
//}

//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Guncelle(Users updatedUsers)
//{
//    // Make sure to verify the model state
//    if (ModelState.IsValid)
//    {
//        // Load the existing user
//        Users existingUser = db.Users.Find(updatedUsers.BaslangicFiyat, updatedUsers.PremiumFiyat, updatedUsers.ProfosyonelFiyat);

//        // Update the user properties
//        existingUser.BaslangicFiyat = updatedUsers.BaslangicFiyat;
//        existingUser.PremiumFiyat = updatedUsers.PremiumFiyat;
//        existingUser.ProfosyonelFiyat = updatedUsers.ProfosyonelFiyat;

//        // Make sure to save the changes
//        db.SaveChanges();

//        // Pass information back to the user
//        TempData["EditSuccess"] = "User updated successfully!";

//        return RedirectToAction("Index");
//    }

//    return View(updatedUsers);
//}
// GET: Admin/Reservs/Create