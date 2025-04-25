using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestin.Migrations
{
    public partial class Added_primary_key_to_exam_enrolment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamEnrolment",
                table: "ExamEnrolment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EXAMENESENROLMENT",
                table: "ExamEnrolment",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamEnrolment",
                table: "ExamEnrolment");

            migrationBuilder.DropIndex(
                name: "IX_EXAMENESENROLMENT",
                table: "ExamEnrolment");
        }
    }
}
