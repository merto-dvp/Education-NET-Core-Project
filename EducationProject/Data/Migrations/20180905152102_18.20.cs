using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Data.Migrations
{
    public partial class _1820 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VidCategory",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VidCategory",
                table: "Course");
        }
    }
}
