using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webplatform.Controllers
{
    public class IframeController : BaseController
    {
        // GET: Iframe
        public ActionResult Board()
        {
            return View(Context.Boards());
        }

        [HttpPost]
        public ActionResult Board(string search)
        {
            return View(Context.Boards().FindAll(x => x.title.ToLower().Contains(search.ToLower())));
        }
    }
}