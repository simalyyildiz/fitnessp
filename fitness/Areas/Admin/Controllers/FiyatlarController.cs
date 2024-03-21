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
    }
}