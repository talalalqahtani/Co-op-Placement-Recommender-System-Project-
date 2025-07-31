using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMajor.Migrations
{
    public partial class EDITREPORT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Majors_MajorSuggestedId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_MajorSuggestedId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "MajorSuggestedId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "MajorChoosenId",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Recommendation",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_MajorChoosenId",
                table: "Reports",
                column: "MajorChoosenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Majors_MajorChoosenId",
                table: "Reports",
                column: "MajorChoosenId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Majors_MajorChoosenId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_MajorChoosenId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "MajorChoosenId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Recommendation",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "MajorSuggestedId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_MajorSuggestedId",
                table: "Reports",
                column: "MajorSuggestedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Majors_MajorSuggestedId",
                table: "Reports",
                column: "MajorSuggestedId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
