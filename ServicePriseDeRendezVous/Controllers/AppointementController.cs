// AppointementController.cs
using Microsoft.AspNetCore.Mvc;
using ServicePriseDeRendezVous.Models;
using ServicePriseDeRendezVous.Repositories;
using System.Collections.Generic;

namespace ServicePriseDeRendezVous.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointementController : ControllerBase
    {
        private readonly IRepositoryAppointement _repositoryAppointement;

        public AppointementController(IRepositoryAppointement repositoryAppointement)
        {
            _repositoryAppointement = repositoryAppointement;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Appointement>> GetAppointements()
        {
            var appointements = _repositoryAppointement.GetAppointements();
            return Ok(appointements);
        }

        [HttpGet("{id}")]
        public ActionResult<Appointement> GetAppointementById(int id)
        {
            var appointement = _repositoryAppointement.GetAppointementById(id);
            if (appointement == null)
            {
                return NotFound();
            }
            return Ok(appointement);
        }

        [HttpPost]
        public ActionResult<Appointement> AddAppointement(Appointement appointement)
        {
            _repositoryAppointement.AddAppointement(appointement);
            return CreatedAtAction(nameof(GetAppointementById), new { id = appointement.AppointmentId }, appointement);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAppointement(int id, Appointement appointement)
        {
            if (id != appointement.AppointmentId)
            {
                return BadRequest();
            }

            _repositoryAppointement.UpdateAppointement(appointement);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAppointement(int id)
        {
            _repositoryAppointement.DeleteAppointement(id);

            return NoContent();
        }
        // Ajoutez d'autres actions CRUD selon les besoins.
    }
}
