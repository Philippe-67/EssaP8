// Dans ServicePriseDeRendezVous.Controllers.PatientController.cs
using Microsoft.AspNetCore.Mvc;
using ServicePriseDeRendezVous.Models;
using ServicePriseDeRendezVous.Repositories;
using System.Collections.Generic;

namespace ServicePriseDeRendezVous.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IRepositoryPatient _repositoryPatient;

        public PatientController(IRepositoryPatient repositoryPatient)
        {
            _repositoryPatient = repositoryPatient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Patient>> GetPatients()
        {
            var patients = _repositoryPatient.GetPatients();
            return Ok(patients);
        }

        // Ajoutez d'autres méthodes CRUD ici.
    }
}
