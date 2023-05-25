using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonnar.Domain.Models
{
    public class Base
    {
        public Guid Id { get; set; }
        public String nome { get; set; }

        protected Base(string nome)
        {
            Id = Guid.NewGuid();
            this.nome = nome;
        }
    }
}
