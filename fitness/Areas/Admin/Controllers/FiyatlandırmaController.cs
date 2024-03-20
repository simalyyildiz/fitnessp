using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using fitness.Models; // Kullanıcı modelinizi kullanmak için gerekli olan using ifadesi

namespace fitness.Areas.Admin.Controllers
{
    public class FiyatlandırmaController : Controller
    {
        private AcademyContext _context; // Veritabanı bağlantısı için gerekli olan context nesnesi

        public FiyatlandırmaController(AcademyContext context)
        {
            _context = context;
        }

        // GET: Admin/Fiyatlandırma
        public ActionResult Index()
        {
            var users = _context.Users.ToList(); // Tüm kullanıcıları veritabanından alın
            return View(users); // Kullanıcıları görünüme gönderin
        }

        // GET: Admin/Fiyatlandırma/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id); // Kullanıcıyı Id'ye göre alın
            if (user == null)
            {
                return HttpNotFound(); // Kullanıcı bulunamadıysa 404 hatası döndür
            }
            return View(user); // Kullanıcıyı düzenleme görünümüne gönderin
        }

        // POST: Admin/Fiyatlandırma/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Users users)
        {
            if (ModelState.IsValid)
            {
                // ModelState doğrulaması başarılıysa kullanıcıyı güncelle
                _context.Entry(users).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(users); // ModelState doğrulaması başarısız ise kullanıcıyı düzenleme görünümüne geri dön
        }

        // Diğer işlemler buraya eklenebilir
    }
}
