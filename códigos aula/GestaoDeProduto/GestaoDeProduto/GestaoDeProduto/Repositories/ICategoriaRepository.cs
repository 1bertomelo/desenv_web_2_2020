using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public interface ICategoriaRepository
    {
        public IList<Categoria> ListarTodasCategorias();

        public Categoria BuscarCategoriaPorId(int id);

        public void InserirCategoria(Categoria categoria);

        public void RemoverCategoria(int id);

        public void AtualizarCategoria(int id, Categoria categoria);

    }
}
