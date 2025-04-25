using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestin.Migrations
{
    public partial class ModifiedTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tenured",
                table: "TeacherSubject");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "TeacherSubject");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "SubjectEnrolment",
                newName: "StudentId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "TeacherSubject",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSince",
                table: "TeacherSubject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUntil",
                table: "TeacherSubject",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookRecord",
                table: "Grade",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccreditationDate",
                table: "Grade",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "AccreditationType",
                table: "Grade",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectEnrolment_StudentId",
                table: "SubjectEnrolment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Career",
                table: "Career",
                column: "Resolution",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectEnrolment_Student",
                table: "SubjectEnrolment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectEnrolment_Student",
                table: "SubjectEnrolment");

            migrationBuilder.DropIndex(
                name: "IX_SubjectEnrolment_StudentId",
                table: "SubjectEnrolment");

            migrationBuilder.DropIndex(
                name: "IX_Career",
                table: "Career");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "TeacherSubject");

            migrationBuilder.DropColumn(
                name: "DateSince",
                table: "TeacherSubject");

            migrationBuilder.DropColumn(
                name: "DateUntil",
                table: "TeacherSubject");

            migrationBuilder.DropColumn(
                name: "AccreditationType",
                table: "Grade");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "SubjectEnrolment",
                newName: "UsersId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "User",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Tenured",
                table: "TeacherSubject",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "TeacherSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "BookRecord",
                table: "Grade",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccreditationDate",
                table: "Grade",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
