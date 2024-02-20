using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        // POST api/<SignUpController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }
    }
}
