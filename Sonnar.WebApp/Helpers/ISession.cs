using Sonnar.Domain.Models;

namespace Sonnar.WebApp.Helpers
{
    public interface ISession
    {
        Usuario BuscarSessaoUsuario();
        void CriarSessaoDeUsuario(Usuario usuario);
        void RemoverSessaoUsuario();
    }
}
