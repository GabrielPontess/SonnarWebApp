using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonnar.Domain.Models
{
    public class Teste
    {
        public Guid Id { get; set; }
        public long Numero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public Projeto Projeto { get; set; }
        public PlanoDeTeste PlanoDeTeste { get; set; }
        public AnalistaQA AnalistaQA { get; set; }
        public List<Teste> Testes { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
