using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterPrice.Migrations
{
    public partial class AddInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buidings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buidings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperVisor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperVisor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wokers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryPerHour = table.Column<double>(type: "float", nullable: false),
                    SuperVisorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wokers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wokers_SuperVisor_SuperVisorId",
                        column: x => x.SuperVisorId,
                        principalTable: "SuperVisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asigments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuidingId = table.Column<int>(type: "int", nullable: true),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asigments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asigments_Buidings_BuidingId",
                        column: x => x.BuidingId,
                        principalTable: "Buidings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asigments_Wokers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Wokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asigments_BuidingId",
                table: "Asigments",
                column: "BuidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Asigments_WorkerId",
                table: "Asigments",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wokers_SuperVisorId",
                table: "Wokers",
                column: "SuperVisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asigments");

            migrationBuilder.DropTable(
                name: "Buidings");

            migrationBuilder.DropTable(
                name: "Wokers");

            migrationBuilder.DropTable(
                name: "SuperVisor");
        }
    }
}
