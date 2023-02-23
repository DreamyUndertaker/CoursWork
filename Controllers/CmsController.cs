using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class CmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
