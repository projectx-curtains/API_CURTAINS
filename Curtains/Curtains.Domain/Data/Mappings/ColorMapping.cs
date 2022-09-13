using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Curtains.Domain.Models;

namespace Curtains.Domain.Data
{
    internal class ColorMapping : IEntityTypeConfiguration<ColorModel>
    {
        public void Configure(EntityTypeBuilder<ColorModel> builder)
        {
            builder.ToTable(nameof(ColorModel));

            builder.Property(e => e.Code)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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