﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pba_api.Models.AdditionalExpensesModel;

namespace pba_api.Models.AdditionalExpenseModel
{
    public class AdditionalExpenseEntityTypeConfiguration : IEntityTypeConfiguration<AdditionalExpense>
    {
        public void Configure(EntityTypeBuilder<AdditionalExpense> builder)
        {
            builder
                .UseCollation("utf8mb4_danish_ci")
                .HasCharSet("utf8mb4");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.ExpenseName)
                .HasColumnType("varchar")
                .HasMaxLength(250);

            builder
                .Property(x => x.Price)
                .HasColumnType("float");

            builder
                .Property(x => x.Continuous)
                .HasColumnType("bit");

            #region EntityRelations
            builder
                .HasOne(x => x.EstimateSheet)
                .WithMany(a => a.AdditionalExpenses)
                .HasForeignKey(x => x.EstimateSheetId);
            #endregion
        }
    }
}
