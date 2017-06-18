using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using the_wall.Models;

namespace the_wall.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult LogReg()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult register(User model)
        {
            if (ModelState.IsValid)
            {
                // string query = $"SELECT users.id FROM users WHERE (email = '{model.email}')";
                // List<Dictionary<string, object>> user = DbConnector.Query(query);
                // System.Console.WriteLine(user);
                // System.Console.WriteLine(user.ToString());
                // foreach (var item in user)
                // {
                //     foreach (var thing in item)
                //     {
                //         System.Console.WriteLine(thing);
                //         if(thing.Value != null)
                //         {
                string addquery = $@"INSERT INTO users 
                (first_name, last_name, email, password, created_at, updated_at)
                VALUES 
                ('{model.first_name}', '{model.last_name}', '{model.email}', '{model.password}', NOW(), NOW())";
                DbConnector.Execute(addquery);
                string idquery = $"SELECT users.id, users.first_name FROM users WHERE (email = '{model.email}')";
                var CurrentUser = DbConnector.Query(idquery);
                foreach(var item in CurrentUser){
                    string CurrentUserId = item["id"].ToString();
                    string CurrentUserName = item["first_name"].ToString();
                    HttpContext.Session.SetString("CurrentUserId", CurrentUserId);
                    HttpContext.Session.SetString("CurrentUserName", CurrentUserName);
                }      
                return RedirectToAction("Index", "Messages");
                //         }
                //     }   
                // }
            }
            ViewBag.Errors = ModelState.Values;
            return RedirectToAction("LogReg");
        }
        
        [HttpPost]
        [Route("/login")]
        public IActionResult Login(string email, string password){
            string query = $"SELECT users.id, users.first_name, users.email FROM users WHERE (email = '{email}') AND (password = '{password}')";
            var CurrentUser = DbConnector.Query(query);
            foreach(var item in CurrentUser){
                if (item["email"].ToString() == email)
                {
                    string CurrentUserId = item["id"].ToString();
                    string CurrentUserName = item["first_name"].ToString();
                    HttpContext.Session.SetString("CurrentUserId", CurrentUserId);
                    HttpContext.Session.SetString("CurrentUserName", CurrentUserName);
                }
                return RedirectToAction("Index", "Messages");
            }
            return RedirectToAction("LogReg");
        }
    }
}
