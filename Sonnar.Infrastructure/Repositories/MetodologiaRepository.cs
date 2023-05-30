using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class MetodologiaRepository : Repository<Metodologia>
    {
        public MetodologiaRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
