using Microsoft.AspNetCore.Mvc;

namespace Sonnar.WebApp.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Visualizar()
        {
            return View();
        }
    }
}
