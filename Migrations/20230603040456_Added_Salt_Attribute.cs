using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestin.Migrations
{
    public partial class Added_Salt_Attribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "LoginInformation",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "LoginInformation");
        }
    }
}
