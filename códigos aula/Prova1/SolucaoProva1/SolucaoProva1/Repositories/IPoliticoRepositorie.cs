using SolucaoProva1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoProva1.Repositories
{
    public interface IPoliticoRepositorie
    {
        //quais os metodos sao necessarios para implementar CRUD
        public void Inserir(Politico politico);
        public Politico buscar(int id);
        public IList<Politico> buscarTodosPoliticos();


    }
}
