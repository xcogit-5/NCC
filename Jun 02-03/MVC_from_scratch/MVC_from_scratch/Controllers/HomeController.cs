using Microsoft.AspNetCore.Mvc;

namespace MVC_from_scratch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
