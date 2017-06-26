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
        [HttpGet]
        [Route("/heroselection")]
        public IActionResult Index(){
            string Alias = HttpContext.Session.GetString("UserAlias");
            ViewBag.Alias = Alias;
            return View();
        }

        [HttpPost]
        [Route("/selecthero")]
        public IActionResult SelectHero(Hero model){
            return Json("something");
        }
    }
}