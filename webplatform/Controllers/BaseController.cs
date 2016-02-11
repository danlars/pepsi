using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class BaseController : Controller
    {

        protected APIContext Context = new APIContext();

        public BaseController()
        {
        }
    }
}