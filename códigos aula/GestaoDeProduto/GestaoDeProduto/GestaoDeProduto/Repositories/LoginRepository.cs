using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public Login GetLogin(Login login)
        {
            var users = new List<Login>();
            users.Add(new Login { id = 1, usuario = "h1", senha = "123", role = "administrador" });
            users.Add(new Login { id = 2, usuario = "h2", senha = "456", role = "funcionario" });
            return users.Where(x => x.usuario.ToLower() == login.usuario.ToLower() && x.senha == login.senha).FirstOrDefault();

        }
    }
}
