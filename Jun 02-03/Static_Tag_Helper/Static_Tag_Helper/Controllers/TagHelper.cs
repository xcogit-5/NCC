using Microsoft.AspNetCore.Mvc;

namespace Static_Tag_Helper.Controllers
{
    public class TagHelper : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
