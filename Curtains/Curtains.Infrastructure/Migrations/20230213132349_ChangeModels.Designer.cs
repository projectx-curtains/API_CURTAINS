﻿// <auto-generated />
using System;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    [DbContext(typeof(CurtainsDbContext))]
    [Migration("20230213132349_ChangeModels")]
    partial class ChangeModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Curtains.Domain.Models.AccessoriesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BracingId")
                        .HasColumnType("int");

                    b.Property<int?>("BracingModelId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("FurnitureId")
                        .HasColumnType("int");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BracingModelId");

                    b.ToTable("Accessories");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BedspreadsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FabricId")
                        .HasColumnType("int");

                    b.Property<int?>("FabricModelId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FabricModelId");

                    b.HasIndex("SizeId");

                    b.ToTable("Bedspreads");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BedspreadsSizeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BedspreadSizes");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BracingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bracings");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ColorGroupModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColorGroups");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ColorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ColorGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorGroupModelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorGroupModelId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsKindModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurtainsKinds");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccessoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("CurtainsKindId")
                        .HasColumnType("int");

                    b.Property<int?>("CurtainsTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Density")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FabricId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PurposeId")
                        .HasColumnType("int");

                    b.Property<bool>("SunProtection")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessoriesId");

                    b.HasIndex("CurtainsKindId");

                    b.HasIndex("CurtainsTypeId");

                    b.HasIndex("FabricId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PurposeId");

                    b.ToTable("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsTypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurtainsTypes");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DecorationsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Decorations");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DesignModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("Curtains.Domain.Models.FabricModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("DecorationsId")
                        .HasColumnType("int");

                    b.Property<bool>("Density")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DesignId")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("DecorationsId");

                    b.HasIndex("DesignId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.FurnitureModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Furnitures");
                });

            modelBuilder.Entity("Curtains.Domain.Models.LambrequinsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DesignId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("DesignId");

                    b.ToTable("Lambrequins");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ManufacturerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MarketingInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPopular")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSale")
                        .HasColumnType("bit");

                    b.Property<int?>("ProductImageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductImageId")
                        .IsUnique()
                        .HasFilter("[ProductImageId] IS NOT NULL");

                    b.ToTable("MarketingInfos");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MaterialModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MetaDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Canonical")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MetaDatas");
                });

            modelBuilder.Entity("Curtains.Domain.Models.OurWorksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OurWorks");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PillowsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DesignId")
                        .HasColumnType("int");

                    b.Property<int?>("FabricId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DesignId");

                    b.HasIndex("FabricId");

                    b.HasIndex("SizeId");

                    b.ToTable("PillowsModel");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PillowsSizeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PillowsSizeModel");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ProductImageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BedspreadsId")
                        .HasColumnType("int");

                    b.Property<int?>("CurtainsId")
                        .HasColumnType("int");

                    b.Property<int?>("FabricsId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PillowsId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductSetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BedspreadsId");

                    b.HasIndex("CurtainsId");

                    b.HasIndex("FabricsId");

                    b.HasIndex("PillowsId");

                    b.HasIndex("ProductSetId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ProductSetModel", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LambrequinsId")
                        .HasColumnType("int");

                    b.Property<int?>("PillowsId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BedspreadsId");

                    b.HasIndex("CurtainsId");

                    b.HasIndex("LambrequinsId");

                    b.HasIndex("PillowsId");

                    b.ToTable("ProductSets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PurposeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Purposes");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ReviewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Curtains.Domain.Models.AccessoriesModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.BracingModel", null)
                        .WithMany("Accessories")
                        .HasForeignKey("BracingModelId");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BedspreadsModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.FabricModel", null)
                        .WithMany("Bedspreads")
                        .HasForeignKey("FabricModelId");

                    b.HasOne("Curtains.Domain.Models.BedspreadsSizeModel", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ColorModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.ColorGroupModel", null)
                        .WithMany("Colors")
                        .HasForeignKey("ColorGroupModelId");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.AccessoriesModel", "Accessories")
                        .WithMany()
                        .HasForeignKey("AccessoriesId");

                    b.HasOne("Curtains.Domain.Models.CurtainsKindModel", "CurtainsKind")
                        .WithMany("Curtains")
                        .HasForeignKey("CurtainsKindId");

                    b.HasOne("Curtains.Domain.Models.CurtainsTypeModel", "CurtainsType")
                        .WithMany("Curtains")
                        .HasForeignKey("CurtainsTypeId");

                    b.HasOne("Curtains.Domain.Models.FabricModel", "Fabric")
                        .WithMany("Curtains")
                        .HasForeignKey("FabricId");

                    b.HasOne("Curtains.Domain.Models.MaterialModel", "Material")
                        .WithMany("Curtains")
                        .HasForeignKey("MaterialId");

                    b.HasOne("Curtains.Domain.Models.PurposeModel", "Purpose")
                        .WithMany()
                        .HasForeignKey("PurposeId");

                    b.Navigation("Accessories");

                    b.Navigation("CurtainsKind");

                    b.Navigation("CurtainsType");

                    b.Navigation("Fabric");

                    b.Navigation("Material");

                    b.Navigation("Purpose");
                });

            modelBuilder.Entity("Curtains.Domain.Models.FabricModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.ColorModel", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("Curtains.Domain.Models.DecorationsModel", "Decorations")
                        .WithMany("Fabrics")
                        .HasForeignKey("DecorationsId");

                    b.HasOne("Curtains.Domain.Models.DesignModel", "Design")
                        .WithMany("Fabrics")
                        .HasForeignKey("DesignId");

                    b.HasOne("Curtains.Domain.Models.ManufacturerModel", "Manufacturer")
                        .WithMany("Fabrics")
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Curtains.Domain.Models.MaterialModel", "Material")
                        .WithMany("Fabrics")
                        .HasForeignKey("MaterialId");

                    b.Navigation("Color");

                    b.Navigation("Decorations");

                    b.Navigation("Design");

                    b.Navigation("Manufacturer");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Curtains.Domain.Models.LambrequinsModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.ColorModel", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("Curtains.Domain.Models.DesignModel", "Design")
                        .WithMany()
                        .HasForeignKey("DesignId");

                    b.Navigation("Color");

                    b.Navigation("Design");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MarketingInfoModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.ProductImageModel", "ProductImage")
                        .WithOne("MarketingInfo")
                        .HasForeignKey("Curtains.Domain.Models.MarketingInfoModel", "ProductImageId");

                    b.Navigation("ProductImage");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PillowsModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.DesignModel", "Design")
                        .WithMany()
                        .HasForeignKey("DesignId");

                    b.HasOne("Curtains.Domain.Models.FabricModel", "Fabric")
                        .WithMany("Pillows")
                        .HasForeignKey("FabricId");

                    b.HasOne("Curtains.Domain.Models.PillowsSizeModel", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("Design");

                    b.Navigation("Fabric");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ProductImageModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.BedspreadsModel", "Bedspreads")
                        .WithMany("ProductImages")
                        .HasForeignKey("BedspreadsId");

                    b.HasOne("Curtains.Domain.Models.CurtainsModel", "Curtains")
                        .WithMany("ProductImages")
                        .HasForeignKey("CurtainsId");

                    b.HasOne("Curtains.Domain.Models.FabricModel", "Fabrics")
                        .WithMany("ProductImages")
                        .HasForeignKey("FabricsId");

                    b.HasOne("Curtains.Domain.Models.PillowsModel", "Pillows")
                        .WithMany("ProductImages")
                        .HasForeignKey("PillowsId");

                    b.HasOne("Curtains.Domain.Models.ProductSetModel", "ProductSet")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductSetId");

                    b.Navigation("Bedspreads");

                    b.Navigation("Curtains");

                    b.Navigation("Fabrics");

                    b.Navigation("Pillows");

                    b.Navigation("ProductSet");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ProductSetModel", b =>
                {
                    b.HasOne("Curtains.Domain.Models.BedspreadsModel", "Bedspreads")
                        .WithMany("ProductSets")
                        .HasForeignKey("BedspreadsId");

                    b.HasOne("Curtains.Domain.Models.CurtainsModel", "Curtains")
                        .WithMany("ProductSets")
                        .HasForeignKey("CurtainsId");

                    b.HasOne("Curtains.Domain.Models.LambrequinsModel", "Lambrequins")
                        .WithMany("ProductSets")
                        .HasForeignKey("LambrequinsId");

                    b.HasOne("Curtains.Domain.Models.PillowsModel", "Pillows")
                        .WithMany("ProductSets")
                        .HasForeignKey("PillowsId");

                    b.Navigation("Bedspreads");

                    b.Navigation("Curtains");

                    b.Navigation("Lambrequins");

                    b.Navigation("Pillows");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BedspreadsModel", b =>
                {
                    b.Navigation("ProductImages");

                    b.Navigation("ProductSets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.BracingModel", b =>
                {
                    b.Navigation("Accessories");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ColorGroupModel", b =>
                {
                    b.Navigation("Colors");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsKindModel", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsModel", b =>
                {
                    b.Navigation("ProductImages");

                    b.Navigation("ProductSets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.CurtainsTypeModel", b =>
                {
                    b.Navigation("Curtains");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DecorationsModel", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.DesignModel", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.FabricModel", b =>
                {
                    b.Navigation("Bedspreads");

                    b.Navigation("Curtains");

                    b.Navigation("Pillows");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("Curtains.Domain.Models.LambrequinsModel", b =>
                {
                    b.Navigation("ProductSets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ManufacturerModel", b =>
                {
                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.MaterialModel", b =>
                {
                    b.Navigation("Curtains");

                    b.Navigation("Fabrics");
                });

            modelBuilder.Entity("Curtains.Domain.Models.PillowsModel", b =>
                {
                    b.Navigation("ProductImages");

                    b.Navigation("ProductSets");
                });

            modelBuilder.Entity("Curtains.Domain.Models.ProductImageModel", b =>
                {
                    b.Navigation("MarketingInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("Curtains.Domain.Models.ProductSetModel", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}