using Microsoft.AspNetCore.Mvc;

namespace DemoForGit.Controllers
{
    public class RockyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
