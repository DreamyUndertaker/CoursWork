using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class MobileappController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
