using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
