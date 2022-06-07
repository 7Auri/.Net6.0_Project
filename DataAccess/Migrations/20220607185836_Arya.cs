using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Arya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Fvrcp");

            migrationBuilder.DropTable(
                name: "Leukemia");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Rabies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fvrcps",
                columns: table => new
                {
                    FvrcpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fvrcps", x => x.FvrcpId);
                });

            migrationBuilder.CreateTable(
                name: "Leukemias",
                columns: table => new
                {
                    LeukemiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leukemias", x => x.LeukemiaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fvrcps");

            migrationBuilder.DropTable(
                name: "Leukemias");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Rabies");

            migrationBuilder.CreateTable(
                name: "Fvrcp",
                columns: table => new
                {
                    FvrcpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fvrcp", x => x.FvrcpId);
                });

            migrationBuilder.CreateTable(
                name: "Leukemia",
                columns: table => new
                {
                    LeukemiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leukemia", x => x.LeukemiaId);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FvrcpId = table.Column<int>(type: "int", nullable: false),
                    LeukemiaId = table.Column<int>(type: "int", nullable: false),
                    RabiesId = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccines_Fvrcp_FvrcpId",
                        column: x => x.FvrcpId,
                        principalTable: "Fvrcp",
                        principalColumn: "FvrcpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccines_Leukemia_LeukemiaId",
                        column: x => x.LeukemiaId,
                        principalTable: "Leukemia",
                        principalColumn: "LeukemiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccines_Rabies_RabiesId",
                        column: x => x.RabiesId,
                        principalTable: "Rabies",
                        principalColumn: "RabiesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_FvrcpId",
                table: "Vaccines",
                column: "FvrcpId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_LeukemiaId",
                table: "Vaccines",
                column: "LeukemiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_RabiesId",
                table: "Vaccines",
                column: "RabiesId");
        }
    }
}
