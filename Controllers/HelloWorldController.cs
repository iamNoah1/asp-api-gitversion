using Microsoft.AspNetCore.Mvc;

namespace Asp.Api.Template
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("hello");
        }
    }
}
