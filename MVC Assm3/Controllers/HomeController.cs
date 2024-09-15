using Microsoft.AspNetCore.Mvc;

namespace MVC_Assm3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUS()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy() 
        { 
            return View();
        }
    }
}
