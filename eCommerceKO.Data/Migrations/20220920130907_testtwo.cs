using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceKO.Data.Migrations
{
    public partial class testtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductColourID",
                table: "ProductColors",
                newName: "ProductColorID");

            migrationBuilder.AddColumn<int>(
                name: "DiscountID",
                table: "ProductTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_DiscountID",
                table: "ProductTypes",
                column: "DiscountID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Discounts_DiscountID",
                table: "ProductTypes",
                column: "DiscountID",
                principalTable: "Discounts",
                principalColumn: "DiscountID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Discounts_DiscountID",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_DiscountID",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "DiscountID",
                table: "ProductTypes");

            migrationBuilder.RenameColumn(
                name: "ProductColorID",
                table: "ProductColors",
                newName: "ProductColourID");
        }
    }
}
