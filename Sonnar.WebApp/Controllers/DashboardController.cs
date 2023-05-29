using Microsoft.AspNetCore.Mvc;

namespace Sonnar.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
