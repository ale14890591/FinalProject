using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    //[Authorize(Roles = "Admin, User")]
    public class UserController : Controller
    {
        //
        // GET: /User/

        private StoreContext db = new StoreContext();

        [HttpGet]
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
    }
}
