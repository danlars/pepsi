using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models.Forms;

namespace webplatform.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(Login model)
        {
            if (ModelState.IsValid)
            {
                TempData["level"] = "success";
                TempData["success"] = "Du er logget ind";
                return RedirectToAction("Index", new {@Controller = "Home"});
            }
            return View(model);
        }


        [HttpGet]
        public ActionResult NewUser()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult NewUser(NewUser model)
        {
            if (ModelState.IsValid)
            {
                TempData["level"] = "success";
                TempData["success"] = "Din bruger er blevet tilføjet";
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}