using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class FormController : BaseController
    {

        // GET: Form/Card/{id}
        
        public ActionResult Card(int id = 0)
        {
            ViewBag.isPost = false;
            if (id > 0)
            {
                return View(Context.Cards().First(x => x.id == id));
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Card(Card model)
        {
            //TODO: check if post is valid 
            ViewBag.isPost = true;
            return View(model);
        }

        // GET: Form/Job/{id}
        public ActionResult Job(int id = 0)
        {
            if (id > 0)
            {
                return View(Context.Jobs().First(x => x.id == id));
            }
            else
            {
                return View();
            }
            
        }

        //GET: Form/Board
        public ActionResult Board(int id = 0)
        {
            if (id > 0)
            {
                return View(Context.Boards().First(x => x.id == id));
            }
            else
            {
                return View();
            }
        }
    }
}