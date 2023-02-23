using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class UdemyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
