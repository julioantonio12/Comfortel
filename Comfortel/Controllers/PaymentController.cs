using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class PaymentController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();

        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }


        public bool InsertPayment(Payment payment)
        {
            db.spInsertPayment(payment.DatePayment, payment.PaymentType, payment.Amount, payment.ReservationId);
            return true;
        }

        public JsonResult GetPayments()
        {
            var data = db.spGetPayments();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public bool EditPayment(Payment payment)
        {
            db.spEditPayment(payment.Id, payment.DatePayment, payment.PaymentType, payment.Amount, payment.ReservationId);
            return true;
        }

        public bool DeletePayment(int id)
        {
            db.spDeletePayment(id);
            return true;
        }
    }
}