using Microsoft.AspNetCore.Mvc;

namespace MVC_from_scratch.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult show()
        {
            return View();
        }
    }
}
