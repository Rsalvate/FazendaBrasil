using FazendaBrasil.Domain;
using Microsoft.EntityFrameworkCore;

namespace FazendaBrasil.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cattle> Cattles { get; set; }
        public DbSet<Frequency> Frequencies { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<AnimalMedication> AnimalMedications { get; set; }
        public DbSet<CattleAnimal> CattleAnimals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalMedication>()
                .HasKey(c => new { c.Id, c.AnimalId, c.MedicationId });

            modelBuilder.Entity<CattleAnimal>()
                .HasKey(c => new { c.CattleId, c.AnimalId });
        }
    }
}
