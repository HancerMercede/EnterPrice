using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterPrice.Migrations
{
    public partial class AddEditinAsigmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asigments_Buidings_BuidingId",
                table: "Asigments");

            migrationBuilder.DropIndex(
                name: "IX_Asigments_BuidingId",
                table: "Asigments");

            migrationBuilder.DropColumn(
                name: "BuidingId",
                table: "Asigments");

            migrationBuilder.CreateIndex(
                name: "IX_Asigments_BuildingId",
                table: "Asigments",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asigments_Buidings_BuildingId",
                table: "Asigments",
                column: "BuildingId",
                principalTable: "Buidings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asigments_Buidings_BuildingId",
                table: "Asigments");

            migrationBuilder.DropIndex(
                name: "IX_Asigments_BuildingId",
                table: "Asigments");

            migrationBuilder.AddColumn<int>(
                name: "BuidingId",
                table: "Asigments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asigments_BuidingId",
                table: "Asigments",
                column: "BuidingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asigments_Buidings_BuidingId",
                table: "Asigments",
                column: "BuidingId",
                principalTable: "Buidings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
