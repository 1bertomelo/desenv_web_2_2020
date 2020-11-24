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

        public CategoriaRepository(GestaoDeProdutoContext _context)
        {
            context = _context;// new GestaoDeProdutoContext();
        }

        public void AtualizarCategoria(Categoria categoria)
        {            
            context.Entry(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

        }

        public Categoria BuscarCategoriaPorId(int pid)
        {
            return context.categorias.ToList().Where(x => x.id == pid).FirstOrDefault();
        }

        public int InserirCategoria(Categoria categoria)
        {
                context.categorias.Add(categoria);
                context.SaveChanges();
                return categoria.id;
        }

        public IList<Categoria> ListarTodasCategorias()
        {
            return context.categorias.ToList();
        }

        public IList<Categoria> BuscarCategoriaPorTitulo(string titulo)
        {
            return context.categorias.Where( c => c.titulo.StartsWith(titulo)).ToList();
        }

        public void RemoverCategoria(Categoria categoria)
        {           
            context.categorias.Remove(categoria);
            context.SaveChanges();
        }
    }
}
