using SolucaoProva1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoProva1.Repositories
{
    public class PoliticoRepositorie : IPoliticoRepositorie
    { //como isso vai ser persisitido
        private IList<Politico> listaPolitico = new List<Politico>();
        public Politico buscar(int id)
        {
            listaPolitico.Add(new Politico() { nome = "teste", cargo = "prefeito", numero = 10, id = 1, partido = "pp" });
            return listaPolitico.Where(p => p.id == id).FirstOrDefault();
        }

        public IList<Politico> buscarTodosPoliticos()
        {
            listaPolitico.Add(new Politico() { nome = "teste", cargo = "prefeito", numero = 10, id = 1, partido = "pp" });

            return listaPolitico;
        }

        public void Inserir(Politico politico)
        {
            listaPolitico.Add(politico);
        }
    }
}
