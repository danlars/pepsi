using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        protected TestModelBuilder lists = new TestModelBuilder();
        public ActionResult Index()
        {
            return View(lists.getBoards());
        }

        [HttpPost]
        public ActionResult Index(string search)
        {
            ViewBag.search = search;
            return View(lists.getBoards().FindAll(x => x.name.ToLower().Contains(search.ToLower())));
        }
    }
}