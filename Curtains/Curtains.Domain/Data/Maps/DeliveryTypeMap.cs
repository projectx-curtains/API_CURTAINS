using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Domain.Models
{
    internal class DeliveryTypeMap : IEntityTypeConfiguration<DeliveryTypeModel>
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