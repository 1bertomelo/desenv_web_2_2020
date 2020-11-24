using GestaoDeProduto.Models;
using GestaoDeProduto.Repositories;
using GestaoDeProduto.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Services
{
    public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;// new CategoriaRepository();
        }

        public void atualizar(int id , Categoria categoria)
        {
            var resultadoCategoria = this.buscaPorId(id);
            if (resultadoCategoria == null)
            {
                throw new ArgumentException("Categoria não existe");
            }
            categoria.id = id;
            _repository.AtualizarCategoria(categoria);
        }

        public Categoria buscaPorId(int id)
        {
            return _repository.BuscarCategoriaPorId(id);
        }

        public IList<Categoria> buscaPorTitulo(string titulo)
        {
            return _repository.BuscarCategoriaPorTitulo(titulo);
        }

     

        public IList<Categoria> buscaTodasCategorias()
        {
            return _repository.ListarTodasCategorias();
        }

        public int insere(Categoria categoria)
        {
            var validator = new CategoriaValidator();
            var validRes = validator.Validate(categoria);
            if (validRes.IsValid)
            {
               return _repository.InserirCategoria(categoria);
            }
             else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }

        public void remover(int id)
        {
            var resultadoCategoria = buscaPorId(id);
            if (resultadoCategoria == null)
            {
                throw new ArgumentException("Categoria não existe");
            }
            _repository.RemoverCategoria(resultadoCategoria);
        }
    }
}
