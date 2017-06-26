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
    public class HeroController : Controller
    {
        private readonly HeroFactory herofactory;
        [HttpGet]
        [Route("/heroselection")]
        public IActionResult Index(){
            if(!CheckLogin()){
                string Alias = HttpContext.Session.GetString("UserAlias");
                ViewBag.Alias = Alias;
                ViewBag.Errors = new List<string>();
            }
            return View();
        }

        [HttpPost]
        [Route("/selecthero")]
        public IActionResult SelectHero(Hero model){
            if(!CheckLogin()){
                if (ModelState.IsValid)
                {
                    int? userId = HttpContext.Session.GetInt32("UserId");
                    int userid = userId ?? default(int);
                    herofactory.CreateNewHero(model, userid);
                }
            }
            ViewBag.Errors = ModelState.Values;
            return Json("something");
        }
        private bool CheckLogin()
        {
            return (HttpContext.Session.GetInt32("UserId") != null);
        }
    }
}