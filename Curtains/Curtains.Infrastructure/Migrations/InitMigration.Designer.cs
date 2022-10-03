using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Curtains.Infrastructure.Migraions
{
    [DbContext(typeof(CurtainsDbContext))]
    [Migration(nameof(InitMigration))]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Curtains.Domain.Models.Accessory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Descriotion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("Accessories");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Bedspread", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FabricId")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Puprose")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Shape")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FabricId");

                    b.ToTable("Bedspreads");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Consistency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Consistency", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Curtain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CurtainsKindId")
                        .HasColumnType("int");

                    b.Property<int>("CurtainsTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Density")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FabricId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Purpose")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("SunProtection")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessoriesId");

                    b.HasIndex("CurtainsKindId");

                    b.HasIndex("CurtainsTypeId");

                    b.HasIndex(new[] { "Width" }, "IX_Curtains_BracingId");

                    b.HasIndex(new[] { "Height" }, "IX_Curtains_FabricId");

                    b.HasIndex(new[] { "MaterialId" }, "IX_Curtains_ManufacturerId");

                    b.HasIndex(new[] { "FabricId" }, "IX_Curtains_ModelId");

                    b.ToTable("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsKind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("CurtainsKind", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("CurtainsType", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Decoration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Decoration", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.DeliveryType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryType", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Fabric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ConsistencyId")
                        .HasColumnType("int");

                    b.Property<int>("DecorationsId")
                        .HasColumnType("int");

                    b.Property<bool>("Density")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Design")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ConsistencyId");

                    b.HasIndex("DecorationsId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Fabric", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Lambrequin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("Lambrequins");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.MarketingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BedspreadsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("CurtainsId")
                        .HasColumnType("int");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSale")
                        .HasColumnType("bit");

                    b.Property<int>("PilloiwsId")
                        .HasColumnType("int");

                    b.Property<int>("SetsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BedspreadsId");

                    b.HasIndex("CurtainsId");

                    b.HasIndex("PilloiwsId");

                    b.HasIndex("SetsId");

                    b.ToTable("MarketingInfo", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Material", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("DeliveryTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "DeliveryTypeId" }, "IX_Order_UserId")
                        .HasDatabaseName("IX_Order_UserId1");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.OurWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("image");

                    b.HasKey("Id");

                    b.ToTable("OurWorks");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("PaymentType", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Pillow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FabricId")
                        .HasColumnType("int");

                    b.Property<string>("Filler")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool>("RemovableCover")
                        .HasColumnType("bit");

                    b.Property<string>("Shape")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("FabricId");

                    b.ToTable("Pillows");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<string>("Review1")
                        .IsRequired()
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)")
                        .HasColumnName("Review");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BedspreadsId")
                        .HasColumnType("int");

                    b.Property<int?>("CurtainsId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("PillowsId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("BedspreadsId");

                    b.HasIndex("CurtainsId");

                    b.HasIndex("PillowsId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Flat")
                        .HasColumnType("int");

                    b.Property<string>("House")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("PostOffice")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Country" }, "IX_User_RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccessoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("BedSpreadsId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("money");

                    b.Property<int?>("CurtainsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("LambrequinsId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PillowsId")
                        .HasColumnType("int");

                    b.Property<int?>("SetId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessoriesId");

                    b.HasIndex("BedSpreadsId");

                    b.HasIndex("CurtainsId");

                    b.HasIndex("LambrequinsId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PillowsId");

                    b.HasIndex("SetId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOrder", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.Accessory", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Color", "Color")
                        .WithMany("Accessories")
                        .HasForeignKey("ColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Accessories_Color");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Bedspread", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Fabric", "Fabric")
                        .WithMany("Bedspreads")
                        .HasForeignKey("FabricId")
                        .IsRequired()
                        .HasConstraintName("FK_Bedspreads_Fabric");

                    b.Navigation("Fabric");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Curtain", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Accessory", "Accessories")
                        .WithMany("Curtains")
                        .HasForeignKey("AccessoriesId")
                        .IsRequired()
                        .HasConstraintName("FK_Curtains_Accessories");

                    b.HasOne("Curtains.Domain.Models.CurtainsKind", "CurtainsKind")
                        .WithMany("Curtains")
                        .HasForeignKey("CurtainsKindId")
                        .IsRequired()
                        .HasConstraintName("FK_Curtains_CurtainsKind");

                    b.HasOne("Curtains.Domain.Models.CurtainsType", "CurtainsType")
                        .WithMany("Curtains")
                        .HasForeignKey("CurtainsTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Curtains_CurtainsType");

                    b.HasOne("Curtains.Domain.Models.Fabric", "Fabric")
                        .WithMany("Curtains")
                        .HasForeignKey("FabricId")
                        .IsRequired()
                        .HasConstraintName("FK_Curtains_Fabric");

                    b.HasOne("Curtains.Domain.Models.Material", "Material")
                        .WithMany("Curtains")
                        .HasForeignKey("MaterialId")
                        .IsRequired()
                        .HasConstraintName("FK_Curtains_Material");

                    b.Navigation("Accessories");

                    b.Navigation("CurtainsKind");

                    b.Navigation("CurtainsType");

                    b.Navigation("Fabric");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Fabric", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Color", "Color")
                        .WithMany("Fabrics")
                        .HasForeignKey("ColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Fabric_Color");

                    b.HasOne("Curtains.Domain.Models.Consistency", "Consistency")
                        .WithMany("Fabrics")
                        .HasForeignKey("ConsistencyId")
                        .IsRequired()
                        .HasConstraintName("FK_Fabric_Consistency");

                    b.HasOne("Curtains.Domain.Models.Decoration", "Decorations")
                        .WithMany("Fabrics")
                        .HasForeignKey("DecorationsId")
                        .IsRequired()
                        .HasConstraintName("FK_Fabric_Decoration");

                    b.HasOne("Curtains.Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany("Fabrics")
                        .HasForeignKey("ManufacturerId")
                        .IsRequired()
                        .HasConstraintName("FK_Fabric_Manufacturer");

                    b.Navigation("Color");

                    b.Navigation("Consistency");

                    b.Navigation("Decorations");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Lambrequin", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Color", "Color")
                        .WithMany("Lambrequins")
                        .HasForeignKey("ColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Lambrequins_Color");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MarketingInfo", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Bedspread", "Bedspreads")
                        .WithMany("MarketingInfos")
                        .HasForeignKey("BedspreadsId")
                        .IsRequired()
                        .HasConstraintName("FK_MarketingInfo_Bedspreads");

                    b.HasOne("Curtains.Domain.Models.Curtain", "Curtains")
                        .WithMany("MarketingInfos")
                        .HasForeignKey("CurtainsId")
                        .IsRequired()
                        .HasConstraintName("FK_MarketingInfo_Curtains");

                    b.HasOne("Curtains.Domain.Models.Pillow", "Pilloiws")
                        .WithMany("MarketingInfos")
                        .HasForeignKey("PilloiwsId")
                        .IsRequired()
                        .HasConstraintName("FK_MarketingInfo_Pillows");

                    b.HasOne("Curtains.Domain.Models.Set", "Sets")
                        .WithMany("MarketingInfos")
                        .HasForeignKey("SetsId")
                        .IsRequired()
                        .HasConstraintName("FK_MarketingInfo_Sets");

                    b.Navigation("Bedspreads");

                    b.Navigation("Curtains");

                    b.Navigation("Pilloiws");

                    b.Navigation("Sets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Order", b =>
                {
                    b.HasOne("Curtains.Domain.Models.DeliveryType", "DeliveryType")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_DeliveryType");

                    b.HasOne("Curtains.Domain.Models.PaymentType", "PaymentType")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_PaymentType");

                    b.HasOne("Curtains.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("DeliveryType");

                    b.Navigation("PaymentType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Pillow", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Fabric", "Fabric")
                        .WithMany("Pillows")
                        .HasForeignKey("FabricId")
                        .IsRequired()
                        .HasConstraintName("FK_Pillows_Fabric");

                    b.Navigation("Fabric");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Set", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Bedspread", "Bedspreads")
                        .WithMany("Sets")
                        .HasForeignKey("BedspreadsId")
                        .HasConstraintName("FK_Sets_Bedspreads");

                    b.HasOne("Curtains.Domain.Models.Curtain", "Curtains")
                        .WithMany("Sets")
                        .HasForeignKey("CurtainsId")
                        .HasConstraintName("FK_Sets_Curtains");

                    b.HasOne("Curtains.Domain.Models.Pillow", "Pillows")
                        .WithMany("Sets")
                        .HasForeignKey("PillowsId")
                        .HasConstraintName("FK_Sets_Pillows");

                    b.Navigation("Bedspreads");

                    b.Navigation("Curtains");

                    b.Navigation("Pillows");
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserOrder", b =>
                {
                    b.HasOne("Curtains.Domain.Models.Accessory", "Accessories")
                        .WithMany("UserOrders")
                        .HasForeignKey("AccessoriesId")
                        .HasConstraintName("FK_UserOrder_Accessories");

                    b.HasOne("Curtains.Domain.Models.Bedspread", "BedSpreads")
                        .WithMany("UserOrders")
                        .HasForeignKey("BedSpreadsId")
                        .HasConstraintName("FK_UserOrder_Bedspreads");

                    b.HasOne("Curtains.Domain.Models.Curtain", "Curtains")
                        .WithMany("UserOrders")
                        .HasForeignKey("CurtainsId")
                        .HasConstraintName("FK_UserOrder_Curtains");

                    b.HasOne("Curtains.Domain.Models.Lambrequin", "Lambrequins")
                        .WithMany("UserOrders")
                        .HasForeignKey("LambrequinsId")
                        .HasConstraintName("FK_UserOrder_Lambrequins");

                    b.HasOne("Curtains.Domain.Models.Order", "Order")
                        .WithMany("UserOrders")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_UserOrder_Order");

                    b.HasOne("Curtains.Domain.Models.Pillow", "Pillows")
                        .WithMany("UserOrders")
                        .HasForeignKey("PillowsId")
                        .HasConstraintName("FK_UserOrder_Pillows");

                    b.HasOne("Curtains.Domain.Models.Set", "Set")
                        .WithMany("UserOrders")
                        .HasForeignKey("SetId")
                        .HasConstraintName("FK_UserOrder_Sets");

                    b.HasOne("Curtains.Domain.Models.User", "User")
                        .WithMany("UserOrders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_UserOrder_User");

                    b.Navigation("Accessories");

                    b.Navigation("BedSpreads");

                    b.Navigation("Curtains");

                    b.Navigation("Lambrequins");

                    b.Navigation("Order");

                    b.Navigation("Pillows");

                    b.Navigation("Set");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Accessory", b =>
                {
                    b.Navigation("Curtains");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Bedspread", b =>
                {
                    b.Navigation("MarketingInfos");

                    b.Navigation("Sets");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Color", b =>
                {
                    b.Navigation("Accessories");

                    b.Navigation("Fabrics");

                    b.Navigation("Lambrequins");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Consistency", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Curtain", b =>
                {
                    b.Navigation("MarketingInfos");

                    b.Navigation("Sets");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsKind", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsType", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Decoration", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DeliveryType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Fabric", b =>
                {
                    b.Navigation("Bedspreads");

                    b.Navigation("Curtains");

                    b.Navigation("Pillows");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Lambrequin", b =>
                {
                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Manufacturer", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Material", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Order", b =>
                {
                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PaymentType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Pillow", b =>
                {
                    b.Navigation("MarketingInfos");

                    b.Navigation("Sets");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.Set", b =>
                {
                    b.Navigation("MarketingInfos");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("UserOrders");
                });
#pragma warning restore 612, 618
        }
    }
}