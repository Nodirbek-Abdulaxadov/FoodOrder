using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
