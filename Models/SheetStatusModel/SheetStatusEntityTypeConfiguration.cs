﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace pba_api.Models.SheetStatusModel
{
    public class SheetStatusEntityTypeConfiguration : IEntityTypeConfiguration<SheetStatus>
    {
        public void Configure(EntityTypeBuilder<SheetStatus> builder)
        {
            builder
                .UseCollation("utf8mb4_danish_ci")
                .HasCharSet("utf8mb4");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.SheetStatusName)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(x => x.SheetStatusColor)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(x => x.Global)
                .HasColumnType("bit");

            builder
                .Property(x => x.Default)
                .HasColumnType("bit");
        }
    }
}
