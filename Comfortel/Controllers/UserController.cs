using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class UserController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public bool InsertUser(User user)
        {
            db.spInsertUser(user.Name, user.LastName, user.MotherLastName, user.UserName, user.Password);
            return true;
        }

        public JsonResult GetUsers()
        {
            var data = db.spGetUsers_();
            
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public bool EditUser(User user)
        {
            db.spEditUser(user.Id, user.Name, user.LastName, user.MotherLastName, user.Password, user.UserName);
            return true;
        }

        public bool DeleteUser(int id)
        {
            db.spDeleteUser(id);
            return true;
        }

    }
}