using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using log_reg.Models;

namespace log_reg.Controllers
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

        [HttpGet]
        [Route("loginPage")]
        public IActionResult loginPage()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult login(string email, string password)
        {
            string query = $"SELECT users.email FROM users WHERE (email = '{email}') AND (password = '{password}')";
            List<Dictionary<string, object>> userEmail = DbConnector.Query(query);
            System.Console.WriteLine(userEmail);
            return RedirectToAction("success");
        }

        [HttpPost]
        [Route("register")]
        public IActionResult register(User model){
            if(ModelState.IsValid){
                string query = $"INSERT INTO users (first_name, last_name, email, password, created_at, updated_at) VALUES ('{model.FirstName}', '{model.LastName}', '{model.Email}', '{model.Password}', NOW(), NOW())";
                DbConnector.Execute(query);
                return RedirectToAction("success");
            }
            ViewBag.Errors = ModelState.Values;
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("success")]
        public IActionResult success(){
            return View();
        }
        
    }
}
