// Dans ServicePriseDeRendezVous.Repositories.IRepositoryAppointement.cs
using ServicePriseDeRendezVous.Models;
using System.Collections.Generic;

namespace ServicePriseDeRendezVous.Repositories
{
    public interface IRepositoryAppointment
    {
        IEnumerable<Appointement> GetAppointments();
        Appointement GetAppointmentById(int id);
        void AddAppointment(Appointement appointment);
        void UpdateAppointment(Appointement appointment);
        void DeleteAppointment(int id);
    }
}
