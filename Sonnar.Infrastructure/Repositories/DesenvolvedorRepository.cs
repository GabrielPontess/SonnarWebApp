using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class DesenvolvedorRepository : Repository<Desenvolvedor>, IDesenvolvedorRepository
    {
        public DesenvolvedorRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
