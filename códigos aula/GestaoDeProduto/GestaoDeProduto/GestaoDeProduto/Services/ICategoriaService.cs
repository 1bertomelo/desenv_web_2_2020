using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Services
{
     public interface ICategoriaService
    {
        public int insere(Categoria categoria);

        public Categoria buscaPorId(int id);

        public IList<Categoria> buscaPorTitulo(string titulo);


        public IList<Categoria> buscaTodasCategorias();

        public void atualizar(int id, Categoria categoria);

        public void remover(int id);

    }
}
