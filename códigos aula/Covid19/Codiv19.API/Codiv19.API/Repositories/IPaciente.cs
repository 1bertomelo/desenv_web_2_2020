using Codiv19.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Repositories
{
    public interface IPaciente
    {
        public Paciente buscaPorId(int id);
        public IList<Paciente> buscaTodosPacientes();
        public void novoPaciente(Paciente paciente);
    }
}
