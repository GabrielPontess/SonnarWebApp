using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class AnalistaQARepository : Repository<AnalistaQA>, IAnalistaQARepository
    {
        public AnalistaQARepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
