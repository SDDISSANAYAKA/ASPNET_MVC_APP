using ASPNET_MVC_APP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_APP.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name = "Sif", Age = 2};
            return View(doggo);
        }
        public String Hello()
        {
            return "Who's there?";
        }
    }
}
