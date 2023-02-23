using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
