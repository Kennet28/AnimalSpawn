using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    public class GenusConfiguration : IEntityTypeConfiguration<Genus>
    {
        public void Configure(EntityTypeBuilder<Genus> builder)
        {
            builder.ToTable("Genus", "dbo");

            builder.Property(e => e.Code)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");
        }
    }
}
