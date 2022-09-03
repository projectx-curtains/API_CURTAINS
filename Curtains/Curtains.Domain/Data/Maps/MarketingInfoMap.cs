using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Infrastructure.Models
{
    internal class MarketingInfoMap : IEntityTypeConfiguration<MarketingInfoModel>
    {
        public void Configure(EntityTypeBuilder<MarketingInfoModel> builder)
        {
            builder.ToTable(nameof(MarketingInfoModel));

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.IsInStock)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.MarketingInfo)
                .HasForeignKey<MarketingInfoModel>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarketingInfo_Curtains1");
        }
    }
}