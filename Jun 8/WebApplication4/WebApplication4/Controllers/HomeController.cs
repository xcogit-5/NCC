using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudent()
        {
            ModelStudent s1 = new ModelStudent();
            s1.Roll = 1;
            s1.Name = "Ram";
            return View(s1);
        }
    }
}

