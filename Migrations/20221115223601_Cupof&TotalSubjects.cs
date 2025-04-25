using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestin.Migrations
{
    public partial class CupofTotalSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cupof",
                table: "Subject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountSubjects",
                table: "Career",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cupof",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "TotalAmountSubjects",
                table: "Career");
        }
    }
}
