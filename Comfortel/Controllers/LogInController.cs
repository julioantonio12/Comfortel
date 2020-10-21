using Comfortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comfortel.Controllers
{
    public class LogInController : Controller
    {
        ComfortelEntities db = new ComfortelEntities();

        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }

        public bool GetUser(User user)
        {
            var data = db.spLogIn(user.UserName, user.Password);
            int i=0;
            foreach (var r in data)
            {
                i++;
            }
            return (i > 0);
        }
    }
}