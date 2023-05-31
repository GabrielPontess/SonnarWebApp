namespace Sonnar.WebApp.ViewModels
{
    public class RegistroViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public char Genero { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
