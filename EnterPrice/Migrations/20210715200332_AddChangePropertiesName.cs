using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterPrice.Migrations
{
    public partial class AddChangePropertiesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SuperVisor",
                newName: "Number");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Wokers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Buidings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Wokers");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Buidings");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "SuperVisor",
                newName: "Name");
        }
    }
}
