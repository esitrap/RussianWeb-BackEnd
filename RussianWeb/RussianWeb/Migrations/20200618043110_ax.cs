using Microsoft.EntityFrameworkCore.Migrations;

namespace RussianWeb.Migrations
{
    public partial class ax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ax",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ax",
                table: "Posts");
        }
    }
}
