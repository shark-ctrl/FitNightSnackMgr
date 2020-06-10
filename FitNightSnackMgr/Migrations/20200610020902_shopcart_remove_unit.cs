using Microsoft.EntityFrameworkCore.Migrations;

namespace FitNightSnackMgr.Migrations
{
    public partial class shopcart_remove_unit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Num",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "SnackNum",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "UnitNum",
                table: "ShoppingCart");

            migrationBuilder.AddColumn<int>(
                name: "SnackCount",
                table: "ShoppingCart",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SnackId",
                table: "ShoppingCart",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SnackCount",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "SnackId",
                table: "ShoppingCart");

            migrationBuilder.AddColumn<int>(
                name: "Num",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SnackNum",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitNum",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
