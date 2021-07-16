using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterPrice.Migrations
{
    public partial class AddChangePropertiesNameWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Wokers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Job",
                table: "Wokers");
        }
    }
}
