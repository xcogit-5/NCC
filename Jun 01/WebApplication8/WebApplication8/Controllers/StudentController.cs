using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult show()
        {
            return View();
        }
    }
}
