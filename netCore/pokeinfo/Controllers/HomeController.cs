using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace pokeinfo.Controllers
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

        // Name
        // Primary Type
        // Height
        // Weight

        [HttpGet]
        [Route("{pokeid}")]
        public IActionResult pokemon(int pokeid){
            var PokeInfo = new Dictionary<string, object>();
            WebRequest.GetPokemonDataAsync(pokeid, ApiResponse =>
            {
                PokeInfo = ApiResponse;
            }).Wait();
            ViewBag.pokemon = PokeInfo;
            // System.Console.WriteLine(PokeInfo["name"]);
            return View();
        }
    }
}
