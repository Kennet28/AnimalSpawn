using AnimalSpawn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Infraestructure.Data.Configurations
{
    class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.IsActive).HasDefaultValueSql("((1))");

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

            builder.Ignore(d => d.CreateAt);
            builder.Ignore(d => d.CreatedBy);
            builder.Ignore(d => d.UpdateAt);
            builder.Ignore(d => d.Status);
        }
    }
}
