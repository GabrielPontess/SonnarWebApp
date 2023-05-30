using Sonnar.Domain.Interfaces;
using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class PlanoDeTesteRepository : Repository<PlanoDeTeste>, IPlanoDeTesteRepository
    {
        public PlanoDeTesteRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
