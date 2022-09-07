using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curtains.Domain.Migrations
{
    public partial class AddedReviewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BracingModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracingModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DecorationModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Presence = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecorationModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryTypeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryTypeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Country = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Review = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FabricModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LightTransmittance = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    DecorationId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fabric_Color",
                        column: x => x.ColorId,
                        principalTable: "ColorModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabric_Decoration",
                        column: x => x.DecorationId,
                        principalTable: "DecorationModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabric_Material",
                        column: x => x.MaterialId,
                        principalTable: "MaterialModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Curtains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: true),
                    BracingId = table.Column<int>(type: "int", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curtains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curtains_Bracing",
                        column: x => x.BracingId,
                        principalTable: "BracingModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Fabric",
                        column: x => x.FabricId,
                        principalTable: "FabricModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Manufacturer",
                        column: x => x.ManufacturerId,
                        principalTable: "ManufacturerModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Model",
                        column: x => x.ModelId,
                        principalTable: "ModelModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarketingInfoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingInfoModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingInfo_Curtains1",
                        column: x => x.Id,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderCurtains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CurtainsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCurtains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderCurtains_Curtains",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    PaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeliveryTypeId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_DeliveryType",
                        column: x => x.DeliveryTypeId,
                        principalTable: "DeliveryTypeModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserOrderModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrderModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOrder_Order1",
                        column: x => x.Id,
                        principalTable: "OrderModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.RoleId,
                        principalTable: "RoleModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_UserOrder",
                        column: x => x.Id,
                        principalTable: "UserOrderModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_BracingId",
                table: "Curtains",
                column: "BracingId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_FabricId",
                table: "Curtains",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_ManufacturerId",
                table: "Curtains",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_ModelId",
                table: "Curtains",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_FabricModel_ColorId",
                table: "FabricModel",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_FabricModel_DecorationId",
                table: "FabricModel",
                column: "DecorationId");

            migrationBuilder.CreateIndex(
                name: "IX_FabricModel_MaterialId",
                table: "FabricModel",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCurtains_CurtainsId",
                table: "OrderCurtains",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCurtains_OrderId",
                table: "OrderCurtains",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderModel_DeliveryTypeId",
                table: "OrderModel",
                column: "DeliveryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderModel_UserId",
                table: "OrderModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_RoleId",
                table: "UserModel",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderCurtains_Order",
                table: "OrderCurtains",
                column: "OrderId",
                principalTable: "OrderModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User",
                table: "OrderModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrder_Order1",
                table: "UserOrderModel");

            migrationBuilder.DropTable(
                name: "MarketingInfoModel");

            migrationBuilder.DropTable(
                name: "OrderCurtains");

            migrationBuilder.DropTable(
                name: "ReviewModel");

            migrationBuilder.DropTable(
                name: "Curtains");

            migrationBuilder.DropTable(
                name: "BracingModel");

            migrationBuilder.DropTable(
                name: "FabricModel");

            migrationBuilder.DropTable(
                name: "ManufacturerModel");

            migrationBuilder.DropTable(
                name: "ModelModel");

            migrationBuilder.DropTable(
                name: "ColorModel");

            migrationBuilder.DropTable(
                name: "DecorationModel");

            migrationBuilder.DropTable(
                name: "MaterialModel");

            migrationBuilder.DropTable(
                name: "OrderModel");

            migrationBuilder.DropTable(
                name: "DeliveryTypeModel");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DropTable(
                name: "RoleModel");

            migrationBuilder.DropTable(
                name: "UserOrderModel");
        }
    }
}
