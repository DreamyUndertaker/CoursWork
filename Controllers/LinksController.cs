using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class LinksController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
