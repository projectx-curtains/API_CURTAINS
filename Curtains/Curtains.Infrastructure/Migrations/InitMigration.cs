using Microsoft.EntityFrameworkCore.Migrations;

namespace Curtains.Infrastructure.Migraions
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consistency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consistency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurtainsKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainsKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurtainsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decoration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Presence = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decoration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Photo = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Review = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    Photo = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    House = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Flat = table.Column<int>(type: "int", nullable: true),
                    PostOffice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Descriotion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_Color",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lambrequins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lambrequins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lambrequins_Color",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fabric",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Density = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConsistencyId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    DecorationsId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Design = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fabric_Color",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabric_Consistency",
                        column: x => x.ConsistencyId,
                        principalTable: "Consistency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabric_Decoration",
                        column: x => x.DecorationsId,
                        principalTable: "Decoration",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fabric_Manufacturer",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeliveryTypeId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_DeliveryType",
                        column: x => x.DeliveryTypeId,
                        principalTable: "DeliveryType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_PaymentType",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bedspreads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Puprose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Shape = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bedspreads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bedspreads_Fabric",
                        column: x => x.FabricId,
                        principalTable: "Fabric",
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
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    AccessoriesId = table.Column<int>(type: "int", nullable: false),
                    CurtainsTypeId = table.Column<int>(type: "int", nullable: false),
                    CurtainsKindId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curtains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curtains_Accessories",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_CurtainsKind",
                        column: x => x.CurtainsKindId,
                        principalTable: "CurtainsKind",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_CurtainsType",
                        column: x => x.CurtainsTypeId,
                        principalTable: "CurtainsType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Fabric",
                        column: x => x.FabricId,
                        principalTable: "Fabric",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtains_Material",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pillows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Filler = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RemovableCover = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Shape = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pillows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pillows_Fabric",
                        column: x => x.FabricId,
                        principalTable: "Fabric",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CurtainsId = table.Column<int>(type: "int", nullable: true),
                    PillowsId = table.Column<int>(type: "int", nullable: true),
                    BedspreadsId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sets_Bedspreads",
                        column: x => x.BedspreadsId,
                        principalTable: "Bedspreads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sets_Curtains",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sets_Pillows",
                        column: x => x.PillowsId,
                        principalTable: "Pillows",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarketingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainsId = table.Column<int>(type: "int", nullable: true),
                    PilloiwsId = table.Column<int>(type: "int", nullable: true),
                    BedspreadsId = table.Column<int>(type: "int", nullable: true),
                    SetsId = table.Column<int>(type: "int", nullable: true),
                    IsNew = table.Column<bool>(type: "bit", nullable: true),
                    IsSale = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingInfo_Bedspreads",
                        column: x => x.BedspreadsId,
                        principalTable: "Bedspreads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MarketingInfo_Curtains",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MarketingInfo_Pillows",
                        column: x => x.PilloiwsId,
                        principalTable: "Pillows",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MarketingInfo_Sets",
                        column: x => x.SetsId,
                        principalTable: "Sets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false),
                    CurtainsId = table.Column<int>(type: "int", nullable: true),
                    PillowsId = table.Column<int>(type: "int", nullable: true),
                    BedSpreadsId = table.Column<int>(type: "int", nullable: true),
                    SetId = table.Column<int>(type: "int", nullable: true),
                    AccessoriesId = table.Column<int>(type: "int", nullable: true),
                    LambrequinsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOrder_Accessories",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_Bedspreads",
                        column: x => x.BedSpreadsId,
                        principalTable: "Bedspreads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_Curtains",
                        column: x => x.CurtainsId,
                        principalTable: "Curtains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_Lambrequins",
                        column: x => x.LambrequinsId,
                        principalTable: "Lambrequins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_Pillows",
                        column: x => x.PillowsId,
                        principalTable: "Pillows",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_Sets",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrder_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
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
                column: "Width");

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
                column: "Height");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_ManufacturerId",
                table: "Curtains",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtains_ModelId",
                table: "Curtains",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabric_ColorId",
                table: "Fabric",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabric_ConsistencyId",
                table: "Fabric",
                column: "ConsistencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabric_DecorationsId",
                table: "Fabric",
                column: "DecorationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabric_ManufacturerId",
                table: "Fabric",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lambrequins_ColorId",
                table: "Lambrequins",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInfo_BedspreadsId",
                table: "MarketingInfo",
                column: "BedspreadsId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInfo_CurtainsId",
                table: "MarketingInfo",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInfo_PilloiwsId",
                table: "MarketingInfo",
                column: "PilloiwsId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInfo_SetsId",
                table: "MarketingInfo",
                column: "SetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentTypeId",
                table: "Order",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId1",
                table: "Order",
                column: "DeliveryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pillows_FabricId",
                table: "Pillows",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_BedspreadsId",
                table: "Sets",
                column: "BedspreadsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_CurtainsId",
                table: "Sets",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_PillowsId",
                table: "Sets",
                column: "PillowsId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_AccessoriesId",
                table: "UserOrder",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_BedSpreadsId",
                table: "UserOrder",
                column: "BedSpreadsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_CurtainsId",
                table: "UserOrder",
                column: "CurtainsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_LambrequinsId",
                table: "UserOrder",
                column: "LambrequinsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_OrderId",
                table: "UserOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_PillowsId",
                table: "UserOrder",
                column: "PillowsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_SetId",
                table: "UserOrder",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrder_UserId",
                table: "UserOrder",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketingInfo");

            migrationBuilder.DropTable(
                name: "OurWorks");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UserOrder");

            migrationBuilder.DropTable(
                name: "Lambrequins");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "DeliveryType");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Bedspreads");

            migrationBuilder.DropTable(
                name: "Curtains");

            migrationBuilder.DropTable(
                name: "Pillows");

            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "CurtainsKind");

            migrationBuilder.DropTable(
                name: "CurtainsType");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Fabric");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Consistency");

            migrationBuilder.DropTable(
                name: "Decoration");

            migrationBuilder.DropTable(
                name: "Manufacturer");
        }
    }
}