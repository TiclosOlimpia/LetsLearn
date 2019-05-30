using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsLearn.Migrations
{
    public partial class average : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Medie",
                table: "Users",
                newName: "Average");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Average",
                table: "Users",
                newName: "Medie");
        }
    }
}
