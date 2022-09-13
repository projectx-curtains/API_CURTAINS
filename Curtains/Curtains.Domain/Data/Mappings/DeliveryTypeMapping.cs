using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Curtains.Domain.Models;

namespace Curtains.Domain.Data
{
    internal class DeliveryTypeMapping : IEntityTypeConfiguration<DeliveryTypeModel>
    {
        public void Configure(EntityTypeBuilder<DeliveryTypeModel> builder)
        {
            builder.ToTable(nameof(DeliveryTypeModel));

            builder.Property(e => e.Price).HasColumnType("money");

            builder.Property(e => e.Title)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        }
    }
}