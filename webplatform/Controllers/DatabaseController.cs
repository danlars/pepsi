using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webplatform.Controllers
{
    public class DatabaseController : ApiController
    {
        // GET: api/Database/Get
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public IEnumerable<string> Test()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Database/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Database
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Database/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Database/5
        public void Delete(int id)
        {
        }
    }
}
