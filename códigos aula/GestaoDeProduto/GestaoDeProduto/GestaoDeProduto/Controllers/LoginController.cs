using GestaoDeProduto.Models;
using GestaoDeProduto.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginRepository _repository;

        public LoginController()
        {
            _repository = new LoginRepository();
        }



        [AllowAnonymous]
        [HttpPost]
        [Route("autenticacao")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Login model)
        {
            var user = _repository.GetLogin(model);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.senha = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
