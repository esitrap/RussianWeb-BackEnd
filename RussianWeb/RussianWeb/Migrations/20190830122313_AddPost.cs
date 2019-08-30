using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RussianWeb.Migrations
{
    public partial class AddPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Onvan = table.Column<string>(nullable: false),
                    TarikheEnteshar = table.Column<DateTime>(nullable: false),
                    KholaseyePost = table.Column<string>(nullable: true),
                    MatneKamelePost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Onvan);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
