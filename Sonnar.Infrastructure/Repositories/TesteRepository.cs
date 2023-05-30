using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class TesteRepository : Repository<Teste>, ITesteRepository
    {
        public TesteRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
