using GestaoDeProduto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Context
{
    public class GestaoDeProdutoContext : DbContext
    {
        public GestaoDeProdutoContext()
        {

        }

        public GestaoDeProdutoContext(DbContextOptions<GestaoDeProdutoContext> options) : base(options)
        {
        }

        public virtual DbSet<Produto> produto { get; set; }
        public virtual DbSet<Categoria> categoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                        .AddJsonFile("appsettings.json")
                                        .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("ProdutoDataBase"));
            }
        }
    }
}
