using Microsoft.AspNetCore.Mvc;

namespace WEB_Adder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult create()
        {
            return View();
        }

        public IActionResult PostCreate(int Num1, int Num2)
        {
            ViewBag.Num1 = Request.Form["Num1"] + Request.Form["Num2"];
            return View("Information");
        }
    }
}
