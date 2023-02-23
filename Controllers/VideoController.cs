using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
