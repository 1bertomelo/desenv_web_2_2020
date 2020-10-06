using Codiv19.API.Models;
using Codiv19.API.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Repositories
{
    public class PacienteRepository : IPaciente
    {
        private IList<Paciente> pacientesLista;

        public PacienteRepository()
        {
            pacientesLista = new List<Paciente>();
        }

        public Paciente buscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Paciente> buscaTodosPacientes()
        {
            throw new NotImplementedException();
        }

        public void novoPaciente(Paciente paciente)
        {
            var validator = new PacienteValidator();
            var validRes = validator.Validate(paciente);
            if (validRes.IsValid)
            {
                pacientesLista.Add(paciente);
            }
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }
    }
    
}
