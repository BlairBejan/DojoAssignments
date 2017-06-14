using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace firstsite.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        [HttpGet]
        [Route("index")]
        public string Index(){
            return "Hello World!";
        }
    }
}