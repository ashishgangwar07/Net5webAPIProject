using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace consoleApptoWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("test/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from test contoller get method";
        }
        public string Get1()
        {
            return "Hello from test contoller get1 method";
        }
    }
}
