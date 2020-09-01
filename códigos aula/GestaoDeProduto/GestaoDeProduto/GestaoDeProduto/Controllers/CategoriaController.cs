using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProduto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get( ){ return Ok("Listagem de categoria"); }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) { return Ok("Detalhes da categoria"); }
        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria) { return Ok("Categoria criada com sucesso"); }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Categoria categoria) { return Ok("Categoria atualizada com sucesso"); }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) { return Ok("Categoria removida com sucesso!"); }

    }
}
