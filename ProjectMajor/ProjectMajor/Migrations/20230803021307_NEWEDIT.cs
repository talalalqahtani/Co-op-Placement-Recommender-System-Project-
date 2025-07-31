using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMajor.Migrations
{
    public partial class NEWEDIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Majors_Colleges_CollegeId",
                table: "Majors");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Colleges_CollegeId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Colleges_CollegeId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Majors_MajorId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Students_StudentId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Colleges_CollegeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Majors_Colleges_CollegeId",
                table: "Majors",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Colleges_CollegeId",
                table: "Questions",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Colleges_CollegeId",
                table: "Reports",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Majors_MajorId",
                table: "Reports",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Students_StudentId",
                table: "Reports",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Colleges_CollegeId",
                table: "Users",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Majors_Colleges_CollegeId",
                table: "Majors");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Colleges_CollegeId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Colleges_CollegeId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Majors_MajorId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Students_StudentId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Colleges_CollegeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Majors_Colleges_CollegeId",
                table: "Majors",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Colleges_CollegeId",
                table: "Questions",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Colleges_CollegeId",
                table: "Reports",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Majors_MajorId",
                table: "Reports",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Students_StudentId",
                table: "Reports",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Colleges_CollegeId",
                table: "Users",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
