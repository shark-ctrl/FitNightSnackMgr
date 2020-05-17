using Microsoft.EntityFrameworkCore.Migrations;

namespace FitNightSnackMgr.Migrations
{
    public partial class add_permissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Permissions",
                table: "Admin",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "Admin");
        }
    }
}
