using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class RateController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();

        // GET: Rate
        public ActionResult Index()
        {
            return View();
        }

        public bool InsertRate(Rate rate)
        {
            db.spInsertRate(rate.Name, rate.Price);
            return true;
        }

        public JsonResult GetRates()
        {
            var data = db.spGetRates();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public bool EditRate(Rate rate)
        {
            db.spEditRate(rate.Id, rate.Name, rate.Price);
            return true;
        }

        public bool DeleteRate(int id)
        {
            db.spDeleteRate(id);
            return true;
        }

    }
}