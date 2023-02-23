using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class FrontendController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
