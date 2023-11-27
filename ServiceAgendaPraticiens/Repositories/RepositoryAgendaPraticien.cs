// RepositoryAgendaPraticien.cs
using Microsoft.EntityFrameworkCore;
using ServiceAgendaPraticiens.Data;
using ServiceAgendaPraticiens.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceAgendaPraticiens.Repositories
{
    public class RepositoryAgendaPraticien : IRepositoryAgendaPraticien
    {
        private readonly ContexteBDDAgendaPraticiens _context;

        public RepositoryAgendaPraticien(ContexteBDDAgendaPraticiens context)
        {
            _context = context;
        }

        public IEnumerable<AgendaPraticien> GetAgendaPraticiens()
        {
            return _context.AgendaPraticiens.ToList();
        }

        public AgendaPraticien GetAgendaPraticienById(int id)
        {
            return _context.AgendaPraticiens.Find(id);
        }

        public void AddAgendaPraticien(AgendaPraticien agendaPraticien)
        {
            _context.AgendaPraticiens.Add(agendaPraticien);
            _context.SaveChanges();
        }

        public void UpdateAgendaPraticien(AgendaPraticien agendaPraticien)
        {
            _context.Entry(agendaPraticien).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAgendaPraticien(int id)
        {
            var agendaPraticien = _context.AgendaPraticiens.Find(id);
            if (agendaPraticien != null)
            {
                _context.AgendaPraticiens.Remove(agendaPraticien);
                _context.SaveChanges();
            }
        }

        // Ajoutez d'autres méthodes CRUD selon les besoins.
    }
}
