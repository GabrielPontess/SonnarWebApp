using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonnar.Domain.Models
{
    public class PlanoDeTeste
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }
        public Projeto Projeto { get; set; }    
        public List<Teste> Testes { get; set; }
    }
}
