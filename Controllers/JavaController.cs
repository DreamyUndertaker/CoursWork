using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class JavaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
