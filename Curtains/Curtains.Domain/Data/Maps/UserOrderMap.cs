using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Domain.Models
{
    internal class UserOrderMap : IEntityTypeConfiguration<UserOrderModel>
    {
        public void Configure(EntityTypeBuilder<UserOrderModel> builder)
        {
            builder.ToTable(nameof(UserOrderModel));

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Cost).HasColumnType("money");

            builder.Property(e => e.Date).HasColumnType("date");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.UserOrder)
                .HasForeignKey<UserOrderModel>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOrder_Order1");
        }
    }
}