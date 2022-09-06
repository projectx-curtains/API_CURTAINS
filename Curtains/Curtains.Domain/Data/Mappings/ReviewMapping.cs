using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Domain.Models
{
    internal class ReviewMapping : IEntityTypeConfiguration<ReviewModel>
    {
        public void Configure(EntityTypeBuilder<ReviewModel> builder)
        {
            builder.ToTable(nameof(ReviewModel));

            builder.Property(r => r.PersonName)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(r => r.Country)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(r => r.City)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(r => r.Review)
                .HasMaxLength(260)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        }
    }
}
