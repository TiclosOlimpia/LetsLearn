using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsLearn.Migrations
{
    public partial class modeifiedHomework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CorrectAnsear",
                table: "Homeworks",
                newName: "CorrectAnswer");

            migrationBuilder.RenameColumn(
                name: "Ansear3",
                table: "Homeworks",
                newName: "Answer3");

            migrationBuilder.RenameColumn(
                name: "Ansear2",
                table: "Homeworks",
                newName: "Answer2");

            migrationBuilder.RenameColumn(
                name: "Ansear1",
                table: "Homeworks",
                newName: "Answer1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CorrectAnswer",
                table: "Homeworks",
                newName: "CorrectAnsear");

            migrationBuilder.RenameColumn(
                name: "Answer3",
                table: "Homeworks",
                newName: "Ansear3");

            migrationBuilder.RenameColumn(
                name: "Answer2",
                table: "Homeworks",
                newName: "Ansear2");

            migrationBuilder.RenameColumn(
                name: "Answer1",
                table: "Homeworks",
                newName: "Ansear1");
        }
    }
}
