using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class FreeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
