using Microsoft.EntityFrameworkCore.Migrations;

namespace Code.Migrations
{
    public partial class AddedForSaleTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_AspNetUsers_AppUserId1",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_AppUserId1",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Sales");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "SaleProducts",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "SaleProducts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "SaleProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_AppUserId",
                table: "Sales",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_AspNetUsers_AppUserId",
                table: "Sales",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_AspNetUsers_AppUserId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_AppUserId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "SaleProducts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SaleProducts");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "SaleProducts");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Sales",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Sales",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_AppUserId1",
                table: "Sales",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_AspNetUsers_AppUserId1",
                table: "Sales",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
