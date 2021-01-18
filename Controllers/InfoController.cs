using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Asp.Api.Versioning
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyInformationalVersionAttribute infoVersionAttribute = assembly.GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute)) as AssemblyInformationalVersionAttribute;
            string version = infoVersionAttribute.InformationalVersion;

            JObject response = new JObject();
            response.Add(new JProperty("healthy", "true"));
            response.Add(new JProperty("version", version));
            return new OkObjectResult(response);
        }
    }
}
