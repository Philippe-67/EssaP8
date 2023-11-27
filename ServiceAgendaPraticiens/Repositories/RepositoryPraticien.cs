using ServiceAgendaPraticiens.Data;
using ServiceAgendaPraticiens.Models;
using System.Collections.Generic;
using System.Linq;

using ServiceAgendaPraticiens.Data;
using ServiceAgendaPraticiens.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceAgendaPraticiens.Repositories
{
    public class RepositoryPraticien : IRepositoryPraticien
    {
        private readonly ContexteBDDAgendaPraticiens _context;

        public RepositoryPraticien(ContexteBDDAgendaPraticiens context)
        {
            _context = context;
        }

        public IEnumerable<Praticien> GetPraticiens()
        {
            return _context.Praticiens.ToList();
        }

        public Praticien GetPraticienById(int praticienId)
        {
            return _context.Praticiens.FirstOrDefault(p => p.PraticienId == praticienId);
        }

        public void AddPraticien(Praticien praticien)
        {
            _context.Praticiens.Add(praticien);
            _context.SaveChanges();
        }

        public void UpdatePraticien(Praticien praticien)
        {
            _context.Praticiens.Update(praticien);
            _context.SaveChanges();
        }

        public void DeletePraticien(int praticienId)
        {
            var praticien = _context.Praticiens.Find(praticienId);
            if (praticien != null)
            {
                _context.Praticiens.Remove(praticien);
                _context.SaveChanges();
            }
        }

        // Ajoutez d'autres méthodes CRUD ici selon les besoins.
    }
}

