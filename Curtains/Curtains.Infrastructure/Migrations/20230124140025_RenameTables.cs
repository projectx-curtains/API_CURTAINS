using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lambrequins_Curtains_CurtainsModelId",
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

            migrationBuilder.DropIndex(
                name: "IX_Lambrequins_CurtainsModelId",
                table: "Lambrequins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sets",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "FabricId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CurtainsModelId",
                table: "Lambrequins");

            migrationBuilder.RenameTable(
                name: "Sets",
                newName: "ProductSets");

            migrationBuilder.RenameColumn(
                name: "SetsId",
                table: "ProductImages",
                newName: "ProductSetsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_SetsId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductSetsId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSets",
                table: "ProductSets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductSets_ProductSetsId",
                table: "ProductImages",
                column: "ProductSetsId",
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
                name: "FK_ProductImages_ProductSets_ProductSetsId",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSets",
                table: "ProductSets");

            migrationBuilder.RenameTable(
                name: "ProductSets",
                newName: "Sets");

            migrationBuilder.RenameColumn(
                name: "ProductSetsId",
                table: "ProductImages",
                newName: "SetsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductSetsId",
                table: "ProductImages",
                newName: "IX_ProductImages_SetsId");

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

            migrationBuilder.AddColumn<int>(
                name: "CurtainsModelId",
                table: "Lambrequins",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sets",
                table: "Sets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_CurtainsModelId",
                table: "Lambrequins",
                column: "CurtainsModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lambrequins_Curtains_CurtainsModelId",
                table: "Lambrequins",
                column: "CurtainsModelId",
                principalTable: "Curtains",
                principalColumn: "Id");

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
