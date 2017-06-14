using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        // List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
        // GET: /Home/
        // private DbConnector cnx;
        // public HomeController(){
        //     cnx = new DbConnector();
        // }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("form")]
        public IActionResult form(string name, string quote)
        {
            string query = $"INSERT INTO quotes (name, quote) VALUES ('{name}', '{quote}')";
            DbConnector.Execute(query);
            return RedirectToAction("quotes");
        }
        
        [HttpGet]
        [Route("quotes")]
        public IActionResult quotes()
        {
            string query = "SELECT * FROM quotes";
            var allquotes = DbConnector.Query(query);
            ViewBag.quotes = allquotes;
            return View();
        }
    }
}
