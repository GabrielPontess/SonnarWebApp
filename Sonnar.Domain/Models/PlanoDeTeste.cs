using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonnar.Domain.Models
{
    public class PlanoDeTeste : Base
    {
        protected PlanoDeTeste(string nome, Guid usuarioId) : base(nome, usuarioId)
        {
        }
    }
}
