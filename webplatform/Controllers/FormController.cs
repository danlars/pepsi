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
        [HttpGet]
        public ActionResult Card(int id = 0)
        {
            if (id > 0)
            {
                TestModelBuilder card = new TestModelBuilder();
                return View(card.getCards().Where(x => x.id == id));
            }
            else
            {
                return View();
            }
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