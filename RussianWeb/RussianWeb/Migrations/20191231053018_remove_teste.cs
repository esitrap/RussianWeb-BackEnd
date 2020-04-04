using Microsoft.EntityFrameworkCore.Migrations;

namespace RussianWeb.Migrations
{
    public partial class remove_teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }
    }
}
