using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceKO.Data.Migrations
{
    public partial class testtsix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiscountID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductColorID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductSizeID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CategoryID", "DiscountID", "ProductColorID", "ProductSizeID" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "DiscountID", "ProductColorID", "ProductSizeID" },
                values: new object[] { 2, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CategoryID", "DiscountID", "ProductColorID", "ProductSizeID" },
                values: new object[] { 3, 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DiscountID",
                table: "Products",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductColorID",
                table: "Products",
                column: "ProductColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSizeID",
                table: "Products",
                column: "ProductSizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_DiscountID",
                table: "Products",
                column: "DiscountID",
                principalTable: "Discounts",
                principalColumn: "DiscountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductColors_ProductColorID",
                table: "Products",
                column: "ProductColorID",
                principalTable: "ProductColors",
                principalColumn: "ProductColorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSizes_ProductSizeID",
                table: "Products",
                column: "ProductSizeID",
                principalTable: "ProductSizes",
                principalColumn: "ProductSizeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_DiscountID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductColors_ProductColorID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSizes_ProductSizeID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DiscountID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductColorID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductSizeID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductColorID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductSizeID",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    ProductTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    DiscountID = table.Column<int>(type: "int", nullable: false),
                    ProductColorID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ProductSizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.ProductTypeID);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Discounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "DiscountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypes_ProductColors_ProductColorID",
                        column: x => x.ProductColorID,
                        principalTable: "ProductColors",
                        principalColumn: "ProductColorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypes_ProductSizes_ProductSizeID",
                        column: x => x.ProductSizeID,
                        principalTable: "ProductSizes",
                        principalColumn: "ProductSizeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeID", "CategoryID", "DiscountID", "ProductColorID", "ProductID", "ProductSizeID" },
                values: new object[] { 1, 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeID", "CategoryID", "DiscountID", "ProductColorID", "ProductID", "ProductSizeID" },
                values: new object[] { 2, 1, 2, 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeID", "CategoryID", "DiscountID", "ProductColorID", "ProductID", "ProductSizeID" },
                values: new object[] { 3, 1, 3, 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_CategoryID",
                table: "ProductTypes",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_DiscountID",
                table: "ProductTypes",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductColorID",
                table: "ProductTypes",
                column: "ProductColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductID",
                table: "ProductTypes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductSizeID",
                table: "ProductTypes",
                column: "ProductSizeID");
        }
    }
}
