using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestin.Migrations
{
    public partial class ExamFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Exam",
                newName: "IdSubject");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Exam",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "('0001-01-01T00:00:00.0000000')",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_IdSubject",
                table: "Exam",
                column: "IdSubject");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Subject",
                table: "Exam",
                column: "IdSubject",
                principalTable: "Subject",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Subject",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Exam_IdSubject",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "IdSubject",
                table: "Exam",
                newName: "Subject");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Exam",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "('0001-01-01T00:00:00.0000000')");
        }
    }
}
