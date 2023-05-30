using Sonnar.Domain.Models;

namespace Sonnar.Domain.Models
{
    public class Desenvolvedor : Base
    {
        protected Desenvolvedor(string nome, Guid usuarioId) : base(nome, usuarioId)
        {
        }
    }
}
