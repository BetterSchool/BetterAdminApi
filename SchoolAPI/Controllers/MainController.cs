using Microsoft.AspNetCore.Mvc;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET: api/<MainController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //TODO: Read from database
            return new string[] { "value1", "value2" };
        }

        // GET api/<MainController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //TODO: Read from database
            return "value";
        }

        // POST api/<MainController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO: Create to database
        }

        // PUT api/<MainController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO: Update in database
        }

        // DELETE api/<MainController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: Delete from database
        }
    }
}
