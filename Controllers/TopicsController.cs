using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class TopicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
