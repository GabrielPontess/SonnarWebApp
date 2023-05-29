using Sonnar.Domain.Models;

namespace Sonnar.Domain.Models
{
    public class Desenvolvedor : Base
    {
        protected Desenvolvedor(string nome, Usuario usuario) : base(nome, usuario)
        {
        }
    }
}
