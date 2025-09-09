using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string index()
        {
            Console.WriteLine("index");

            return "Hola Mundo!";
        }

        [HttpGet("hello")]
        public string hello(
            [FromQuery(Name = "otronombre")] string name = "Josue"
            )
        {
            Console.WriteLine("hello");

            return "Hola, " + name + "!";
        }
    }
}
