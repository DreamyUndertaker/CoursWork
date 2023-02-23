using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class PopularbooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
