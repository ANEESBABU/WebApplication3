using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // This is a simple custom header custom headers
            Response.Headers.Add("name", "This is my name");
            Response.Headers.Add("No", "111");
            // Return response
            return Ok(new List<string> { "Dotnet", "Angular", "React" });
        }
        [HttpPost]
        public IActionResult Post([FromBody] MyModel model)
        {
            
            // Add custom headers
            Response.Headers.Add("Dotnet", "C#");
            Response.Headers.Add("Angular", "TS");
            Response.Headers.Add("React", "JS");


            // Process request
            // ...
            // Return response
            return Ok(new { success = true });
        }
    }
    public class MyModel
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
    }
}

