using Microsoft.AspNetCore.Mvc;

namespace Jun_01_Empty_MVC_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Display()
        {
            ViewBag.FirstName = "Ram";
            ViewData["LastName"] = "Thapa";
            return View("Information");
        }
    }
}
