using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class BoardController : Controller
    {
        protected TestModelBuilder builder = new TestModelBuilder();
        // GET: Board
        public ActionResult Index(int id)
        {
            ViewData["Jobs"] = builder.getJobs();
            ViewData["Cards"] = builder.getCards();
            return View(builder.getBoards().Find(x => x.id == id));
        }
    }
}