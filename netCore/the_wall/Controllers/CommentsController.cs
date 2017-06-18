using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using the_wall.Models;

namespace the_wall.Controllers
{
    public class CommentsController : Controller
    {
        [HttpPost]
        [Route("/comment")]
        public IActionResult Comment(string comment, string messageid){
            string userid = HttpContext.Session.GetString("CurrentUserId");
            string query = $"INSERT INTO comments (comment, created_at, updated_at, messages_id, users_id) VALUES ('{comment}', NOW(), NOW(), '{messageid}', '{userid}')";
            DbConnector.Execute(query);
            return RedirectToAction("Index", "Messages");
        }
    }
}