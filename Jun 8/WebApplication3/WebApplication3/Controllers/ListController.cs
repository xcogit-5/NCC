using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudents()
        {
            List<ModelStudent> lst = new List<ModelStudent>()
            {
                new ModelStudent{Roll = 1},
                new ModelStudent{Roll = 2, Name = "Shyam" }
            };
            return View(lst);
        }
    }
}
