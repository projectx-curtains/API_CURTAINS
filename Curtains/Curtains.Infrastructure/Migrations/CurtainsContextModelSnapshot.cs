﻿// <auto-generated />
using System;
using Curtains.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    [DbContext(typeof(CurtainsContext))]
    partial class CurtainsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Cyrillic_General_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Curtains.Infrastructure.Models.Bracing", b =>
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

                    b.ToTable("Bracing", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Color", b =>
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

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Curtain", b =>
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

            modelBuilder.Entity("Curtains.Infrastructure.Models.Decoration", b =>
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

                    b.ToTable("Decoration", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.DeliveryType", b =>
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

                    b.ToTable("DeliveryType", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Fabric", b =>
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

                    b.ToTable("Fabric", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Manufacturer", b =>
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

                    b.ToTable("Manufacturer", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.MarketingInfo", b =>
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

                    b.ToTable("MarketingInfo", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Material", b =>
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

                    b.ToTable("Material", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Model", b =>
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

                    b.ToTable("Model", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Order", b =>
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

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.OrderCurtain", b =>
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

            modelBuilder.Entity("Curtains.Infrastructure.Models.Role", b =>
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

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.User", b =>
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

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.UserOrder", b =>
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

                    b.ToTable("UserOrder", (string)null);
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Curtain", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.Bracing", "Bracing")
                        .WithMany("Curtains")
                        .HasForeignKey("BracingId")
                        .HasConstraintName("FK_Curtains_Bracing");

                    b.HasOne("Curtains.Infrastructure.Models.Fabric", "Fabric")
                        .WithMany("Curtains")
                        .HasForeignKey("FabricId")
                        .HasConstraintName("FK_Curtains_Fabric");

                    b.HasOne("Curtains.Infrastructure.Models.Manufacturer", "Manufacturer")
                        .WithMany("Curtains")
                        .HasForeignKey("ManufacturerId")
                        .HasConstraintName("FK_Curtains_Manufacturer");

                    b.HasOne("Curtains.Infrastructure.Models.Model", "Model")
                        .WithMany("Curtains")
                        .HasForeignKey("ModelId")
                        .HasConstraintName("FK_Curtains_Model");

                    b.Navigation("Bracing");

                    b.Navigation("Fabric");

                    b.Navigation("Manufacturer");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Fabric", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.Color", "Color")
                        .WithMany("Fabrics")
                        .HasForeignKey("ColorId")
                        .HasConstraintName("FK_Fabric_Color");

                    b.HasOne("Curtains.Infrastructure.Models.Decoration", "Decoration")
                        .WithMany("Fabrics")
                        .HasForeignKey("DecorationId")
                        .HasConstraintName("FK_Fabric_Decoration");

                    b.HasOne("Curtains.Infrastructure.Models.Material", "Material")
                        .WithMany("Fabrics")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("FK_Fabric_Material");

                    b.Navigation("Color");

                    b.Navigation("Decoration");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.MarketingInfo", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.Curtain", "IdNavigation")
                        .WithOne("MarketingInfo")
                        .HasForeignKey("Curtains.Infrastructure.Models.MarketingInfo", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_MarketingInfo_Curtains1");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Order", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.DeliveryType", "DeliveryType")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_DeliveryType");

                    b.HasOne("Curtains.Infrastructure.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("DeliveryType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.OrderCurtain", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.Curtain", "Curtains")
                        .WithMany("OrderCurtains")
                        .HasForeignKey("CurtainsId")
                        .HasConstraintName("FK_OrderCurtains_Curtains");

                    b.HasOne("Curtains.Infrastructure.Models.Order", "Order")
                        .WithMany("OrderCurtains")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderCurtains_Order");

                    b.Navigation("Curtains");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.User", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.UserOrder", "IdNavigation")
                        .WithOne("User")
                        .HasForeignKey("Curtains.Infrastructure.Models.User", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_User_UserOrder");

                    b.HasOne("Curtains.Infrastructure.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("IdNavigation");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.UserOrder", b =>
                {
                    b.HasOne("Curtains.Infrastructure.Models.Order", "IdNavigation")
                        .WithOne("UserOrder")
                        .HasForeignKey("Curtains.Infrastructure.Models.UserOrder", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_UserOrder_Order1");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Bracing", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Color", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Curtain", b =>
                {
                    b.Navigation("MarketingInfo")
                        .IsRequired();

                    b.Navigation("OrderCurtains");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Decoration", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.DeliveryType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Fabric", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Manufacturer", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Material", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Model", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Order", b =>
                {
                    b.Navigation("OrderCurtains");

                    b.Navigation("UserOrder")
                        .IsRequired();
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.User", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Curtains.Infrastructure.Models.UserOrder", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
