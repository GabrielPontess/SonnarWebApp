using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class AnalistaQARepository : Repository<AnalistaQA>
    {
        public AnalistaQARepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
