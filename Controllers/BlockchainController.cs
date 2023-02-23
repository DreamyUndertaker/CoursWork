using Microsoft.AspNetCore.Mvc;

namespace CoursWork.Controllers
{
    public class BlockchainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
