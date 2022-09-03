using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Infrastructure.Models
{
    internal class FabricMap : IEntityTypeConfiguration<FabricModel>
    {
        public void Configure(EntityTypeBuilder<FabricModel> builder)
        {
            builder.ToTable(nameof(FabricModel));

            builder.Property(e => e.Description)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.Price).HasColumnType("money");

            builder.HasOne(d => d.Color)
                .WithMany(p => p.Fabrics)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_Fabric_Color");

            builder.HasOne(d => d.Decoration)
                .WithMany(p => p.Fabrics)
                .HasForeignKey(d => d.DecorationId)
                .HasConstraintName("FK_Fabric_Decoration");

            builder.HasOne(d => d.Material)
                .WithMany(p => p.Fabrics)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_Fabric_Material");
        }
    }
}