using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceKO.Data.Migrations
{
    public partial class testfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductBarcode", "ProductDescription", "ProductName", "ProductPic", "ProductPrice" },
                values: new object[] { 1, "123123123", "test description1", "Test Product 1", null, 100.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductBarcode", "ProductDescription", "ProductName", "ProductPic", "ProductPrice" },
                values: new object[] { 2, "131543123", "test description2", "Test Product 2", null, 200.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductBarcode", "ProductDescription", "ProductName", "ProductPic", "ProductPrice" },
                values: new object[] { 3, "128790123", "test description3", "Test Product 3", null, 300.0 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);
        }
    }
}
