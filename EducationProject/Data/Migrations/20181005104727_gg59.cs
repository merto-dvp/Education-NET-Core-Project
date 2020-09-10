using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Migrations
{
    public partial class gg59 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "Course");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "Course",
                nullable: false,
                defaultValue: false);
        }
    }
}
