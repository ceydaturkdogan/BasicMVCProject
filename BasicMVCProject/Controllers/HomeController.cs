using Microsoft.AspNetCore.Mvc;

namespace BasicMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
