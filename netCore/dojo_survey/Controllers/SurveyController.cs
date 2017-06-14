using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojo_survey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult data(string name, int age){
            ViewBag.Name = name;
            ViewBag.Age = age;
            return View("data");
        }
    }
}