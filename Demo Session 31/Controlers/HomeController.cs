using Microsoft.AspNetCore.Mvc;

namespace Demo_Session_31.Controlers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs() {
        
        return View();
        }
        public IActionResult Privacy() {

            return View();
        }
    }
}
