using System;
using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AnimalSpawn.Infraestructure.Data
{
    public partial class AnimalSpawnContext : DbContext
    {
        public AnimalSpawnContext()
        {
        }

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
            modelBuilder.ApplyConfiguration<Animal>(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
            modelBuilder.ApplyConfiguration<Family>(new FamilyConfiguration());
            modelBuilder.ApplyConfiguration<Genus>(new GenusConfiguration());
            modelBuilder.ApplyConfiguration<Photo>(new PhotoConfiguration());
            modelBuilder.ApplyConfiguration<ProtectedArea>(new ProtectedAreaConfiguration());
            modelBuilder.ApplyConfiguration<Researcher>(new ResearcherConfiguration());
            modelBuilder.ApplyConfiguration<RfidTag>(new RfidTagConfiguration());
            modelBuilder.ApplyConfiguration<Sighting>(new SightingConfiguration());
            modelBuilder.ApplyConfiguration<Species>(new SpeciesConfiguration());
            modelBuilder.ApplyConfiguration<UserAccount>(new UserAccountConfiguration());
        }        
    }
}