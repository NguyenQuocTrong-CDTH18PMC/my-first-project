using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCodeFirst.Migrations
{
    public partial class OrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUSTOMER_ID = table.Column<int>(nullable: true),
                    SHIP_NAME = table.Column<string>(maxLength: 200, nullable: true),
                    SHIP_SDT = table.Column<string>(maxLength: 10, nullable: true),
                    SHIP_EMAIL = table.Column<string>(maxLength: 200, nullable: true),
                    SHIP_ADDRESS = table.Column<string>(maxLength: 200, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(nullable: false),
                    STATUS = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    PRICE = table.Column<double>(nullable: true),
                    IMAGE = table.Column<string>(nullable: true),
                    DATE = table.Column<DateTime>(nullable: true),
                    STATUS = table.Column<int>(nullable: false),
                    GROUP_PRODUCT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QUANTITY = table.Column<int>(nullable: false),
                    PRICE = table.Column<decimal>(type: "money", nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Details_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Details_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_OrderID",
                table: "Order_Details",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_ProductID",
                table: "Order_Details",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order_Details");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
