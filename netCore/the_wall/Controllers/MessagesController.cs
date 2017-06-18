using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using the_wall.Models;

namespace the_wall.Controllers
{
    public class MessagesController : Controller
    {
        [HttpGet]
        [Route("thewall")]
        public IActionResult Index(){
            ViewBag.CurrentUserName = HttpContext.Session.GetString("CurrentUserName");
            List<Dictionary<string, object>> AllMessages = DbConnector.Query("SELECT users.id, users.first_name, messages.message, messages.created_at FROM messages JOIN users ON messages.users_id = users_id");
            ViewBag.AllMessages = AllMessages;
            return View();
        }
        
        [HttpGet]
        [Route("/logout")]
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("LogReg", "Home");
        }
        
        [HttpPost]
        [Route("/message")]
        public IActionResult Message(string message){
            string id = HttpContext.Session.GetString("CurrentUserId");
            string query = $"INSERT INTO messages (message, created_at, updated_at, users_id) VALUES ('{message}', NOW(), NOW(), '{id}')";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
    }
}