using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class MarketingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
