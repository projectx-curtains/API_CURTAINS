using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curtains.Domain.Models
{
    internal class CurtainMap : IEntityTypeConfiguration<CurtainModel>
    {
        public void Configure(EntityTypeBuilder<CurtainModel> builder)
        {
            builder.Property(e => e.Description)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(e => e.Price).HasColumnType("money");

            builder.Property(e => e.Title)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.HasOne(d => d.Bracing)
                .WithMany(p => p.Curtains)
                .HasForeignKey(d => d.BracingId)
                .HasConstraintName("FK_Curtains_Bracing");

            builder.HasOne(d => d.Fabric)
                .WithMany(p => p.Curtains)
                .HasForeignKey(d => d.FabricId)
                .HasConstraintName("FK_Curtains_Fabric");

            builder.HasOne(d => d.Manufacturer)
                .WithMany(p => p.Curtains)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Curtains_Manufacturer");

            builder.HasOne(d => d.Model)
                .WithMany(p => p.Curtains)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK_Curtains_Model");
        }
    }
}