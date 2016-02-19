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

        // GET: Form/Card/{id}
        public ActionResult Card(Guid id)
        {
            var model = Context.FindCard(id);
            ViewData["jobs"] = Context.Jobs(Context.FindJob(model.job_id).BoardId);
            return View(model);
        }

        [HttpPost]
        public ActionResult Card(Guid id, Card model)
        {
            model.id = id;
            if (ModelState.IsValid && Context.UpdateCard(model))
            {
                ViewBag.isPost = true;
            }
            ViewData["jobs"] = Context.Jobs(Context.FindJob(model.job_id).BoardId);
            return View(model);
        }

        // GET: Form/AddJob
        public ActionResult AddJob(Guid id)
        {
            ViewBag.action = "AddJob";
            return View("Job");
        }

        // POST: Form/AddJob
        [HttpPost]
        public ActionResult AddJob(Guid id, Job model)
        {
            ViewBag.action = "AddJob";
            model.BoardId = id;
            if (ModelState.IsValid && Context.AddJob(model))
            {
                ViewBag.isPost = true;
            }

            return View("Job", model);
        }

        // GET: Form/Job/{id}
        public ActionResult Job(Guid id)
        {
            ViewBag.action = "Job";
            return View(Context.FindJob(id));
        }

        // GET: Form/Job/{id}
        [HttpPost]
        public ActionResult Job(Guid id, Job model)
        {
            ViewBag.action = "Job";
            model.id = id;
            if (ModelState.IsValid && Context.UpdateJob(model))
            {
                ViewBag.isPost = true;
            }
            return View(Context.FindJob(id));
        }

        //GET: Form/Board
        public ActionResult AddBoard()
        {
            ViewBag.action = "AddBoard";
            return View("Board");
        }

        //GET: Form/Board/{id}
        public ActionResult Board(Guid id)
        {
            ViewBag.action = "Board";
            return View(Context.FindBoard(id));
        }

        //POST: Form/Board
        [HttpPost]
        public ActionResult AddBoard(Board model)
        {
            ViewBag.action = "AddBoard";
            if (ModelState.IsValid && Context.AddBoard(model)){
                ViewBag.isPost = true;
            }

            return View("Board", model);
        }

        //POST: Form/Board/{id}
        [HttpPost]
        public ActionResult Board(Guid id, Board model)
        {
            ViewBag.action = "Board";
            model.id = id;
            if (ModelState.IsValid && Context.UpdateBoard(model))
            {
                ViewBag.isPost = true;
            }

            return View(model);
        }

        //GET: Form/AddCard
        public ActionResult AddCard(Guid id)
        {
            ViewData["jobs"] = Context.Jobs(id);
            return View();
        }

        //GET: Form/AddCard
        [HttpPost]
        public ActionResult AddCard(Guid id, Card model)
        {
            if (ModelState.IsValid && Context.AddCard(model))
            {
                ViewBag.isPost = true;
            }

            ViewData["jobs"] = Context.Jobs(id);
            return View(model);
        }
    }
}