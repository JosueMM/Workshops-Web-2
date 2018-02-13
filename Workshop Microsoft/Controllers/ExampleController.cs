using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;


namespace Workshop.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Soy un nuevo controlador";
            
           
            return View();
        }
     
        public IActionResult Contact()
        {
            ViewData["Message"] = "Informacion.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
