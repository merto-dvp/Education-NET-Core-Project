using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Data.Migrations
{
    public partial class mm2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Course");
        }
    }
}
