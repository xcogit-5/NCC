using Microsoft.AspNetCore.Mvc;

namespace Jun_01_Empty_MVC_core.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult create()
        {
            return View();
        }

        public IActionResult postCreate(string fname, string lname)
        {
            ViewBag.fname = fname;
            ViewBag.lname = lname;
            return View("Information");
        }


    }
}
