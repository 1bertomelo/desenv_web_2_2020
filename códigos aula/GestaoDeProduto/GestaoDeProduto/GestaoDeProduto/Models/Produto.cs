using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string nome { get; set; }
        public decimal precoDeVenda { get; set; }
        public decimal precoDeCusto { get; set; }
        public string imagem { get; set; }
        public int quantidadeEstoque { get; set; }
        public int idCategoria { get; set; }
        public Categoria categoria { get; set; }
    }
}
