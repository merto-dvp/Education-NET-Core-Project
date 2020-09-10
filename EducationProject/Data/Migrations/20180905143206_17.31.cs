using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Data.Migrations
{
    public partial class _1731 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailDescription",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trainer",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DetailDescription",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Trainer",
                table: "Course");
        }
    }
}
