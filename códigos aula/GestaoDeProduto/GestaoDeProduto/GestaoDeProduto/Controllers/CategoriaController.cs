using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using GestaoDeProduto.Context;
using GestaoDeProduto.Models;
using GestaoDeProduto.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController: ControllerBase
        
    {
        private CategoriaRepository _repository;

        public CategoriaController()
        {
            _repository = new CategoriaRepository();
        }

        [HttpGet]
        public async Task<IActionResult> Get( ){

            return Ok(_repository.ListarTodasCategorias()) ;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var categoriaResposta = _repository.BuscarCategoriaPorId(id);
            if (categoriaResposta == null){
                return NotFound();
            }
            return Ok(categoriaResposta); 
        }
        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria) {         
            _repository.InserirCategoria(categoria);
            return Ok("Categoria criada com sucesso"); 
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Categoria categoria) {
            _repository.AtualizarCategoria(id,categoria);
            return Ok("Categoria atualizada com sucesso"); 
        
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {

            _repository.RemoverCategoria(id);

            return Ok("Categoria removida com sucesso");

        }

    }
}
