using GestaoDeProduto.Context;
using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public class LoginRepository : ILoginRepository
    {

        private GestaoDeProdutoContext context;

        public LoginRepository(GestaoDeProdutoContext _context)
        {
            context = _context; //new GestaoDeProdutoContext();
        }

        //public Login GetLogin(Login login)
        //{
        //    var users = new List<Login>();
        //    users.Add(new Login { id = 1, usuario = "h1", senha = "123", role = "administrador" });
        //    users.Add(new Login { id = 2, usuario = "h2", senha = "456", role = "funcionario" });
        //    return users.Where(x => x.usuario.ToLower() == login.usuario.ToLower() && x.senha == login.senha).FirstOrDefault();

        //}

        public Login GetLogin(Login login)
        {
            var resultado = context.logins.Where(l => l.usuario == login.usuario && l.senha == login.senha).FirstOrDefault();
            return resultado;
        }
    }
}
