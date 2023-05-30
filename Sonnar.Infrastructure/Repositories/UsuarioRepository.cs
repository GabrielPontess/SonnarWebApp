using Sonnar.Domain.Models;

namespace Sonnar.Infrastructure.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(SonnarDbContext context) : base(context)
        {
        }
    }
}
