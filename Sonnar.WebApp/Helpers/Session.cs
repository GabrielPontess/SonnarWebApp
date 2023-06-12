using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Sonnar.Domain.Models;

namespace Sonnar.WebApp.Helpers
{
    public class Session : ISession
    {
        private IHttpContextAccessor _contextAccessor;
        public static Usuario UsuarioAutenticado { get; set; }

        public Session(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public Usuario BuscarSessaoUsuario()
        {
            string userSession = _contextAccessor.HttpContext.Session.GetString("userSession");

            if (userSession == null){
                UsuarioAutenticado = null;
                return UsuarioAutenticado;
            };

            UsuarioAutenticado = JsonConvert.DeserializeObject<Usuario>(userSession);
            return UsuarioAutenticado;   
        }

        public void CriarSessaoDeUsuario(Usuario usuario)
        {
            UsuarioAutenticado = usuario;
            string usuarioJson = JsonConvert.SerializeObject(usuario);
            _contextAccessor.HttpContext.Session.SetString("userSession",usuarioJson);
        }

        public void RemoverSessaoUsuario()
        {
            _contextAccessor.HttpContext.Session.Remove("userSession");
            UsuarioAutenticado = null;
        }
    }
}
