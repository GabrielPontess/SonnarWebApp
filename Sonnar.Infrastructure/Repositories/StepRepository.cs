using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class StepRepository : Repository<Step>
    {
        public StepRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
