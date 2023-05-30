using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class StepRepository : Repository<Step>, IStepRepository
    {
        public StepRepository(SonnarDbContext context) : base(context)
        {
        }


    }
}
