// Dans ServicePriseDeRendezVous.Data.ContexteBDDPriseDeRendezVous.cs
using Microsoft.EntityFrameworkCore;
using ServicePriseDeRendezVous.Models;

namespace ServicePriseDeRendezVous.Data
{
    public class ContexteBDDPriseDeRendezVous : DbContext
    {
        public DbSet<Appointement> Appointements { get; set; }

        public ContexteBDDPriseDeRendezVous(DbContextOptions<ContexteBDDPriseDeRendezVous> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurez les relations, les clés primaires, etc., ici si nécessaire.

            // Exemple de configuration si nécessaire :
            // modelBuilder.Entity<Appointment>()
            //    .HasOne(a => a.Patient)
            //    .WithMany(p => p.Appointments)
            //    .HasForeignKey(a => a.PatientId);

            // Vous pouvez ajouter d'autres configurations ici en fonction de vos besoins.

            base.OnModelCreating(modelBuilder);
        }
    }
}
