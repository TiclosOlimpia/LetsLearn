using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsLearn.Migrations
{
    public partial class gridExercices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.CreateTable(
                name: "GridExercices",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Container = table.Column<string>(maxLength: 100, nullable: false),
                    CorrectAnswer = table.Column<string>(nullable: false),
                    Answer1 = table.Column<string>(nullable: false),
                    Answer2 = table.Column<string>(nullable: false),
                    Answer3 = table.Column<string>(nullable: false),
                    Week = table.Column<int>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    Clasa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GridExercices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GridExercices");

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Answer1 = table.Column<string>(nullable: false),
                    Answer2 = table.Column<string>(nullable: false),
                    Answer3 = table.Column<string>(nullable: false),
                    Clasa = table.Column<string>(nullable: false),
                    Container = table.Column<string>(maxLength: 100, nullable: false),
                    CorrectAnswer = table.Column<string>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Week = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                });
        }
    }
}
