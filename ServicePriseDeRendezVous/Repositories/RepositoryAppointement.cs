// Dans ServicePriseDeRendezVous.Repositories.RepositoryAppointment.cs
using Microsoft.EntityFrameworkCore;
using ServicePriseDeRendezVous.Data;
using ServicePriseDeRendezVous.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServicePriseDeRendezVous.Repositories
{
    public class RepositoryAppointment : IRepositoryAppointement
    {
        private readonly ContexteBDDPriseDeRendezVous _context;

        public RepositoryAppointment(ContexteBDDPriseDeRendezVous context)
        {
            _context = context;
        }

        public IEnumerable<Appointement> GetAppointments()
        {
            return _context.Appointements.ToList();
        }

        public Appointement GetAppointmentById(int id)
        {
            return _context.Appointements.FirstOrDefault(a => a.AppointmentId == id);
        }

        public void AddAppointment(Appointement appointement)
        {
            _context.Appointements.Add(appointement);
            _context.SaveChanges();
        }

        public void UpdateAppointement(Appointement appointement)
        {
            _context.Entry(appointement).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAppointment(int id)
        {
            var appointement = _context.Appointements.Find(id);
            if (appointement != null)
            {
                _context.Appointements.Remove(appointement);
                _context.SaveChanges();
            }
        }
    }
}
