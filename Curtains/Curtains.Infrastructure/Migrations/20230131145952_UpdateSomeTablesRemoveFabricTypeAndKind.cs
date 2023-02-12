using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    public partial class UpdateSomeTablesRemoveFabricTypeAndKind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_Colors_ColorId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Bedspreads_Fabrics_FabricId",
                table: "Bedspreads");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_Bracings_BracingId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_Colors_ColorId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_Colors_ColorId",
                table: "Fabrics");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_Consistencies_ConsistencyId",
                table: "Fabrics");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_FabricKinds_FabricKindId",
                table: "Fabrics");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_FabricTypes_FabricTypeId",
                table: "Fabrics");

            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_Bracings_BracingId",
                table: "Lambrequins");

            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_Colors_ColorId",
                table: "Lambrequins");

            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_Curtains_CurtainsModelId",
                table: "Lambrequins");

            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_FabricKinds_FabricKindId",
                table: "Lambrequins");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Sets_SetsId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Bedspreads_BedspreadsId",
                table: "Sets");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Curtains_CurtainsId",
                table: "Sets");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Lambrequins_LambrequinsId",
                table: "Sets");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Pillows_PillowsId",
                table: "Sets");

            migrationBuilder.DropTable(
                name: "Consistencies");

            migrationBuilder.DropTable(
                name: "FabricKinds");

            migrationBuilder.DropTable(
                name: "FabricTypes");

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_BracingId",
                table: "Lambrequins");

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_ColorId",
                table: "Lambrequins");

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_CurtainsModelId",
                table: "Lambrequins");

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_FabricKindId",
                table: "Lambrequins");

            migrationBuilder.DropIndex(
                name: "IX_Fabrics_ColorId",
                table: "Fabrics");

            migrationBuilder.DropIndex(
                name: "IX_Fabrics_ConsistencyId",
                table: "Fabrics");

            migrationBuilder.DropIndex(
                name: "IX_Fabrics_FabricKindId",
                table: "Fabrics");

            migrationBuilder.DropIndex(
                name: "IX_Curtains_BracingId",
                table: "Curtains");

            migrationBuilder.DropIndex(
                name: "IX_Bedspreads_FabricId",
                table: "Bedspreads");

            migrationBuilder.DropIndex(
                name: "IX_Accessories_ColorId",
                table: "Accessories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sets",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "FabricId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Filler",
                table: "Pillows");

            migrationBuilder.DropColumn(
                name: "RemovableCover",
                table: "Pillows");

            migrationBuilder.DropColumn(
                name: "BracingId",
                table: "Lambrequins");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Lambrequins");

            migrationBuilder.DropColumn(
                name: "CurtainsModelId",
                table: "Lambrequins");

            migrationBuilder.DropColumn(
                name: "FabricKindId",
                table: "Lambrequins");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Fabrics");

            migrationBuilder.DropColumn(
                name: "ConsistencyId",
                table: "Fabrics");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Decorations");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CurtainsTypes");

            migrationBuilder.DropColumn(
                name: "BracingId",
                table: "Curtains");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Curtains");

            migrationBuilder.DropColumn(
                name: "ColorGroup",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Bedspreads");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Accessories");

            migrationBuilder.RenameTable(
                name: "Sets",
                newName: "ProductSets");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "Lambrequins",
                newName: "DesignId");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Lambrequins",
                newName: "ColorGroupId");

            migrationBuilder.RenameColumn(
                name: "FabricTypeId",
                table: "Fabrics",
                newName: "ColorGroupIdId");

            migrationBuilder.RenameColumn(
                name: "FabricKindId",
                table: "Fabrics",
                newName: "ColorGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Fabrics_FabricTypeId",
                table: "Fabrics",
                newName: "IX_Fabrics_ColorGroupIdId");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Curtains",
                newName: "PurposeId");

            migrationBuilder.RenameIndex(
                name: "IX_Curtains_ColorId",
                table: "Curtains",
                newName: "IX_Curtains_PurposeId");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Accessories",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Sets_PillowsId",
                table: "ProductSets",
                newName: "IX_ProductSets_PillowsId");

            migrationBuilder.RenameIndex(
                name: "IX_Sets_LambrequinsId",
                table: "ProductSets",
                newName: "IX_ProductSets_LambrequinsId");

            migrationBuilder.RenameIndex(
                name: "IX_Sets_CurtainsId",
                table: "ProductSets",
                newName: "IX_ProductSets_CurtainsId");

            migrationBuilder.RenameIndex(
                name: "IX_Sets_BedspreadsId",
                table: "ProductSets",
                newName: "IX_ProductSets_BedspreadsId");

            migrationBuilder.AddColumn<int>(
                name: "DesignId",
                table: "Pillows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Presence",
                table: "Designs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BracingModelId",
                table: "Curtains",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Density",
                table: "Curtains",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FabricModelId",
                table: "Bedspreads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Bedspreads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BracingId",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorGroupId",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FurnitureId",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSets",
                table: "ProductSets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BedspreadsSizeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedspreadsSizeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorGroupModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorGroupModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorGroupModel_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurposeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurposeModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pillows_DesignId",
                table: "Pillows",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_ColorGroupId",
                table: "Lambrequins",
                column: "ColorGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_DesignId",
                table: "Lambrequins",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_BracingModelId",
                table: "Curtains",
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
                name: "IX_ColorGroupModel_ColorId",
                table: "ColorGroupModel",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bedspreads_BedspreadsSizeModel_SizeId",
                table: "Bedspreads",
                column: "SizeId",
                principalTable: "BedspreadsSizeModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bedspreads_Fabrics_FabricModelId",
                table: "Bedspreads",
                column: "FabricModelId",
                principalTable: "Fabrics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Curtains_Bracings_BracingModelId",
                table: "Curtains",
                column: "BracingModelId",
                principalTable: "Bracings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Curtains_PurposeModel_PurposeId",
                table: "Curtains",
                column: "PurposeId",
                principalTable: "PurposeModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrics_ColorGroupModel_ColorGroupIdId",
                table: "Fabrics",
                column: "ColorGroupIdId",
                principalTable: "ColorGroupModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_Colors_ColorGroupId",
                table: "Lambrequins",
                column: "ColorGroupId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_Designs_DesignId",
                table: "Lambrequins",
                column: "DesignId",
                principalTable: "Designs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pillows_Designs_DesignId",
                table: "Pillows",
                column: "DesignId",
                principalTable: "Designs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductSets_SetsId",
                table: "ProductImages",
                column: "SetsId",
                principalTable: "ProductSets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSets_Bedspreads_BedspreadsId",
                table: "ProductSets",
                column: "BedspreadsId",
                principalTable: "Bedspreads",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSets_Curtains_CurtainsId",
                table: "ProductSets",
                column: "CurtainsId",
                principalTable: "Curtains",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSets_Lambrequins_LambrequinsId",
                table: "ProductSets",
                column: "LambrequinsId",
                principalTable: "Lambrequins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSets_Pillows_PillowsId",
                table: "ProductSets",
                column: "PillowsId",
                principalTable: "Pillows",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bedspreads_BedspreadsSizeModel_SizeId",
                table: "Bedspreads");

            migrationBuilder.DropForeignKey(
                name: "FK_Bedspreads_Fabrics_FabricModelId",
                table: "Bedspreads");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_Bracings_BracingModelId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_PurposeModel_PurposeId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_ColorGroupModel_ColorGroupIdId",
                table: "Fabrics");

            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_Colors_ColorGroupId",
                table: "Lambrequins");

            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_Designs_DesignId",
                table: "Lambrequins");

            migrationBuilder.DropForeignKey(
                name: "FK_Pillows_Designs_DesignId",
                table: "Pillows");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductSets_SetsId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSets_Bedspreads_BedspreadsId",
                table: "ProductSets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSets_Curtains_CurtainsId",
                table: "ProductSets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSets_Lambrequins_LambrequinsId",
                table: "ProductSets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSets_Pillows_PillowsId",
                table: "ProductSets");

            migrationBuilder.DropTable(
                name: "BedspreadsSizeModel");

            migrationBuilder.DropTable(
                name: "ColorGroupModel");

            migrationBuilder.DropTable(
                name: "PurposeModel");

            migrationBuilder.DropIndex(
                name: "IX_Pillows_DesignId",
                table: "Pillows");

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_ColorGroupId",
                table: "Lambrequins");

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_DesignId",
                table: "Lambrequins");

            migrationBuilder.DropIndex(
                name: "IX_Curtains_BracingModelId",
                table: "Curtains");

            migrationBuilder.DropIndex(
                name: "IX_Bedspreads_FabricModelId",
                table: "Bedspreads");

            migrationBuilder.DropIndex(
                name: "IX_Bedspreads_SizeId",
                table: "Bedspreads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSets",
                table: "ProductSets");

            migrationBuilder.DropColumn(
                name: "DesignId",
                table: "Pillows");

            migrationBuilder.DropColumn(
                name: "Presence",
                table: "Designs");

            migrationBuilder.DropColumn(
                name: "BracingModelId",
                table: "Curtains");

            migrationBuilder.DropColumn(
                name: "Density",
                table: "Curtains");

            migrationBuilder.DropColumn(
                name: "FabricModelId",
                table: "Bedspreads");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Bedspreads");

            migrationBuilder.DropColumn(
                name: "BracingId",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "ColorGroupId",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "FurnitureId",
                table: "Accessories");

            migrationBuilder.RenameTable(
                name: "ProductSets",
                newName: "Sets");

            migrationBuilder.RenameColumn(
                name: "DesignId",
                table: "Lambrequins",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "ColorGroupId",
                table: "Lambrequins",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "ColorGroupIdId",
                table: "Fabrics",
                newName: "FabricTypeId");

            migrationBuilder.RenameColumn(
                name: "ColorGroup",
                table: "Fabrics",
                newName: "FabricKindId");

            migrationBuilder.RenameIndex(
                name: "IX_Fabrics_ColorGroupIdId",
                table: "Fabrics",
                newName: "IX_Fabrics_FabricTypeId");

            migrationBuilder.RenameColumn(
                name: "PurposeId",
                table: "Curtains",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Curtains_PurposeId",
                table: "Curtains",
                newName: "IX_Curtains_ColorId");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Accessories",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSets_PillowsId",
                table: "Sets",
                newName: "IX_Sets_PillowsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSets_LambrequinsId",
                table: "Sets",
                newName: "IX_Sets_LambrequinsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSets_CurtainsId",
                table: "Sets",
                newName: "IX_Sets_CurtainsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSets_BedspreadsId",
                table: "Sets",
                newName: "IX_Sets_BedspreadsId");

            migrationBuilder.AddColumn<int>(
                name: "FabricId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filler",
                table: "Pillows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "RemovableCover",
                table: "Pillows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BracingId",
                table: "Lambrequins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Lambrequins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurtainsModelId",
                table: "Lambrequins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FabricKindId",
                table: "Lambrequins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Fabrics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsistencyId",
                table: "Fabrics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Decorations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CurtainsTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BracingId",
                table: "Curtains",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Curtains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorGroup",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Bedspreads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Accessories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sets",
                table: "Sets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Consistencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consistencies", x => x.Id);
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
                name: "IX_Fabrics_ColorId",
                table: "Fabrics",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_ConsistencyId",
                table: "Fabrics",
                column: "ConsistencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_FabricKindId",
                table: "Fabrics",
                column: "FabricKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_BracingId",
                table: "Curtains",
                column: "BracingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bedspreads_FabricId",
                table: "Bedspreads",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_ColorId",
                table: "Accessories",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Colors_ColorId",
                table: "Accessories",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bedspreads_Fabrics_FabricId",
                table: "Bedspreads",
                column: "FabricId",
                principalTable: "Fabrics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curtains_Bracings_BracingId",
                table: "Curtains",
                column: "BracingId",
                principalTable: "Bracings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curtains_Colors_ColorId",
                table: "Curtains",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrics_Colors_ColorId",
                table: "Fabrics",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrics_Consistencies_ConsistencyId",
                table: "Fabrics",
                column: "ConsistencyId",
                principalTable: "Consistencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrics_FabricKinds_FabricKindId",
                table: "Fabrics",
                column: "FabricKindId",
                principalTable: "FabricKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrics_FabricTypes_FabricTypeId",
                table: "Fabrics",
                column: "FabricTypeId",
                principalTable: "FabricTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_Bracings_BracingId",
                table: "Lambrequins",
                column: "BracingId",
                principalTable: "Bracings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_Colors_ColorId",
                table: "Lambrequins",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_Curtains_CurtainsModelId",
                table: "Lambrequins",
                column: "CurtainsModelId",
                principalTable: "Curtains",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_FabricKinds_FabricKindId",
                table: "Lambrequins",
                column: "FabricKindId",
                principalTable: "FabricKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Sets_SetsId",
                table: "ProductImages",
                column: "SetsId",
                principalTable: "Sets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Bedspreads_BedspreadsId",
                table: "Sets",
                column: "BedspreadsId",
                principalTable: "Bedspreads",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Curtains_CurtainsId",
                table: "Sets",
                column: "CurtainsId",
                principalTable: "Curtains",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Lambrequins_LambrequinsId",
                table: "Sets",
                column: "LambrequinsId",
                principalTable: "Lambrequins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Pillows_PillowsId",
                table: "Sets",
                column: "PillowsId",
                principalTable: "Pillows",
                principalColumn: "Id");
        }
    }
}
