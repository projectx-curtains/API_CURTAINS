using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Infrastructure.Models
{
    internal class UserOrderMap : IEntityTypeConfiguration<UserOrder>
    {
        public void Configure(EntityTypeBuilder<UserOrder> builder)
        {
            builder.ToTable(nameof(UserOrder));

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Cost).HasColumnType("money");

            builder.Property(e => e.Date).HasColumnType("date");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.UserOrder)
                .HasForeignKey<UserOrder>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOrder_Order1");
        }
    }
}