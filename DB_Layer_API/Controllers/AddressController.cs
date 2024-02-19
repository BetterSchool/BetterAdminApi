using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {

        private static HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7276/api/Address/"),

        };
        // GET: api/<AdressController>
        [HttpGet]
        public async Task GetAsync()
        {
            using HttpResponseMessage response = await httpClient.GetAsync(httpClient.BaseAddress+"GetAddresses");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{jsonResponse}\n");
        }

        // GET api/<AdressController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdressController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdressController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
