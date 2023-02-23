using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class GraphicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
