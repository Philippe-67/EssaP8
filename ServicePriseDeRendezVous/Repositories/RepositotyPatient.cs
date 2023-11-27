// Dans ServicePriseDeRendezVous.Repositories.RepositoryPatient.cs
using Microsoft.EntityFrameworkCore;
using ServicePriseDeRendezVous.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServicePriseDeRendezVous.Repositories
{
    public class RepositoryPatient : IRepositoryPatient
    {
        private readonly ContexteBDDAppointement _context;

        public RepositoryPatient(ContexteBDDAppointement context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
            return _context.Patients.FirstOrDefault(p => p.PatientId == id);
        }

        public void AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeletePatient(int id)
        {
            var patient = _context.Patients.Find(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
        }
    }
}
