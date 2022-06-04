using Microsoft.AspNetCore.Mvc;

namespace Static_Tag_Helper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
