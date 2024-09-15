using Microsoft.AspNetCore.Mvc;

namespace MVCSession1.Controllers
{
    public class HomeController : Controller
    {
        ////public ActionResult Index()
        ////{
        ////    return Redirect("/Home/AboutUs");
              
        ////}

        public string AboutUs()
        {
            return "This is About Us Action ";
        }
    }
}
