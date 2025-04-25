using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestin.Migrations
{
    public partial class ActiveCareerTeacherTitlenullableDataSinceTeacherSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateSince",
                table: "TeacherSubject",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Career",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Career");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateSince",
                table: "TeacherSubject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
