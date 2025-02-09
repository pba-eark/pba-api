﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace pba_api.Models.RoleModel
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .UseCollation("utf8mb4_danish_ci")
                .HasCharSet("utf8mb4");

            builder
                .HasKey(x => x.Id);
            
            builder
                .Property(x => x.Global)
                .HasColumnType("bit");

            builder
                .Property(x => x.RoleName)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(x => x.HourlyWage)
                .HasColumnType("float");
        }
    }
}
