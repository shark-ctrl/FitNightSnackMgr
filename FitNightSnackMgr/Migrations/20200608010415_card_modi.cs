using Microsoft.EntityFrameworkCore.Migrations;

namespace FitNightSnackMgr.Migrations
{
    public partial class card_modi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "prepaidCard",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "prepaidCard",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "prepaidCard");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "prepaidCard",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
