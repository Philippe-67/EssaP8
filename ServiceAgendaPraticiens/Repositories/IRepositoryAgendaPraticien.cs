
// IRepositoryAgendaPraticien.cs
using ServiceAgendaPraticiens.Models;
using System.Collections.Generic;

namespace ServiceAgendaPraticiens.Repositories
{
    public interface IRepositoryAgendaPraticien
    {
        IEnumerable<AgendaPraticien> GetAgendaPraticiens();
        AgendaPraticien GetAgendaPraticienById(int id);
        void AddAgendaPraticien(AgendaPraticien agendaPraticien);
        void UpdateAgendaPraticien(AgendaPraticien agendaPraticien);
        void DeleteAgendaPraticien(int id);
        // Ajoutez d'autres méthodes CRUD selon les besoins.
    }
}

