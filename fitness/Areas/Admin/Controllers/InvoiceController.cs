using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{
    public class InvoiceController : Controller
    {
        AcademyContext context = new AcademyContext();

        // GET: Admin/Invoice
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult MakePayment(PaymentModel model)
        {
            if (ModelState.IsValid)
            {
                // Ödeme işlemleri

                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                // Veritabanına kaydetme işlemi
                using (var context = new AcademyContext())
                {
                    var payment = new PaymentModel
                    {
                        BankName = model.BankName,
                        CardNumber = model.CardNumber,
                        ExpiryDate = model.ExpiryDate,
                        Cvv = model.Cvv
                    };

                    //context.Payments.Add(payment);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

    }

    public class PaymentModel
    {
        public string BankName { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }
    }


}

