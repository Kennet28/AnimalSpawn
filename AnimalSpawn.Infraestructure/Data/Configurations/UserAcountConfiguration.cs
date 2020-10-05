using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    public class UserAcountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.ToTable("UserAccount", "dbo");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.UserAccount)
                .HasForeignKey<UserAccount>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_0");
        }
    }
}
