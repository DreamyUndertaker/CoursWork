using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class HtmlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
