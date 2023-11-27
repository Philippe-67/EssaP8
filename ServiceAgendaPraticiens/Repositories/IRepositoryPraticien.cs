using ServiceAgendaPraticiens.Models;

namespace ServiceAgendaPraticiens.Repositories
{
    public interface IRepositoryPraticien
    {
        IEnumerable<Praticien> GetPraticiens();
        Praticien GetPraticienById(int praticienId);
        void AddPraticien(Praticien praticien);
        void UpdatePraticien(Praticien praticien);
        void DeletePraticien(int praticienId);

        // Ajoutez d'autres méthodes selon les besoins.
    }
}


