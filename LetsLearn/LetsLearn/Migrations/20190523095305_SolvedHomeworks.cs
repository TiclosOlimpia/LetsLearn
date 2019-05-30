using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsLearn.Migrations
{
    public partial class SolvedHomeworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolvedHomeworks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    HomeworkId = table.Column<string>(nullable: false),
                    StudentId = table.Column<string>(nullable: false),
                    CorrectAnswer = table.Column<string>(nullable: false),
                    StudentAnswer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolvedHomeworks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolvedHomeworks");
        }
    }
}
