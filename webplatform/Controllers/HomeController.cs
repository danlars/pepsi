using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    //[Authorize]
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            return View(Context.Boards());
        }

        [HttpPost]
        public ActionResult Index(string search)
        {
            ViewBag.search = search;
            return View(Context.Boards().FindAll(x => x.title.ToLower().Contains(search.ToLower())));
        }
    }
}