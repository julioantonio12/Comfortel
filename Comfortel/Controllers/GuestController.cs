using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class GuestController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();

        // GET: Guest
        public ActionResult Index()
        {
            return View();
        }


        public bool InsertGuest(Guest guest)
        {
            db.spInsertGuest(guest.Name, guest.LastName, guest.MotherLastName, guest.Email);
            return true;
        }

        public JsonResult GetGuests()
        {
            var data = db.spGetGuests();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public bool EditGuest(Guest guest)
        {
            db.spEditGuest(guest.Id, guest.Name, guest.LastName, guest.MotherLastName, guest.Email);
            return true;
        }

        public bool DeleteGuest(int id)
        {
            db.spDeleteGuest(id);
            return true;
        }
    }
}