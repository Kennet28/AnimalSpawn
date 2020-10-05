using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AnimalSpawn.Infraestructure.Data
{
    public partial class AnimalSpawnContext : DbContext
    {

        public AnimalSpawnContext(DbContextOptions<AnimalSpawnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<Genus> Genus { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<ProtectedArea> ProtectedArea { get; set; }
        public virtual DbSet<Researcher> Researcher { get; set; }
        public virtual DbSet<RfidTag> RfidTag { get; set; }
        public virtual DbSet<Sighting> Sighting { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new FamilyConfiguration());
            modelBuilder.ApplyConfiguration(new GenusConfiguration());
            modelBuilder.ApplyConfiguration(new PhotoConfiguration());
            modelBuilder.ApplyConfiguration(new ProtectedAreaConfiguration());
            modelBuilder.ApplyConfiguration(new ResearcherConfiguration());
            modelBuilder.ApplyConfiguration(new RfidTagConfiguration());
            modelBuilder.ApplyConfiguration(new SightingConfiguration());
            modelBuilder.ApplyConfiguration(new SpeciesConfiguration());
            modelBuilder.ApplyConfiguration(new UserAcountConfiguration());
        }


    }
}
