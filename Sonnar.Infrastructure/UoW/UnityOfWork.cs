using Sonnar.Domain.Interfaces;
using Sonnar.Infrastructure.Repositories;

namespace Sonnar.Infrastructure.UoW
{
    public class UnityOfWork : IUnitOfWork
    {
        private AnalistaQARepository _analistaQARepository;
        private DesenvolvedorRepository _desenvolvedorRepository;
        private MetodologiaRepository _metodologiaRepository;
        private PlanoDeTesteRepository _planoDeTesteRepository;
        private ProjetoRepository _projetoRepository;
        private TesteRepository _testeRepository;
        private StepRepository _stepRepository;
        private UsuarioRepository _usuarioRepository;
        private SonnarDbContext _context;
        public UnityOfWork(SonnarDbContext context)
        {
            _context = context;
        }

        public IAnalistaQARepository AnalistaQARepository
        {
            get
            {
                return _analistaQARepository = _analistaQARepository ?? new AnalistaQARepository(_context);
            }
        }

        public IDesenvolvedorRepository DesenvolvedorRepository
        {
            get
            {
                return _desenvolvedorRepository = _desenvolvedorRepository ?? new DesenvolvedorRepository(_context);
            }
        }

        public IMetodologiaRepository MetodologiaRepository
        {
            get
            {
                return _metodologiaRepository = _metodologiaRepository ?? new MetodologiaRepository(_context);
            }
        }

        public IPlanoDeTesteRepository PlanoDeTesteRepository
        {
            get
            {
                return _planoDeTesteRepository = _planoDeTesteRepository ?? new PlanoDeTesteRepository(_context);
            }
        }

        public IProjetoRepository ProjetoRepository
        {
            get
            {
                return _projetoRepository = _projetoRepository ?? new ProjetoRepository(_context);
            }
        }

        public ITesteRepository TesteRepository
        {
            get
            {
                return _testeRepository = _testeRepository ?? new TesteRepository(_context);
            }
        }

        public IStepRepository StepRepository
        {
            get
            {
                return _stepRepository = _stepRepository ?? new StepRepository(_context);
            }
        }

        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                return _usuarioRepository = _usuarioRepository ?? new UsuarioRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
