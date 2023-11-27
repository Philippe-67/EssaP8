// AgendaPraticienController.cs
using Microsoft.AspNetCore.Mvc;
using ServiceAgendaPraticiens.Models;
using ServiceAgendaPraticiens.Repositories;
using System.Collections.Generic;

namespace ServiceAgendaPraticiens.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendaPraticienController : ControllerBase
    {
        private readonly IRepositoryAgendaPraticien _repositoryAgendaPraticien;

        public AgendaPraticienController(IRepositoryAgendaPraticien repositoryAgendaPraticien)
        {
            _repositoryAgendaPraticien = repositoryAgendaPraticien;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AgendaPraticien>> GetAgendaPraticiens()
        {
            var agendaPraticiens = _repositoryAgendaPraticien.GetAgendaPraticiens();
            return Ok(agendaPraticiens);
        }

        [HttpGet("{id}")]
        public ActionResult<AgendaPraticien> GetAgendaPraticienById(int id)
        {
            var agendaPraticien = _repositoryAgendaPraticien.GetAgendaPraticienById(id);
            if (agendaPraticien == null)
            {
                return NotFound();
            }
            return Ok(agendaPraticien);
        }

        [HttpPost]
        public ActionResult<AgendaPraticien> AddAgendaPraticien(AgendaPraticien agendaPraticien)
        {
            _repositoryAgendaPraticien.AddAgendaPraticien(agendaPraticien);
            return CreatedAtAction(nameof(GetAgendaPraticienById), new { id = agendaPraticien.AgendaPraticienId }, agendaPraticien);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAgendaPraticien(int id, AgendaPraticien agendaPraticien)
        {
            if (id != agendaPraticien.AgendaPraticienId)
            {
                return BadRequest();
            }

            _repositoryAgendaPraticien.UpdateAgendaPraticien(agendaPraticien);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAgendaPraticien(int id)
        {
            _repositoryAgendaPraticien.DeleteAgendaPraticien(id);

            return NoContent();
        }
        // Ajoutez d'autres actions CRUD selon les besoins.
    }
}
