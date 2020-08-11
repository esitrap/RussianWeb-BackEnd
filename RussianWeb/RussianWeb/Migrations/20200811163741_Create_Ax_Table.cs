using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RussianWeb.Migrations
{
    public partial class Create_Ax_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ax",
                table: "Posts");

            migrationBuilder.AddColumn<Guid>(
                name: "AxId",
                table: "Posts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Axes",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    ax = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Axes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Axes");

            migrationBuilder.DropColumn(
                name: "AxId",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Ax",
                table: "Posts",
                nullable: true);
        }
    }
}
