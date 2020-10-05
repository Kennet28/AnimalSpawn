using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    public class SightingConfiguration : IEntityTypeConfiguration<Sighting>
    {
        public void Configure(EntityTypeBuilder<Sighting> builder)
        {
            builder.ToTable("Sighting", "dbo");

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.Observation)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.RegisterDate).HasColumnType("datetime");

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.HasOne(d => d.Animal)
                .WithMany(p => p.Sighting)
                .HasForeignKey(d => d.AnimalId)
                .HasConstraintName("FK_Sighting_0");

            builder.HasOne(d => d.Researcher)
                .WithMany(p => p.Sighting)
                .HasForeignKey(d => d.ResearcherId)
                .HasConstraintName("FK_Sighting_1");
        }
    }
}
