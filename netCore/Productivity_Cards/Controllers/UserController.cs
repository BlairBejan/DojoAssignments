using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Productivity_Cards.Models;
using Productivity_Cards.Factories;
using Microsoft.AspNetCore.Identity;

namespace Productivity_Cards.Controllers
{
    public class UserController : Controller
    {
        private readonly UserFactory userfactory;
        public UserController(){
            userfactory = new UserFactory();
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult LogRegPage(){
            ViewBag.Errors = new List<string>();
            return View();
        }
        
        [HttpPost]
        [Route("/registeruser")]
        public IActionResult RegisterUser(User model){
            if(ModelState.IsValid){
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                model.password = Hasher.HashPassword(model, model.password);
                userfactory.AddUser(model);
                ViewBag.Errors = "Account Created Procede to Log in";
                return RedirectToAction("LogRegPage");
            }
            ViewBag.Errors = ModelState.Values;
            return RedirectToAction("LogRegPage");
        }

        [HttpPost]
        [Route("/loginuser")]
        public IActionResult LoginUser(string email, string password){
            var user = userfactory.GetUserByEmail(email);
            if(user != null && password != null)
            {
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(user, user.password, password))
                {
                    HttpContext.Session.SetInt32("UserId", user.user_id);
                    HttpContext.Session.SetString("UserAlias", user.alias);
                    System.Console.WriteLine("******************");
                    return RedirectToAction("Index", "Hero");
                }
            }
            string error = "account not found";
            ViewBag.Errors = error;
            return RedirectToAction("LogRegPage");
        }
    }
}
