using Sonnar.Domain.Models;

namespace Sonnar.WebApp.Helpers
{
    public class UsuarioAutenticado
    {
        public bool Autenticado { get; set; } = false;
        public Usuario Usuario { get; set; }

        public UsuarioAutenticado(bool autenticado)
        {
            Autenticado = autenticado;
        }
    }
}
