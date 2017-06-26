using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class DashboardController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }
    }
}
