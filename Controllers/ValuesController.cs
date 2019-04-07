using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace botcom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        int num = 0;
        // GET api/values
        //from phone
        [HttpGet]
        public ActionResult<string> Get()
        {
            String s = num.ToString();
            return s;
        }

        // GET api/values/5
        //from board
        [HttpGet("{id}")]
        public void Get(int id)
        {
            num++;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
