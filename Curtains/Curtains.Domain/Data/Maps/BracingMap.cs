using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Domain.Models
{
    internal class BracingMap : IEntityTypeConfiguration<BracingModel>
    {
        public void Configure(EntityTypeBuilder<BracingModel> builder)
        {
            builder.ToTable(nameof(BracingModel));

            builder.Property(e => e.Description)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.Price).HasColumnType("money");

            builder.Property(e => e.Title)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        }
    }
}