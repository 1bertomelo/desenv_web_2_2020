using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolucaoProva1.Model;
using SolucaoProva1.Repositories;

namespace SolucaoProva1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliticoController : ControllerBase
    {
        private PoliticoRepositorie _repository;

        public PoliticoController()
        {
            _repository = new PoliticoRepositorie();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(_repository.buscarTodosPoliticos());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var politicoBusca = _repository.buscar(id);
            if(politicoBusca == null)
            {
                return NotFound();
            }
            return Ok(politicoBusca);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Politico politico)
        {
            _repository.Inserir(politico);
            return Ok("Inserido com sucesso");
        }

    }
}
