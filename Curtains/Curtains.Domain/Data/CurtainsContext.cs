using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Curtains.Domain.Models
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

            modelBuilder.ApplyConfiguration(new BracingMap());
            modelBuilder.ApplyConfiguration(new ColorMap());
            modelBuilder.ApplyConfiguration(new CurtainMap());
            modelBuilder.ApplyConfiguration(new DecorationMap());
            modelBuilder.ApplyConfiguration(new DeliveryTypeMap());
            modelBuilder.ApplyConfiguration(new FabricMap());
            modelBuilder.ApplyConfiguration(new ManufacturerMap());
            modelBuilder.ApplyConfiguration(new MarketingInfoMap());
            modelBuilder.ApplyConfiguration(new MaterialMap());
            modelBuilder.ApplyConfiguration(new ModelMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderCurtainMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserOrderMap());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
