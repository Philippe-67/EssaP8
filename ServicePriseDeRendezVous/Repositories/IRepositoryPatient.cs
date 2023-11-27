// Dans ServicePriseDeRendezVous.Repositories.IRepositoryPatient.cs
using ServicePriseDeRendezVous.Models;
using System.Collections.Generic;

namespace ServicePriseDeRendezVous.Repositories
{
    public interface IRepositoryPatient
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatientById(int id);
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(int id);
    }
}
