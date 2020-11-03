using GestaoDeProduto.Context;
using GestaoDeProduto.Models;
using GestaoDeProduto.Validators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private GestaoDeProdutoContext context;

        public CategoriaRepository()
        {
            context = new GestaoDeProdutoContext();
        }

        public void AtualizarCategoria(int id, Categoria categoria)
        {
            //var resultadoCategoria = BuscarCategoriaPorId(id);
            //if (resultadoCategoria == null)
            //{
            //    throw new ArgumentException("Categoria não existe");
            //}
            context.Entry(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

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

        public void RemoverCategoria(int id)
        {
            var resultadoCategoria = BuscarCategoriaPorId(id);
           if (resultadoCategoria == null)
           {
                throw new ArgumentException("Categoria não existe");
           }
            context.categorias.Remove(resultadoCategoria);
            context.SaveChanges();
        }
    }
}
