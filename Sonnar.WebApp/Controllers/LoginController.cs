using Microsoft.AspNetCore.Mvc;
using Sonnar.Domain.Interfaces;
using Sonnar.WebApp.ViewModels;
using Sonnar.Shared.Utils;
using System.Security.Cryptography;

namespace Sonnar.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private IUnitOfWork _uow;
        private Helpers.ISession _session;

        public LoginController(IUnitOfWork uow, Helpers.ISession session)
        {
            _uow = uow;
            _session = session;
        }

        public IActionResult Index()
        {
            if (_session.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Inicio");
            return View();
        }

        [HttpPost]
        public IActionResult Autenticar(LoginViewModel usuario)
        {
            try
            {
                var result = _uow.UsuarioRepository.Get(x => x.Email == usuario.Email && x.Senha == Hash.SHA256(usuario.Senha));

                if(result == null)
                {
                    throw new Exception("Usuário não encontrado");
                }

                _session.CriarSessaoDeUsuario(result);
                return RedirectToAction("Index", "Inicio");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}
