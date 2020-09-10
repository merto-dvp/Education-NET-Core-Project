using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Migrations
{
    public partial class ab23d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "UploadedFile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "imgExt",
                table: "UploadedFile",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "UploadedFile");

            migrationBuilder.DropColumn(
                name: "imgExt",
                table: "UploadedFile");
        }
    }
}
