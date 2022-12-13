using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    public partial class ChangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consistencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consistencies", x => x.Id);
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FabricKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FabricTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricTypes", x => x.Id);
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
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fabrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Density = table.Column<bool>(type: "bit", nullable: false),
                    ConsistencyId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    DecorationsId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    FabricTypeId = table.Column<int>(type: "int", nullable: false),
                    FabricKindId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_Consistencies_ConsistencyId",
                        column: x => x.ConsistencyId,
                        principalTable: "Consistencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_Decorations_DecorationsId",
                        column: x => x.DecorationsId,
                        principalTable: "Decorations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_FabricKinds_FabricKindId",
                        column: x => x.FabricKindId,
                        principalTable: "FabricKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_FabricTypes_FabricTypeId",
                        column: x => x.FabricTypeId,
                        principalTable: "FabricTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fabrics_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bedspreads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bedspreads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bedspreads_Fabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "Fabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curtains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SunProtection = table.Column<bool>(type: "bit", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    AccessoriesId = table.Column<int>(type: "int", nullable: false),
                    CurtainsTypeId = table.Column<int>(type: "int", nullable: false),
                    CurtainsKindId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    BracingId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curtains_Bracings_BracingId",
                        column: x => x.BracingId,
                        principalTable: "Bracings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curtains_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Curtains_CurtainsKinds_CurtainsKindId",
                        column: x => x.CurtainsKindId,
                        principalTable: "CurtainsKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curtains_CurtainsTypes_CurtainsTypeId",
                        column: x => x.CurtainsTypeId,
                        principalTable: "CurtainsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curtains_Fabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "Fabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Curtains_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pillows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RemovableCover = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pillows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pillows_Fabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "Fabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lambrequins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BracingId = table.Column<int>(type: "int", nullable: false),
                    FabricKindId = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    CurtainsModelId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lambrequins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lambrequins_Bracings_BracingId",
                        column: x => x.BracingId,
                        principalTable: "Bracings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lambrequins_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lambrequins_Curtains_CurtainsModelId",
                        column: x => x.CurtainsModelId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lambrequins_FabricKinds_FabricKindId",
                        column: x => x.FabricKindId,
                        principalTable: "FabricKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
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
                    table.PrimaryKey("PK_Sets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sets_Bedspreads_BedspreadsId",
                        column: x => x.BedspreadsId,
                        principalTable: "Bedspreads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sets_Curtains_CurtainsId",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sets_Lambrequins_LambrequinsId",
                        column: x => x.LambrequinsId,
                        principalTable: "Lambrequins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sets_Pillows_PillowsId",
                        column: x => x.PillowsId,
                        principalTable: "Pillows",
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
                    SetsId = table.Column<int>(type: "int", nullable: true),
                    FabricId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_ProductImages_Pillows_PillowsId",
                        column: x => x.PillowsId,
                        principalTable: "Pillows",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductImages_Sets_SetsId",
                        column: x => x.SetsId,
                        principalTable: "Sets",
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
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingInfos_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_ColorId",
                table: "Accessories",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bedspreads_FabricId",
                table: "Bedspreads",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_AccessoriesId",
                table: "Curtains",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_BracingId",
                table: "Curtains",
                column: "BracingId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_ColorId",
                table: "Curtains",
                column: "ColorId");

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
                name: "IX_Fabrics_ColorId",
                table: "Fabrics",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_ConsistencyId",
                table: "Fabrics",
                column: "ConsistencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_DecorationsId",
                table: "Fabrics",
                column: "DecorationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_DesignId",
                table: "Fabrics",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_FabricKindId",
                table: "Fabrics",
                column: "FabricKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_FabricTypeId",
                table: "Fabrics",
                column: "FabricTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_ManufacturerId",
                table: "Fabrics",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_MaterialId",
                table: "Fabrics",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_BracingId",
                table: "Lambrequins",
                column: "BracingId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_ColorId",
                table: "Lambrequins",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_CurtainsModelId",
                table: "Lambrequins",
                column: "CurtainsModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_FabricKindId",
                table: "Lambrequins",
                column: "FabricKindId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInfos_ProductImageId",
                table: "MarketingInfos",
                column: "ProductImageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pillows_FabricId",
                table: "Pillows",
                column: "FabricId");

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
                name: "IX_ProductImages_SetsId",
                table: "ProductImages",
                column: "SetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_BedspreadsId",
                table: "Sets",
                column: "BedspreadsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_CurtainsId",
                table: "Sets",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_LambrequinsId",
                table: "Sets",
                column: "LambrequinsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_PillowsId",
                table: "Sets",
                column: "PillowsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Sets");

            migrationBuilder.DropTable(
                name: "Bedspreads");

            migrationBuilder.DropTable(
                name: "Lambrequins");

            migrationBuilder.DropTable(
                name: "Pillows");

            migrationBuilder.DropTable(
                name: "Curtains");

            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "Bracings");

            migrationBuilder.DropTable(
                name: "CurtainsKinds");

            migrationBuilder.DropTable(
                name: "CurtainsTypes");

            migrationBuilder.DropTable(
                name: "Fabrics");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Consistencies");

            migrationBuilder.DropTable(
                name: "Decorations");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropTable(
                name: "FabricKinds");

            migrationBuilder.DropTable(
                name: "FabricTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
