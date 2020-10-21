using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class RoomController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();

        // GET: Room
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRates()
        {
            var data = db.spGetRates();
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public bool InsertRoom(Room room)
        {
            db.spInsertRoom(room.Description, room.Type, room.Code, room.RateId);
            return true;
        }

        public JsonResult GetRooms()
        {
            var data = db.spGetRooms();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public bool EditRoom(Room room)
        {
            db.spEditRoom(room.Id, room.Description, room.Type, room.Code, room.RateId);
            return true;
        }

        public bool DeleteRoom(int id)
        {
            db.spDeleteRoom(id);
            return true;
        }
    }
}