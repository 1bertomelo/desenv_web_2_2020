using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Codiv19.API.Models;
using Codiv19.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codiv19.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly PacienteRepository pacienteRepository;

        public PacienteController()
        {
            pacienteRepository = new PacienteRepository();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Litagem de todos os pacientes");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("dados do paciente id");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Paciente paciente)
        {
            pacienteRepository.novoPaciente(paciente);
            return Ok("Paciente cadastrado com sucesso");
        }

        [HttpPut]
        public async Task<IActionResult> Put(Paciente paciente)
        {
            Paciente p = new Paciente();

            return Ok("Paciente atualizado com sucesso");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int  id)
        {
            return Ok("Paciente deleteado com sucesso");
        }

    }
}
