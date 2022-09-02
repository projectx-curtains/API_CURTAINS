using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Infrastructure.Models
{
    internal class MarketingInfoMap : IEntityTypeConfiguration<MarketingInfo>
    {
        public void Configure(EntityTypeBuilder<MarketingInfo> builder)
        {
            builder.ToTable(nameof(MarketingInfo));

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.IsInStock)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.MarketingInfo)
                .HasForeignKey<MarketingInfo>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarketingInfo_Curtains1");
        }
    }
}