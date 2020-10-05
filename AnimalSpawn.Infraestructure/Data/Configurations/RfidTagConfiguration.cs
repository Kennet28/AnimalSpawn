using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    public class RfidTagConfiguration : IEntityTypeConfiguration<RfidTag>
    {
        public void Configure(EntityTypeBuilder<RfidTag> builder)
        {
            builder.ToTable("RFIdTag", "dbo");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.DateEstablished).HasColumnType("datetime");

            builder.Property(e => e.Tag)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.RfidTag)
                .HasForeignKey<RfidTag>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIdTag_0");

            builder.HasOne(d => d.ProtectedArea)
                .WithMany(p => p.RfidTag)
                .HasForeignKey(d => d.ProtectedAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFIdTag_1");
        }
    }
}
