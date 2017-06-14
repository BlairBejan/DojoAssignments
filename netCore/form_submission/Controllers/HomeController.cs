using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using form_submission.Models;

namespace form_submission.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("info")]
        public IActionResult Info(string first_name, string last_name, int age, string email, string password)
        {
            User newuser = new User{
                First_Name = first_name,
                Last_Name = last_name,
                Age = age,
                Email = email,
                Password = password,
            };
            TryValidateModel(newuser);
            ViewBag.errors = ModelState.Values;
            return View();
        }

        [HttpPost]
        [Route("success")]
        public IActionResult success(){
            return View();
        }
    }
}
