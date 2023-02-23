using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class FrontendmastersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
