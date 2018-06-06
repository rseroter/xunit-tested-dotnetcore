using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tested_core_app.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "pivotal", "dell" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "pivotal";
        }

        // GET api/values/5/status
        [HttpGet("{id}/status")]
        public string GetPublicStatus(int id)
        {
            if(id > 0 && id <= 10) {
            return "public";
            }
            else { 
                return "private";
            }
        }
    }
}
