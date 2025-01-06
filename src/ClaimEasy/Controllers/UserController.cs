using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ClaimEasy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("/get")]
        public IActionResult Get()
        {
            Log.Information("####### Calling UserController#############");
            return Ok("Hello World");
        }
    }
}
