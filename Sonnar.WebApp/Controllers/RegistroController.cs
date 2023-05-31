using Microsoft.AspNetCore.Mvc;
using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;
using Sonnar.Shared.Utils;
using Sonnar.WebApp.ViewModels;

namespace Sonnar.WebApp.Controllers
{
    public class RegistroController : Controller
    {
        private IUnitOfWork _uow;
        private Helpers.ISession _session;

        public RegistroController(IUnitOfWork uow, Helpers.ISession session)
        {
            _uow = uow;
            _session = session;
        }

        public IActionResult Index()
        {
            if (_session.BuscarSessaoUsuario() != null) return RedirectToAction("Home", "Home");

            return View();
        }

        [HttpPost]
        public IActionResult Registro(RegistroViewModel usuario)
        {
            try
            {
                _uow.UsuarioRepository.Add(UsuarioViewModelToUsuario(usuario));
                _uow.Commit();

                return Redirect("/Login");
            }
            catch
            {
                throw new Exception("Falha ao persistir usuário no banco de dados!");
            }
        }

        public Usuario UsuarioViewModelToUsuario(RegistroViewModel usuario)
        {
            return new Usuario()
            {
                Nome = usuario.Nome,
                Cargo = usuario.Cargo,
                Email = usuario.Email,
                Genero = usuario.Genero,
                Senha = Hash.SHA256(usuario.Senha),
                DataCadastro = DateTime.Now,
                DataDeNascimento = usuario.DataDeNascimento
            };
        }


    }
}
