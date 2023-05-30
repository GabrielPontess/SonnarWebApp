using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class MetodologiaRepository : Repository<Metodologia>, IMetodologiaRepository
    {
        public MetodologiaRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
