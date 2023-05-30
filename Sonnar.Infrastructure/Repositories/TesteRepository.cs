using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class TesteRepository : Repository<Teste>
    {
        public TesteRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
