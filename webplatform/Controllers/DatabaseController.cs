using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using webplatform.Models;

namespace webplatform.Controllers
{
    public class DatabaseController : ApiController
    {
        protected APIContext Context = new APIContext();

        // DELETE: api/Database/5
        [System.Web.Http.AcceptVerbs("DELETE")]
        public void DeleteBoard(Guid id)
        {
            Context.ArchiveBoard(id);
        }

        [System.Web.Http.AcceptVerbs("DELETE")]
        public void DeleteJob(Guid id)
        {
            Context.ArchiveJob(id);
        }

        [System.Web.Http.AcceptVerbs("DELETE")]
        public void DeleteCard(Guid id)
        {
            Context.ArchiveCard(id);
        }
    }
}
