using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAuthTest.Models.View;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAuthTest.Controllers
{
    [Route("api/[controller]")]
    public class PeepsController : Controller
    {
        List<Person> peeps = new List<Person>();

        public PeepsController()
        {
            var p1 = new Person()
            {
                Name = "Paul",
                Age = 29
            };
            var p2 = new Person()
            {
                Name = "Kylie",
                Age = 12
            };
            p1.Kids.Add(p2);
            var p3 = new Person()
            {
                Name = "Keaton",
                Age = 8
            };
            p1.Kids.Add(p3);
            peeps.Add(p1);
            peeps.Add(p2);
            peeps.Add(p3);
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return peeps;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Person p)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
