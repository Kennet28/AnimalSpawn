using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("Photo", "dbo");

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.Property(e => e.Url)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.HasOne(d => d.Animal)
                .WithMany(p => p.Photo)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Photo_0");
        }
    }
}
