using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Infrastructure.Models
{
    internal class OrderCurtainMap : IEntityTypeConfiguration<OrderCurtain>
    {
        public void Configure(EntityTypeBuilder<OrderCurtain> builder)
        {
            builder.HasOne(d => d.Curtains)
                 .WithMany(p => p.OrderCurtains)
                 .HasForeignKey(d => d.CurtainsId)
                 .HasConstraintName("FK_OrderCurtains_Curtains");

            builder.HasOne(d => d.Order)
                .WithMany(p => p.OrderCurtains)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderCurtains_Order");
        }
    }
}