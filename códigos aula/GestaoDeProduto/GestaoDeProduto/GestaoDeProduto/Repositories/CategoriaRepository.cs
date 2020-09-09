using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private IList<Categoria> listaCategorias = new List<Categoria>();
        public CategoriaRepository()
        {
            listaCategorias.Add(new Categoria() { id = 1, titulo = "Eletronicos" });
            listaCategorias.Add(new Categoria() { id = 2, titulo = "Telefonia" });
        }

        public Categoria BuscarCategoriaPorId(int id)
        {
            //sintaxe linq
            return listaCategorias.Where( x => x.id == id).FirstOrDefault();
        }

        public void InserirCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarTodasCategorias()
        {
            return listaCategorias;
        }
    }
}
