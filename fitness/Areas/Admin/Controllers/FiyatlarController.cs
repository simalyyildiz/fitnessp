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
    [Authorize]

    public class FiyatlarController : Controller
    {
        private AcademyContext db = new AcademyContext();

        // GET: Admin/Fiyatlar
        public ActionResult Index()
        {
            var model = db.Users.ToList();

            return View(model);
        }

        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult Silme(int id)
        {
            Users users = db.Users.Find(id);
            db.Users.Remove(users);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Users users = db.Users.Find(id);

            if (users == null)
            {
                return HttpNotFound();
            }

            // Make sure to populate a ViewModel or your actual user properties
            // to properly handle the editing of the data
            Users usersViewModel = new Users
            {

                BaslangicFiyat = users.BaslangicFiyat,
                PremiumFiyat = users.PremiumFiyat,
                ProfosyonelFiyat = users.ProfosyonelFiyat
            };

            return View(usersViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guncelle(Users updatedUsers)
        {
            // Make sure to verify the model state
            if (ModelState.IsValid)
            {
                // Load the existing user
                Users existingUser = db.Users.Find(updatedUsers.BaslangicFiyat, updatedUsers.PremiumFiyat, updatedUsers.ProfosyonelFiyat);

                // Update the user properties
                existingUser.BaslangicFiyat = updatedUsers.BaslangicFiyat;
                existingUser.PremiumFiyat = updatedUsers.PremiumFiyat;
                existingUser.ProfosyonelFiyat = updatedUsers.ProfosyonelFiyat;

                // Make sure to save the changes
                db.SaveChanges();

                // Pass information back to the user
                TempData["EditSuccess"] = "User updated successfully!";

                return RedirectToAction("Index");
            }

            return View(updatedUsers);
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using fitness.Models;
//namespace fitness.Areas.Admin.Controllers
//{
//    [Authorize]

//    public class FiyatlarController : Controller
//    {
//        private AcademyContext db = new AcademyContext();        // GET: Admin/Fiyatlar
//        public ActionResult Index()
//        {

//            var model = db.Users.ToList();

//            return View(model);
//        }
//        public ActionResult Delete(int? id)
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

//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Users users = db.Users.Find(id);
//            db.Users.Remove(users);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }
