using Microsoft.EntityFrameworkCore;
using Sonnar.Domain.Models;
using System;

namespace Sonnar.Infrastructure
{
    public class SonnarDbContext : DbContext
    {
        public SonnarDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SonnarDbContext).Assembly);
        }


        DbSet<Usuario> Usuario { get; set; }
        DbSet<Teste> Teste { get; set; }
        DbSet<Step> Step { get; set; }
        DbSet<PlanoDeTeste> PlanoDeTeste { get; set; }
        DbSet<AnalistaQA> AnalistaQA { get; set; }
        DbSet<Desenvolvedor> Desenvolvedor { get; set; }
        DbSet<Metodologia> Metodologia { get; set; }
        DbSet<Projeto> Projeto { get; set; }
    }
}
