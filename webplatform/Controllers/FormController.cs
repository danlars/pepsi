using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class FormController : BaseController
    {

        public FormController()
        {
            ViewBag.isPost = false;
        }

        public ActionResult Card()
        {
            return View();
        }

        // GET: Form/Card/{id}
        public ActionResult Card(Guid id)
        {
            return View(Context.FindCard(id));
        }

        [HttpPost]
        public ActionResult Card(Card model)
        {
            //TODO: check if post is valid 
            ViewBag.isPost = true;
            return View(model);
        }

        // GET: Form/Job/
        public ActionResult Job()
        {
            return View();
        }

        // GET: Form/Job/{id}
        public ActionResult Job(Guid id)
        {
            return View(Context.FindJob(id));
        }

        public ActionResult Board()
        {
            return View();
        }

        //GET: Form/Board/{id}
        public ActionResult Board(Guid id)
        {
            return View(Context.Boards().First(x => x.id == id));
        }

        //POST: Form/Board
        [HttpPost]
        public ActionResult Board(Board model)
        {
            if (ModelState.IsValid){
                ViewBag.isPost = true;
                //model.id = Context.Boards().OrderByDescending(x => x.id).First().id + 1;

                Context.Boards().Add(model);
            }

            return View(model);
        }

        //GET: Form/AddCard
        public ActionResult AddCard(Guid id)
        {
            ViewData["jobs"] = Context.Jobs(id).ToList();
            return View();
        }

        //GET: Form/AddCard
        [HttpPost]
        public ActionResult AddCard(Guid id, Card model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.isPost = true;
            }

            ViewData["jobs"] = Context.Jobs(id);
            return View(model);
        }
    }
}