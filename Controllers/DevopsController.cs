using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class DevopsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
