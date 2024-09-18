using Microsoft.AspNetCore.Mvc;

namespace Project01_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            //return Content("Hello From Content Result");
            return View();
        }
        public IActionResult AboutUs()
        {
            // return "This is About Us Action";
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
