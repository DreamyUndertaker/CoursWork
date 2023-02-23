using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
