using Microsoft.EntityFrameworkCore;
using ServiceAgendaPraticiens.Models;

namespace ServiceAgendaPraticiens.Data
{
    public class ContexteBDDAgendaPraticiens: DbContext
    {
        public DbSet<Praticien> Praticiens { get; set; }
        public DbSet<AgendaPraticien> AgendaPraticiens { get; set; }

        public ContexteBDDAgendaPraticiens(DbContextOptions<ContexteBDDAgendaPraticiens> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurez les relations, les clés primaires, etc., ici si nécessaire.

            modelBuilder.Entity<AgendaPraticien>();
                //.HasOne(ap => ap.Praticien)
                //.WithMany(p => p.AgendaPraticien)
                //.HasForeignKey(ap => ap.PraticienId);

            // Vous pouvez ajouter d'autres configurations ici en fonction de vos besoins.

            base.OnModelCreating(modelBuilder);
        }
    }
}

