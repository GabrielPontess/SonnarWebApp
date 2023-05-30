using Sonnar.Domain.Models;

namespace Sonnar.Domain.Models
{
    public class Metodologia : Base
    {
        protected Metodologia(string nome, Guid usuarioId) : base(nome, usuarioId)
        {
        }
    }
}
