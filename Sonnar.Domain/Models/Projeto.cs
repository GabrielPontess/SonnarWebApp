using Sonnar.Domain.Models;

namespace Sonnar.Domain.Models
{
    public class Projeto : Base
    {
        protected Projeto(string nome, Guid usuarioId) : base(nome, usuarioId)
        {
        }
    }
}
