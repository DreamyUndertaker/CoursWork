using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class BackendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
