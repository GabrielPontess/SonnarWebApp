using Microsoft.AspNetCore.Mvc;
using Sonnar.Domain.Interfaces;

namespace Sonnar.WebApp.Controllers
{
    public class ConfiguracoesController : Controller
    {
        private IUnitOfWork _uow;
        private Helpers.ISession _session;

        public ConfiguracoesController(IUnitOfWork uow, Helpers.ISession session)
        {
            _uow = uow;
            _session = session;
        }

        public IActionResult Index()
        {
            return View(_session.BuscarSessaoUsuario());
        }


        public IActionResult AdicionarEntidade(string Nome, int? Tipo)
        {
            try
            {
                return View();
            }
            catch
            {
                throw new Exception("Houve uma falha ao tentar adicionar a entidade");
            }
        }

        public IActionResult RemoverEntidade(string Nome, int? Tipo)
        {
            try
            {
                return View();
            }
            catch
            {
                throw new Exception("Houve uma falha ao tentar remover a entidade");
            }
        }
    }
}
