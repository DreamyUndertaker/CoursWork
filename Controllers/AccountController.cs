using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


