using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class ReservationController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetReservations()
        {
            var data = db.spGetReservations();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPriceByRoomId(int id)
        {
            var data = db.spGetPrice(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}