using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class GamedevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
