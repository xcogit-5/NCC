using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        public IActionResult Add(ModelStudent student)
        {
            
            ViewBag.Roll = student.Roll;
            ViewBag.Name = student.Name;
            return View("Information");
        }
    }
}
