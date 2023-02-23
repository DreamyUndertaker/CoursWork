using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class ToolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
