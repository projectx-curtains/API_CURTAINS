﻿// <auto-generated />
using System;
using Curtains.Domain.Data;
using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curtains.Domain.Migrations
{
    [DbContext(typeof(CurtainsContext))]
    partial class CurtainsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Curtains.Domain.Models.BracingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("BracingModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.ColorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("ColorModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BracingId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int?>("FabricId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BracingId");

                    b.HasIndex("FabricId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ModelId");

                    b.ToTable("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DecorationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("DecorationModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.DeliveryTypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("DeliveryTypeModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.FabricModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("DecorationId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("LightTransmittance")
                        .HasColumnType("bit");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("DecorationId");

                    b.HasIndex("MaterialId");

                    b.ToTable("FabricModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.ManufacturerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Website")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("ManufacturerModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.MarketingInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("IsInStock")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MarketingInfoModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.MaterialModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("MaterialModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.ModelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("ModelModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.OrderCurtainModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CurtainsId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurtainsId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderCurtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("CustomerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int>("DeliveryTypeId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.ReviewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("ReviewModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.RoleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("RoleModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("money");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOrderModel", (string)null);
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.BracingModel", "Bracing")
                        .WithMany("Curtains")
                        .HasForeignKey("BracingId")
                        .HasConstraintName("FK_Curtains_Bracing");

                    b.HasOne("Curtains.Domain.Models.FabricModel", "Fabric")
                        .WithMany("Curtains")
                        .HasForeignKey("FabricId")
                        .HasConstraintName("FK_Curtains_Fabric");

                    b.HasOne("Curtains.Domain.Models.ManufacturerModel", "Manufacturer")
                        .WithMany("Curtains")
                        .HasForeignKey("ManufacturerId")
                        .HasConstraintName("FK_Curtains_Manufacturer");

                    b.HasOne("Curtains.Domain.Models.ModelModel", "Model")
                        .WithMany("Curtains")
                        .HasForeignKey("ModelId")
                        .HasConstraintName("FK_Curtains_Model");

                    b.Navigation("Bracing");

                    b.Navigation("Fabric");

                    b.Navigation("Manufacturer");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Curtains.Domain.Models.FabricModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.ColorModel", "Color")
                        .WithMany("Fabrics")
                        .HasForeignKey("ColorId")
                        .HasConstraintName("FK_Fabric_Color");

                    b.HasOne("Curtains.Domain.Models.DecorationModel", "Decoration")
                        .WithMany("Fabrics")
                        .HasForeignKey("DecorationId")
                        .HasConstraintName("FK_Fabric_Decoration");

                    b.HasOne("Curtains.Domain.Models.MaterialModel", "Material")
                        .WithMany("Fabrics")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("FK_Fabric_Material");

                    b.Navigation("Color");

                    b.Navigation("Decoration");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MarketingInfoModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.CurtainModel", "IdNavigation")
                        .WithOne("MarketingInfo")
                        .HasForeignKey("Curtains.Domain.Models.MarketingInfoModel", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_MarketingInfo_Curtains1");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Curtains.Domain.Models.OrderCurtainModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.CurtainModel", "Curtains")
                        .WithMany("OrderCurtains")
                        .HasForeignKey("CurtainsId")
                        .HasConstraintName("FK_OrderCurtains_Curtains");

                    b.HasOne("Curtains.Domain.Models.OrderModel", "Order")
                        .WithMany("OrderCurtains")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderCurtains_Order");

                    b.Navigation("Curtains");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Curtains.Domain.Models.OrderModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.DeliveryTypeModel", "DeliveryType")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_DeliveryType");

                    b.HasOne("Curtains.Domain.Models.UserModel", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("DeliveryType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.UserOrderModel", "IdNavigation")
                        .WithOne("User")
                        .HasForeignKey("Curtains.Domain.Models.UserModel", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_User_UserOrder");

                    b.HasOne("Curtains.Domain.Models.RoleModel", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("IdNavigation");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserOrderModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.OrderModel", "IdNavigation")
                        .WithOne("UserOrder")
                        .HasForeignKey("Curtains.Domain.Models.UserOrderModel", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_UserOrder_Order1");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BracingModel", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ColorModel", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainModel", b =>
                {
                    b.Navigation("MarketingInfo")
                        .IsRequired();

                    b.Navigation("OrderCurtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DecorationModel", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DeliveryTypeModel", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.FabricModel", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ManufacturerModel", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MaterialModel", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ModelModel", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.OrderModel", b =>
                {
                    b.Navigation("OrderCurtains");

                    b.Navigation("UserOrder")
                        .IsRequired();
                });

            modelBuilder.Entity("Curtains.Domain.Models.RoleModel", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserModel", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Curtains.Domain.Models.UserOrderModel", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
