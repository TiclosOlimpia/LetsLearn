using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsLearn.Migrations
{
    public partial class homeworkString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Homework",
                table: "Grades",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Homework",
                table: "Grades",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
