using GestaoDeProduto.Context;
using GestaoDeProduto.Models;
using GestaoDeProduto.Validators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public class CategoriaRepository
    {
        private GestaoDeProdutoContext context;

        public CategoriaRepository()
        {
            context = new GestaoDeProdutoContext();
        }
        
        public Categoria BuscarCategoriaPorId(int pid)
        {
            return context.categorias.ToList().Where(x => x.id == pid).FirstOrDefault();
        }

        public void InserirCategoria(Categoria categoria)
        {
            var validator = new CategoriaValidator();
            var validRes = validator.Validate(categoria);
            if (validRes.IsValid)  {
                context.categorias.Add(categoria);
                context.SaveChanges();
            }
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }

        public IList<Categoria> ListarTodasCategorias()
        {
            return context.categorias.ToList();
        }
    }
}
