using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    class ProtectedAreaConfiguration : IEntityTypeConfiguration<ProtectedArea>
    {
        public void Configure(EntityTypeBuilder<ProtectedArea> builder)
        {
            builder.Property(e => e.Area).HasColumnType("decimal(10, 0)");

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Status).HasDefaultValueSql("((1))");

            builder.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.HasOne(d => d.Country)
                .WithMany(p => p.ProtectedArea)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProtectedArea_0");
        }
    }
}
