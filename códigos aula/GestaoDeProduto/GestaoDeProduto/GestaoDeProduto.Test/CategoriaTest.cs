using GestaoDeProduto.Context;
using GestaoDeProduto.Models;
using GestaoDeProduto.Repositories;
using GestaoDeProduto.Services;
using Moq;
using NUnit.Framework;
using System;

namespace GestaoDeProduto.Test
{
    public class Tests
    {

        [Test]
        public void InsereNovaCategoria()
        {
            Categoria novaCategoria = new Categoria();
            novaCategoria.titulo = "Teste";
            GestaoDeProdutoContext gestaoDeProduto = new GestaoDeProdutoContext();
            CategoriaRepository categoriaRepository = new CategoriaRepository(gestaoDeProduto);
            CategoriaService _service = new CategoriaService(categoriaRepository);
            int retorno = _service.insere(novaCategoria);
            Assert.Greater(retorno, 0);
        }


        [Test]
        public void TesteCategoriaNomeComNumero()
        {
            Categoria novaCategoria = new Categoria();
            novaCategoria.titulo = "teste1";
            GestaoDeProdutoContext gestaoDeProduto = new GestaoDeProdutoContext();
            CategoriaRepository categoriaRepository = new CategoriaRepository(gestaoDeProduto);
            CategoriaService _service = new CategoriaService(categoriaRepository);
            var ex = Assert.Throws<Exception>(() => _service.insere(novaCategoria));
            Assert.That(ex.Message, Is.EqualTo("Nome contem números , só é permitido letras"));            
        }


        [Test]
        public void TesteCategoriaTituloVazio()
        {
            Categoria novaCategoria = new Categoria();
            novaCategoria.titulo = "";
            GestaoDeProdutoContext gestaoDeProduto = new GestaoDeProdutoContext();
            CategoriaRepository categoriaRepository = new CategoriaRepository(gestaoDeProduto);
            CategoriaService _service = new CategoriaService(categoriaRepository);
            var ex = Assert.Throws<Exception>(() => _service.insere(novaCategoria));
            Assert.That(ex.Message, Is.EqualTo("Nome obrigatório."));
        }

        [Test]
        public void TesteCategoriaTituloEspaco()
        {
            Categoria novaCategoria = new Categoria();
            novaCategoria.titulo = "    ";
            GestaoDeProdutoContext gestaoDeProduto = new GestaoDeProdutoContext();
            CategoriaRepository categoriaRepository = new CategoriaRepository(gestaoDeProduto);
            CategoriaService _service = new CategoriaService(categoriaRepository);
            var ex = Assert.Throws<Exception>(() => _service.insere(novaCategoria));
            Assert.That(ex.Message, Is.EqualTo("Nome obrigatório."));
        }


    }
}