using Microsoft.AspNetCore.Mvc;

namespace action_verb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int roll)
        {
            return View();
        }
    }
}
