using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using GestaoDeProduto.Context;
using GestaoDeProduto.Models;
using GestaoDeProduto.Repositories;
using GestaoDeProduto.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "administrador")]
    public class CategoriaController: ControllerBase
        
    {
        private readonly ICategoriaService _services;

        public CategoriaController(ICategoriaService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> Get( ){

            return Ok(_services.buscaTodasCategorias()) ;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var categoriaResposta = _services.buscaPorId(id);
            if (categoriaResposta == null){
                return NotFound();
            }
            return Ok(categoriaResposta); 
        }

        [HttpGet("buscartitulo/{titulo}")]      
        public async Task<IActionResult> Get(string titulo)
        {
            var categoriaResposta = _services.buscaPorTitulo(titulo);
            if (categoriaResposta == null)
            {
                return NotFound();
            }
            return Ok(categoriaResposta);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria) {         
            _services.insere(categoria);
            return Ok("Categoria criada com sucesso"); 
        }
        [HttpPut("{id}")]
         public async Task<IActionResult> Put(int id, Categoria categoria) {
            _services.atualizar(id,categoria);
            return Ok("Categoria atualizada com sucesso"); 
        
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {

            _services.remover(id);

            return Ok("Categoria removida com sucesso");

        }

    }
}
