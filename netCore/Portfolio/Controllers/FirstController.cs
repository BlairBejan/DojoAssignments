using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Portfolio.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }
        
        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects(){
            return View();
        }
    }
}