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
                return Json("success");
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
                System.Console.WriteLine("*****************");
                System.Console.WriteLine("account found checking pass");
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(user, user.password, password))
                {
                    System.Console.WriteLine("********************");
                    System.Console.WriteLine("pass good");
                    ViewBag.CurrentUserId = user.user_id;
                    return Json(user.user_id);
                }
            }
            System.Console.WriteLine("*********************");
            System.Console.WriteLine("account not found");
            string error = "account not found";
            ViewBag.Errors = error;
            return RedirectToAction("LogRegPage");

        }
    }
}
