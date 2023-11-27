using Microsoft.AspNetCore.Mvc;
using ServiceAgendaPraticiens.Models;
using ServiceAgendaPraticiens.Repositories;
using System.Collections.Generic;

namespace ServiceAgendaPraticiens.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PraticienController : ControllerBase
    {
        private readonly IRepositoryPraticien _repositoryPraticien;

        public PraticienController(IRepositoryPraticien repositoryPraticien)
        {
            _repositoryPraticien = repositoryPraticien;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Praticien>> GetPraticiens()
        {
            var praticiens = _repositoryPraticien.GetPraticiens();
            return Ok(praticiens);
        }

        [HttpGet("{id}")]
        public ActionResult<Praticien> GetPraticienById(int id)
        {
            var praticien = _repositoryPraticien.GetPraticienById(id);

            if (praticien == null)
            {
                return NotFound();
            }

            return Ok(praticien);
        }

        [HttpPost]
        public IActionResult AddPraticien(Praticien praticien)
        {
            _repositoryPraticien.AddPraticien(praticien);
            return CreatedAtAction(nameof(GetPraticienById), new { id = praticien.PraticienId }, praticien);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePraticien(int id, Praticien praticien)
        {
            if (id != praticien.PraticienId)
            {
                return BadRequest();
            }

            _repositoryPraticien.UpdatePraticien(praticien);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePraticien(int id)
        {
            _repositoryPraticien.DeletePraticien(id);
            return NoContent();
        }
    }
}
