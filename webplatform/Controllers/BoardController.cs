using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class BoardController : BaseController
    {
        // GET: Board
        public ActionResult Index(int id)
        {   
            return View(Context.Boards().First(x => x.id == id));
        }
    }
}