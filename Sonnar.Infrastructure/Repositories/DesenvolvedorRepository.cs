using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class DesenvolvedorRepository : Repository<Desenvolvedor>
    {
        public DesenvolvedorRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
