using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class ProjetoRepository : Repository<Projeto> , IProjetoRepository
    {
        public ProjetoRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
