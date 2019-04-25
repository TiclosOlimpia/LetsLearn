using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsLearn.Migrations
{
    public partial class homework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_homework");

            migrationBuilder.DropColumn(
                name: "Observations",
                table: "Homeworks");

            migrationBuilder.AddColumn<string>(
                name: "Ansear1",
                table: "Homeworks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ansear2",
                table: "Homeworks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ansear3",
                table: "Homeworks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Clasa",
                table: "Homeworks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Container",
                table: "Homeworks",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CorrectAnsear",
                table: "Homeworks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Week",
                table: "Homeworks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ansear1",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "Ansear2",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "Ansear3",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "Clasa",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "Container",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "CorrectAnsear",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "Week",
                table: "Homeworks");

            migrationBuilder.AddColumn<string>(
                name: "Observations",
                table: "Homeworks",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User_homework",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    homeworkId = table.Column<string>(nullable: true),
                    userId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_homework", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_homework_Homeworks_homeworkId",
                        column: x => x.homeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_homework_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_homework_homeworkId",
                table: "User_homework",
                column: "homeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_User_homework_userId",
                table: "User_homework",
                column: "userId");
        }
    }
}
