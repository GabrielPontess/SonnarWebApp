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
        public RegistroController(IUnitOfWork uow) 
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(UsuarioViewModel usuario)
        {
            try
            {
                _uow.UsuarioRepository.Add(UsuarioViewModelToUsuario(usuario));
                _uow.Commit();
            }
            catch
            {
                throw new Exception("Falha ao persistir usuário no banco de dados!");
            }

            return Index();
        }

        public Usuario UsuarioViewModelToUsuario(UsuarioViewModel usuario)
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
