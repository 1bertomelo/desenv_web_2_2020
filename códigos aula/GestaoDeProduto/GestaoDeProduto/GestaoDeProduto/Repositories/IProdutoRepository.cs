using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public interface IProdutoRepository
    {
        //CRUD 
        //listar todos os produtos
        //public + retorno + nome do metodo(parametros)
        public IList<Produto> ListaTodosProdutos();
        //buscar um produto especifico pelo id
        public Produto BuscaProdutoPorId(int id);
        //cadastrar um novo produto
        public void InsereProduto(Produto produto);


    }
}
