﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Web.API.CORS;

namespace Web.API.Controllers
{
    public class ValuesController : ApiController
    {
        [EnableCustomCors]
       // [EnableCors(origins: "http://localhost:49639", headers:"*",methods:"*")]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
