using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonnar.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAnalistaQARepository AnalistaQARepository { get; }
        IDesenvolvedorRepository DesenvolvedorRepository { get; }
        IMetodologiaRepository MetodologiaRepository { get; }
        IPlanoDeTesteRepository PlanoDeTesteRepository { get; }
        IProjetoRepository ProjetoRepository { get; }
        ITesteRepository TesteRepository { get; }
        IStepRepository StepRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        void Commit();
        void Dispose();
    }
}
