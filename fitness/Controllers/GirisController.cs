using fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace fitness.Controllers
{
    public class GirisController : Controller
    {
        AcademyContext context = new AcademyContext();

        // GET: Giris
        public ActionResult Giris()
        {
            Users user = new Users
            {
                FullName = "John Doe",
                Paket = "Gold",
                QRCode = "123456"
            };

            return View(user);
        }
    }
}