using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace fitness.Controllers
{
    public class SanalPosController : Controller
    {
        // ...

        [HttpPost]
        public ActionResult Payment()
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

            return Json(true);
        }

        // Yönlendirme URL'leri

        public ActionResult PaymentSuccess()
        {
            return View();
        }

        public ActionResult PaymentError()
        {
            return View();
        }
    }
}