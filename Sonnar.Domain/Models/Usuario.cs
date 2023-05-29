﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonnar.Domain.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public char Genero { get; set; }
        public string Senha { get; set; }
        public List<AnalistaQA> AnalistaQAs { get; set; }
        public List<Metodologia> Metodologias { get; set; }
        public List<Desenvolvedor> Desenvolvedores { get; set; }
        public List<Projeto> Projetos { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
