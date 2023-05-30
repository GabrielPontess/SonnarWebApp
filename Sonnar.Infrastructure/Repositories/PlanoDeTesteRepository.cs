﻿using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class PlanoDeTesteRepository : Repository<PlanoDeTeste>
    {
        public PlanoDeTesteRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
