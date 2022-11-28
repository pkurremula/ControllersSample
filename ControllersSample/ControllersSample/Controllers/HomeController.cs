using Microsoft.AspNetCore.Mvc;
using ControllersSample.Models;

namespace ControllersSample.Controllers
{
    public class HomeController:Controller
    {
        [Route("Index")]
        [Route("/")]
        public string Index()
        {
            //return View();
            return "hello from Index";
        }

        [Route("about")]
        public string About()
        {
            //return View();
            return "hello from about";
        }

        [Route("Content")]
        public ContentResult ReturnContent()
        {
            //return View();
            return Content("<h1>Hello</h1> <h2>from Content</h2>", "text/html");
        }

        [Route("json")]
        public JsonResult ReturnJSON()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(), FirstName="James", LastName="Smith", Age=25
            };

            //return View();
            return new JsonResult(person);
        }
    }
}
