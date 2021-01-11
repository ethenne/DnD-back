using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DnDBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaracterController : ControllerBase
    {
        // GET: api/<CaracterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CaracterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CaracterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CaracterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CaracterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
