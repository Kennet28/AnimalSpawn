using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animal", "dbo");

            builder.Property(e => e.CaptureCondition)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.CaptureDate).HasColumnType("datetime");

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.HasOne(d => d.Family)
                .WithMany(p => p.Animal)
                .HasForeignKey(d => d.FamilyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_1");

            builder.HasOne(d => d.Genus)
                .WithMany(p => p.Animal)
                .HasForeignKey(d => d.GenusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_2");

            builder.HasOne(d => d.Species)
                .WithMany(p => p.Animal)
                .HasForeignKey(d => d.SpeciesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_0");

        }
    }
}
