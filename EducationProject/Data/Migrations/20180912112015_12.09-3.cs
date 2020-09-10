using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Data.Migrations
{
    public partial class _12093 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credit",
                table: "UserCourse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Credit",
                table: "UserCourse",
                nullable: false,
                defaultValue: 0);
        }
    }
}
