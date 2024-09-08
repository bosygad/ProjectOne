using Microsoft.AspNetCore.Mvc;

namespace Project01_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello From Content Result";
            return Content("Hello From Content Result");
        }
        public string AboutUs()
        {
            return "This is About Us Action";
        }
    }
}
