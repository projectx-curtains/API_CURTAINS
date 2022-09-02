using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Curtains.Infrastructure.Models
{
    public partial class CurtainsContext : DbContext
    {
        IConfiguration _config;

        public CurtainsContext(IConfiguration config)
        {
            _config = config;
        }

        public virtual DbSet<Bracing> Bracings { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Curtain> Curtains { get; set; } = null!;
        public virtual DbSet<Decoration> Decorations { get; set; } = null!;
        public virtual DbSet<DeliveryType> DeliveryTypes { get; set; } = null!;
        public virtual DbSet<Fabric> Fabrics { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<MarketingInfo> MarketingInfos { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderCurtain> OrderCurtains { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserOrder> UserOrders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation(_config["DbCollation"]);

            modelBuilder.Entity<Bracing>(entity =>
            {
                entity.ToTable("Bracing");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Curtain>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Bracing)
                    .WithMany(p => p.Curtains)
                    .HasForeignKey(d => d.BracingId)
                    .HasConstraintName("FK_Curtains_Bracing");

                entity.HasOne(d => d.Fabric)
                    .WithMany(p => p.Curtains)
                    .HasForeignKey(d => d.FabricId)
                    .HasConstraintName("FK_Curtains_Fabric");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Curtains)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Curtains_Manufacturer");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Curtains)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_Curtains_Model");
            });

            modelBuilder.Entity<Decoration>(entity =>
            {
                entity.ToTable("Decoration");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.ToTable("DeliveryType");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Fabric>(entity =>
            {
                entity.ToTable("Fabric");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Fabrics)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Fabric_Color");

                entity.HasOne(d => d.Decoration)
                    .WithMany(p => p.Fabrics)
                    .HasForeignKey(d => d.DecorationId)
                    .HasConstraintName("FK_Fabric_Decoration");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Fabrics)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_Fabric_Material");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MarketingInfo>(entity =>
            {
                entity.ToTable("MarketingInfo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsInStock)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.MarketingInfo)
                    .HasForeignKey<MarketingInfo>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingInfo_Curtains1");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_DeliveryType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderCurtain>(entity =>
            {
                entity.HasOne(d => d.Curtains)
                    .WithMany(p => p.OrderCurtains)
                    .HasForeignKey(d => d.CurtainsId)
                    .HasConstraintName("FK_OrderCurtains_Curtains");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderCurtains)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderCurtains_Order");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserOrder");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<UserOrder>(entity =>
            {
                entity.ToTable("UserOrder");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.UserOrder)
                    .HasForeignKey<UserOrder>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserOrder_Order1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
