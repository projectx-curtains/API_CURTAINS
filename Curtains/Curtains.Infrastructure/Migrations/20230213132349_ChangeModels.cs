using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    public partial class ChangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BedspreadSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedspreadSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bracings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bracings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurtainsKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainsKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurtainsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decorations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Presence = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decorations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Presence = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Furnitures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnitures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetaDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Canonical = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PillowsSizeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PillowsSizeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FurnitureId = table.Column<int>(type: "int", nullable: true),
                    BracingId = table.Column<int>(type: "int", nullable: true),
                    ColorGroupId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    BracingModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_Bracings_BracingModelId",
                        column: x => x.BracingModelId,
                        principalTable: "Bracings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorGroupId = table.Column<int>(type: "int", nullable: true),
                    ColorGroupModelId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_ColorGroups_ColorGroupModelId",
                        column: x => x.ColorGroupModelId,
                        principalTable: "ColorGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fabrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Density = table.Column<bool>(type: "bit", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    DecorationsId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fabrics_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabrics_Decorations_DecorationsId",
                        column: x => x.DecorationsId,
                        principalTable: "Decorations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabrics_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabrics_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabrics_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lambrequins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lambrequins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lambrequins_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lambrequins_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bedspreads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: true),
                    FabricModelId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bedspreads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bedspreads_BedspreadSizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "BedspreadSizes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bedspreads_Fabrics_FabricModelId",
                        column: x => x.FabricModelId,
                        principalTable: "Fabrics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Curtains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Density = table.Column<bool>(type: "bit", nullable: false),
                    SunProtection = table.Column<bool>(type: "bit", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    AccessoriesId = table.Column<int>(type: "int", nullable: true),
                    CurtainsTypeId = table.Column<int>(type: "int", nullable: true),
                    CurtainsKindId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurposeId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curtains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curtains_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_CurtainsKinds_CurtainsKindId",
                        column: x => x.CurtainsKindId,
                        principalTable: "CurtainsKinds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_CurtainsTypes_CurtainsTypeId",
                        column: x => x.CurtainsTypeId,
                        principalTable: "CurtainsTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Fabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "Fabrics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Purposes_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "Purposes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PillowsModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FabricId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PillowsModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PillowsModel_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PillowsModel_Fabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "Fabrics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PillowsModel_PillowsSizeModel_SizeId",
                        column: x => x.SizeId,
                        principalTable: "PillowsSizeModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainsId = table.Column<int>(type: "int", nullable: true),
                    PillowsId = table.Column<int>(type: "int", nullable: true),
                    BedspreadsId = table.Column<int>(type: "int", nullable: true),
                    LambrequinsId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSets_Bedspreads_BedspreadsId",
                        column: x => x.BedspreadsId,
                        principalTable: "Bedspreads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSets_Curtains_CurtainsId",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSets_Lambrequins_LambrequinsId",
                        column: x => x.LambrequinsId,
                        principalTable: "Lambrequins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSets_PillowsModel_PillowsId",
                        column: x => x.PillowsId,
                        principalTable: "PillowsModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurtainsId = table.Column<int>(type: "int", nullable: true),
                    PillowsId = table.Column<int>(type: "int", nullable: true),
                    BedspreadsId = table.Column<int>(type: "int", nullable: true),
                    ProductSetId = table.Column<int>(type: "int", nullable: true),
                    FabricsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Bedspreads_BedspreadsId",
                        column: x => x.BedspreadsId,
                        principalTable: "Bedspreads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductImages_Curtains_CurtainsId",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductImages_Fabrics_FabricsId",
                        column: x => x.FabricsId,
                        principalTable: "Fabrics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductImages_PillowsModel_PillowsId",
                        column: x => x.PillowsId,
                        principalTable: "PillowsModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductSets_ProductSetId",
                        column: x => x.ProductSetId,
                        principalTable: "ProductSets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarketingInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    IsPopular = table.Column<bool>(type: "bit", nullable: false),
                    ProductImageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingInfos_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_BracingModelId",
                table: "Accessories",
                column: "BracingModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Bedspreads_FabricModelId",
                table: "Bedspreads",
                column: "FabricModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Bedspreads_SizeId",
                table: "Bedspreads",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorGroupModelId",
                table: "Colors",
                column: "ColorGroupModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_AccessoriesId",
                table: "Curtains",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_CurtainsKindId",
                table: "Curtains",
                column: "CurtainsKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_CurtainsTypeId",
                table: "Curtains",
                column: "CurtainsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_FabricId",
                table: "Curtains",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_MaterialId",
                table: "Curtains",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_PurposeId",
                table: "Curtains",
                column: "PurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_ColorId",
                table: "Fabrics",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_DecorationsId",
                table: "Fabrics",
                column: "DecorationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_DesignId",
                table: "Fabrics",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_ManufacturerId",
                table: "Fabrics",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_MaterialId",
                table: "Fabrics",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_ColorId",
                table: "Lambrequins",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_DesignId",
                table: "Lambrequins",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInfos_ProductImageId",
                table: "MarketingInfos",
                column: "ProductImageId",
                unique: true,
                filter: "[ProductImageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PillowsModel_DesignId",
                table: "PillowsModel",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_PillowsModel_FabricId",
                table: "PillowsModel",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_PillowsModel_SizeId",
                table: "PillowsModel",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_BedspreadsId",
                table: "ProductImages",
                column: "BedspreadsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CurtainsId",
                table: "ProductImages",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_FabricsId",
                table: "ProductImages",
                column: "FabricsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_PillowsId",
                table: "ProductImages",
                column: "PillowsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductSetId",
                table: "ProductImages",
                column: "ProductSetId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSets_BedspreadsId",
                table: "ProductSets",
                column: "BedspreadsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSets_CurtainsId",
                table: "ProductSets",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSets_LambrequinsId",
                table: "ProductSets",
                column: "LambrequinsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSets_PillowsId",
                table: "ProductSets",
                column: "PillowsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furnitures");

            migrationBuilder.DropTable(
                name: "MarketingInfos");

            migrationBuilder.DropTable(
                name: "MetaDatas");

            migrationBuilder.DropTable(
                name: "OurWorks");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductSets");

            migrationBuilder.DropTable(
                name: "Bedspreads");

            migrationBuilder.DropTable(
                name: "Curtains");

            migrationBuilder.DropTable(
                name: "Lambrequins");

            migrationBuilder.DropTable(
                name: "PillowsModel");

            migrationBuilder.DropTable(
                name: "BedspreadSizes");

            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "CurtainsKinds");

            migrationBuilder.DropTable(
                name: "CurtainsTypes");

            migrationBuilder.DropTable(
                name: "Purposes");

            migrationBuilder.DropTable(
                name: "Fabrics");

            migrationBuilder.DropTable(
                name: "PillowsSizeModel");

            migrationBuilder.DropTable(
                name: "Bracings");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Decorations");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "ColorGroups");
        }
    }
}
