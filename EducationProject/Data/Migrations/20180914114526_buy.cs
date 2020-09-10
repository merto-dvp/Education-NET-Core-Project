using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Migrations
{
    public partial class buy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "UserCredit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "UserCredit");
        }
    }
}
