using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationProject.Migrations
{
    public partial class bcc23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UploadedFile",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    fileName = table.Column<string>(nullable: true),
                    userGuid = table.Column<string>(nullable: true),
                    extension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFile", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UploadedFile");
        }
    }
}
