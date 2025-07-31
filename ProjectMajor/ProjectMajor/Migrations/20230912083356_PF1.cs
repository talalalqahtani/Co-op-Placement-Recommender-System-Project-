using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMajor.Migrations
{
    public partial class PF1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Result",
                table: "Reports",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Result",
                table: "Reports",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
