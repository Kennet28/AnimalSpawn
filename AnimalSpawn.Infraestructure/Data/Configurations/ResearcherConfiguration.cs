using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    class ResearcherConfiguration : IEntityTypeConfiguration<Researcher>
    {
        public void Configure(EntityTypeBuilder<Researcher> builder)
        {
            builder.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.DateBirth).HasColumnType("date");

            builder.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.FirstName)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Status).HasDefaultValueSql("((1))");

            builder.Property(e => e.Telephone)
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.HasOne(d => d.ProtectedArea)
                .WithMany(p => p.Researcher)
                .HasForeignKey(d => d.ProtectedAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Researcher_0");
        }
    }
}
