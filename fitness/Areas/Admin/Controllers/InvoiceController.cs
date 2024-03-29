﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace fitness.Areas.Admin.Controllers
{
    public class InvoiceController : Controller
    {
        public ActionResult Index()
        {
            InvoiceModel model = new InvoiceModel
            {
                BankName = "",
                CardNumber = "",
                ExpiryDate = "",
                CVV = "",
            };

            return View(model);
        }

        // Your Pay method

  

        // Create InvoiceModel
        public class InvoiceModel
        {
            public string BankName { get; set; }
            public string CardNumber { get; set; }
            public string ExpiryDate { get; set; }
            public string CVV { get; set; }
        }

        [HttpPost]
        public ActionResult Pay(FormCollection form)
        {
            // HTTP isteğinin post edilmiş olan farklı dosyaları (formdata) alın

            HttpPostedFileBase bankName = Request.Files["BankName"];
            HttpPostedFileBase cardNumber = Request.Files["CardNumber"];
            HttpPostedFileBase expiryDate = Request.Files["ExpiryDate"];
            HttpPostedFileBase cvv = Request.Files["CVV"];

            // Yüklenen her dosyayı stream'e aktar

            using (var streamReader = new StreamReader(bankName.InputStream))
            {
                string bankNameValue = streamReader.ReadToEnd();
            }
            using (var streamReader = new StreamReader(cardNumber.InputStream))
            {
                string cardNumberValue = streamReader.ReadToEnd();
            }
            using (var streamReader = new StreamReader(expiryDate.InputStream))
            {
                string expiryDateValue = streamReader.ReadToEnd();
            }
            using (var streamReader = new StreamReader(cvv.InputStream))
            {
                string cvvValue = streamReader.ReadToEnd();
            }

            // Ödeme işlemlerini REST API'sinde gerçekleştir

            // Ödeme sırasında harici bir hata oluşması durumunda
            // geri dönüş değeri FALSE veya -1 olarak belirtilir

            // Başarılı ise redirect sayfasına yönlendir

            return Json(new { success = true });
        }

        // Yönlendirme URL'leri

        public ActionResult PaymentSuccess()
        {
            // You can pass a success message or any other data if required
            string successMessage = "Ödeme işlemi başarıyla gerçekleşti!";
            ViewBag.Message = successMessage;
            return View();
        }

        public ActionResult PaymentError()
        {
            // You can pass an error message or any other data if required
            string errorMessage = "Ödeme işlemi sırasında bir hata oluştu! Lütfen tekrar deneyiniz.";
            ViewBag.Message = errorMessage;
            return View();
        }

    }
}