using Microsoft.AspNetCore.Mvc;
using Sonnar.WebApp.Models;
using System.Diagnostics;

namespace Sonnar.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Helpers.ISession _session;

        public HomeController(ILogger<HomeController> logger, Helpers.ISession session)
        {
            _logger = logger;
            _session = session;
        }

        public IActionResult Index()
        {
            if (_session.BuscarSessaoUsuario() != null) return RedirectToAction("Home", "Home");

            return View();
        }


        public IActionResult Home()
        {
            return View();
        }


        public IActionResult Sair()
        {
            _session.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }
    }
}