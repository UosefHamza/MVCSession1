using Microsoft.AspNetCore.Mvc;

namespace MVCSession1.Controllers
{
    public class HomeController : Controller
    {
        ////public ActionResult Index()
        ////{
        ////    return Redirect("/Home/AboutUs");

        ////}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
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
