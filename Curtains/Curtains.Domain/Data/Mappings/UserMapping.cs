using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Domain.Models
{
    internal class UserMapping : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable(nameof(UserModel));

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Address)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.Login)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.Password)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.User)
                .HasForeignKey<UserModel>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_UserOrder");

            builder.HasOne(d => d.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        }
    }
}