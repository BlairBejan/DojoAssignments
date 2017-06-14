using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
 
namespace dojodachi.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult index(){
            if(HttpContext.Session.GetObjectFromJson<MyDojoDachi>("Dojodachi") == null)
            {
                HttpContext.Session.SetObjectAsJson("Dojodachi", new MyDojoDachi());
            }
            ViewBag.Dojodachi = HttpContext.Session.GetObjectFromJson<MyDojoDachi>("Dojodachi");
            return View();
        }

        [HttpGet]
        [Route("feed")]
        public IActionResult feed(){
            MyDojoDachi edited = HttpContext.Session.GetObjectFromJson<MyDojoDachi>("Dojodachi");
            Random RandomObject = new Random();
            if (edited.Meals > 0)
            {
                edited.Meals -= 1;
                int DoesntLike = RandomObject.Next(0,4);
                if(DoesntLike > 0){
                    edited.Fullness += RandomObject.Next(5,11);
                }     
            }
            HttpContext.Session.SetObjectAsJson("Dojodachi", edited);
            ViewBag.Dojodachi = edited;
            return RedirectToAction("index");
        }
        
        [HttpGet]
        [Route("play")]
        public IActionResult play(){
            MyDojoDachi edited = HttpContext.Session.GetObjectFromJson<MyDojoDachi>("Dojodachi");
            Random RandomObject = new Random();
            if(edited.Energy > 4){
                edited.Energy -= 5;
                int DoesntLike = RandomObject.Next(0,4);
                if(DoesntLike > 0){
                    edited.Happiness += RandomObject.Next(5,11);
                }
                
            }
            HttpContext.Session.SetObjectAsJson("Dojodachi", edited);
            ViewBag.Dojodachi = edited;
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("work")]
        public IActionResult work(){
            MyDojoDachi edited = HttpContext.Session.GetObjectFromJson<MyDojoDachi>("Dojodachi");
            Random RandomObject = new Random();
            if (edited.Energy > 4)
            {
                edited.Energy -= 5;
                edited.Meals += RandomObject.Next(1,4);
            }
            HttpContext.Session.SetObjectAsJson("Dojodachi", edited);
            ViewBag.Dojodachi = edited;
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("sleep")]
        public IActionResult sleep(){
            MyDojoDachi edited = HttpContext.Session.GetObjectFromJson<MyDojoDachi>("Dojodachi");
            edited.Energy += 15;
            edited.Fullness -= 5;
            edited.Happiness -= 5;
            HttpContext.Session.SetObjectAsJson("Dojodachi", edited);
            ViewBag.Dojodachi = edited;
            return RedirectToAction("index");
        }
    }
    public static class SessionExtensions
    {
    // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
    public static void SetObjectAsJson(this ISession session, string key, object value)
    {
        // This helper function simply serializes theobject to JSON and stores it as a string in session
        session.SetString(key, JsonConvert.SerializeObject(value));
    }
       
    // generic type T is a stand-in indicating that we need to specify the type on retrieval
    public static T GetObjectFromJson<T>(this ISession session, string key)
    {
        string value = session.GetString(key);
        // Upone retrieval the object is deserialized based on the type we specified
        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    }
}
}