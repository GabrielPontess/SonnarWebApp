using Microsoft.AspNetCore.Mvc;

namespace Sonnar.WebApp.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
