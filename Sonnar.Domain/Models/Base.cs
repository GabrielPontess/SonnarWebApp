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
        public Usuario Usuario { get; set; }
        protected Base(string nome, Usuario usuario)
        {
            Id = Guid.NewGuid();
            this.nome = nome;
            Usuario = usuario;
        }
    }
}
