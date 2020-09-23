using GestaoDeProduto.Models;
using GestaoDeProduto.Validators;
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
        
        public Categoria BuscarCategoriaPorId(int pid)
        {
            //sintaxe linq
            //operador Where() fazer filtros
            //categoria quero filtrar uma categoria pelo id dela
            // colecao.Where( colocarVariavel => operacao relacional  );
            return listaCategorias.Where( x => x.id == pid).FirstOrDefault();
        }

        public void InserirCategoria(Categoria categoria) 
        {
            var validator = new CategoriaValidator();
            var validRes = validator.Validate(categoria);
            if (validRes.IsValid)
                listaCategorias.Add(categoria);
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }

        public IList<Categoria> ListarTodasCategorias()
        {
            return listaCategorias;
        }
    }
}
