using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Curtains.Domain.Models;

namespace Curtains.Domain.Data
{
    public partial class CurtainsContext : DbContext
    {
        IConfiguration _config;

        public CurtainsContext(IConfiguration config)
        {
            _config = config;
        }

        public virtual DbSet<BracingModel> Bracings { get; set; } = null!;
        public virtual DbSet<ColorModel> Colors { get; set; } = null!;
        public virtual DbSet<CurtainModel> Curtains { get; set; } = null!;
        public virtual DbSet<DecorationModel> Decorations { get; set; } = null!;
        public virtual DbSet<DeliveryTypeModel> DeliveryTypes { get; set; } = null!;
        public virtual DbSet<FabricModel> Fabrics { get; set; } = null!;
        public virtual DbSet<ManufacturerModel> Manufacturers { get; set; } = null!;
        public virtual DbSet<MarketingInfoModel> MarketingInfos { get; set; } = null!;
        public virtual DbSet<MaterialModel> Materials { get; set; } = null!;
        public virtual DbSet<ModelModel> Models { get; set; } = null!;
        public virtual DbSet<OrderModel> Orders { get; set; } = null!;
        public virtual DbSet<OrderCurtainModel> OrderCurtains { get; set; } = null!;
        public virtual DbSet<RoleModel> Roles { get; set; } = null!;
        public virtual DbSet<UserModel> Users { get; set; } = null!;
        public virtual DbSet<UserOrderModel> UserOrders { get; set; } = null!;
        public virtual DbSet<ReviewModel> ReviewModels { get; set; } = null!;

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
            modelBuilder.UseCollation(_config["DbCollationLatin"]);

            modelBuilder.ApplyConfiguration(new BracingMapping());
            modelBuilder.ApplyConfiguration(new ColorMapping());
            modelBuilder.ApplyConfiguration(new CurtainMapping());
            modelBuilder.ApplyConfiguration(new DecorationMapping());
            modelBuilder.ApplyConfiguration(new DeliveryTypeMapping());
            modelBuilder.ApplyConfiguration(new FabricMapping());
            modelBuilder.ApplyConfiguration(new ManufacturerMapping());
            modelBuilder.ApplyConfiguration(new MarketingInfoMapping());
            modelBuilder.ApplyConfiguration(new MaterialMapping());
            modelBuilder.ApplyConfiguration(new ModelMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new OrderCurtainMapping());
            modelBuilder.ApplyConfiguration(new RoleMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new UserOrderMapping());
            modelBuilder.ApplyConfiguration(new ReviewMapping());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
