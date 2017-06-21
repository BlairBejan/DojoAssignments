using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using restaurant.Models;
using System.Linq;

namespace restaurant.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("/review")]
        public IActionResult Review(User model){
            if(ModelState.IsValid){

            }
            return RedirectToAction("Index");
        }
    }
}
