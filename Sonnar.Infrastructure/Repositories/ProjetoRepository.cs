using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class ProjetoRepository : Repository<Projeto>
    {
        public ProjetoRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
