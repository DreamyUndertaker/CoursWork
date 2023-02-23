using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class NodejsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
