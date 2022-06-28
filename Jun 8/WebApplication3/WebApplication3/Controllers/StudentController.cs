using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            ModelStudent s1 = new ModelStudent();
            
            s1.Roll = 1;
            s1.Name = "Hari";
            
            return View(s1);
        }


    }
}
