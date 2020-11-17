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

        public IList<Categoria> BuscarCategoriaPorTitulo(string titulo);

        public Categoria BuscarCategoriaPorId(int id);

        public int InserirCategoria(Categoria categoria);

        public void RemoverCategoria(Categoria categoria);

        public void AtualizarCategoria(Categoria categoria);

    }
}
