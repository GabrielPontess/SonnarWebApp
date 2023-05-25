using Microsoft.AspNetCore.Mvc;

namespace Sonnar.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
