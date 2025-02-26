﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace pba_api.Models.UserModel
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .UseCollation("utf8mb4_danish_ci")
                .HasCharSet("utf8mb4");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(500);

            builder
                .Property(x => x.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(500);

            builder
                .Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            
            builder
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .Property(x => x.Password)
                .HasColumnType("varchar")
                .HasMaxLength(2400);
        }
    }
}
