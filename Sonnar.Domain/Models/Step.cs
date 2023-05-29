using Sonnar.Domain.Enumerators;

namespace Sonnar.Domain.Models
{
    public class Step
    {
        public int Id { get; set; }
        public StepStatus Status { get; set; }
        public Metodologia Metodologia { get; set; }
        public Desenvolvedor Desenvolvedor { get; set; }
        public String Descricao { get; set; }
        public Teste Teste { get; set; }    
    }
}
