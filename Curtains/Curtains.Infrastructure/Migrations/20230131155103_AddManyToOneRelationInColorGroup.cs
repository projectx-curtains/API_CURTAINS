using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curtains.Infrastructure.Migrations
{
    public partial class AddManyToOneRelationInColorGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorGroupModel_Colors_ColorId",
                table: "ColorGroupModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_Bracings_BracingModelId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_PurposeModel_PurposeId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_ColorGroupModel_ColorGroupIdId",
                table: "Fabrics");

            migrationBuilder.DropIndex(
                name: "IX_Curtains_BracingModelId",
                table: "Curtains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurposeModel",
                table: "PurposeModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorGroupModel",
                table: "ColorGroupModel");

            migrationBuilder.DropIndex(
                name: "IX_ColorGroupModel_ColorId",
                table: "ColorGroupModel");

            migrationBuilder.DropColumn(
                name: "BracingModelId",
                table: "Curtains");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ColorGroupModel");

            migrationBuilder.RenameTable(
                name: "PurposeModel",
                newName: "Purposes");

            migrationBuilder.RenameTable(
                name: "ColorGroupModel",
                newName: "ColorGroups");

            migrationBuilder.AddColumn<int>(
                name: "ColorGroupId",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorGroupModelId",
                table: "Colors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BracingModelId",
                table: "Accessories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purposes",
                table: "Purposes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorGroups",
                table: "ColorGroups",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorGroupModelId",
                table: "Colors",
                column: "ColorGroupModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_BracingModelId",
                table: "Accessories",
                column: "BracingModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Bracings_BracingModelId",
                table: "Accessories",
                column: "BracingModelId",
                principalTable: "Bracings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_ColorGroups_ColorGroupModelId",
                table: "Colors",
                column: "ColorGroupModelId",
                principalTable: "ColorGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Curtains_Purposes_PurposeId",
                table: "Curtains",
                column: "PurposeId",
                principalTable: "Purposes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fabrics_ColorGroups_ColorGroupIdId",
                table: "Fabrics",
                column: "ColorGroupIdId",
                principalTable: "ColorGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_Bracings_BracingModelId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Colors_ColorGroups_ColorGroupModelId",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Curtains_Purposes_PurposeId",
                table: "Curtains");

            migrationBuilder.DropForeignKey(
                name: "FK_Fabrics_ColorGroups_ColorGroupIdId",
                table: "Fabrics");

            migrationBuilder.DropTable(
                name: "Furnitures");

            migrationBuilder.DropIndex(
                name: "IX_Colors_ColorGroupModelId",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Accessories_BracingModelId",
                table: "Accessories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purposes",
                table: "Purposes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorGroups",
                table: "ColorGroups");

            migrationBuilder.DropColumn(
                name: "ColorGroupId",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "ColorGroupModelId",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "BracingModelId",
                table: "Accessories");

            migrationBuilder.RenameTable(
                name: "Purposes",
                newName: "PurposeModel");

            migrationBuilder.RenameTable(
                name: "ColorGroups",
                newName: "ColorGroupModel");

            migrationBuilder.AddColumn<int>(
                name: "BracingModelId",
                table: "Curtains",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ColorGroupModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurposeModel",
                table: "PurposeModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorGroupModel",
                table: "ColorGroupModel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_BracingModelId",
                table: "Curtains",
                column: "BracingModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorGroupModel_ColorId",
                table: "ColorGroupModel",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorGroupModel_Colors_ColorId",
                table: "ColorGroupModel",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }
    }
}
