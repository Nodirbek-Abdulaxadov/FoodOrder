using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
    }
}
