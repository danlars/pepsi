using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class FormController : Controller
    {

        // GET: Form/Card/{id}
        
        public ActionResult Card(int id = 0)
        {
            ViewBag.isPost = false;
            if (id > 0)
            {
                TestModelBuilder card = new TestModelBuilder();
                return View(card.getCards().First(x => x.id == id));
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
                TestModelBuilder job = new TestModelBuilder();
                return View(job.getJobs().Where(x => x.id == id));
            }
            else
            {
                return View();
            }
            
        }
    }
}