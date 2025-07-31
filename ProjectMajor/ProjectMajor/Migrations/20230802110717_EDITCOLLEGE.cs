using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMajor.Migrations
{
    public partial class EDITCOLLEGE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Majors_Collages_CollageId",
                table: "Majors");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Collages_CollageId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Collages_CollageId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Collages_CollageId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Collages_CollageId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Collages");

            migrationBuilder.DropIndex(
                name: "IX_Users_CollageId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Students_CollageId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CollageId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CollageId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Majors_CollageId",
                table: "Majors");

            migrationBuilder.DropColumn(
                name: "CollageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CollageId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CollageId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CollageId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CollageId",
                table: "Majors");

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Majors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CollegeId",
                table: "Users",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollegeId",
                table: "Students",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CollegeId",
                table: "Reports",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CollegeId",
                table: "Questions",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_CollegeId",
                table: "Majors",
                column: "CollegeId");

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
                name: "FK_Students_Colleges_CollegeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Colleges_CollegeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropIndex(
                name: "IX_Users_CollegeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Students_CollegeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CollegeId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CollegeId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Majors_CollegeId",
                table: "Majors");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Majors");

            migrationBuilder.AddColumn<int>(
                name: "CollageId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollageId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollageId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollageId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollageId",
                table: "Majors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Collages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CollageId",
                table: "Users",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollageId",
                table: "Students",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CollageId",
                table: "Reports",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CollageId",
                table: "Questions",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_CollageId",
                table: "Majors",
                column: "CollageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Majors_Collages_CollageId",
                table: "Majors",
                column: "CollageId",
                principalTable: "Collages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Collages_CollageId",
                table: "Questions",
                column: "CollageId",
                principalTable: "Collages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Collages_CollageId",
                table: "Reports",
                column: "CollageId",
                principalTable: "Collages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Collages_CollageId",
                table: "Students",
                column: "CollageId",
                principalTable: "Collages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Collages_CollageId",
                table: "Users",
                column: "CollageId",
                principalTable: "Collages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
