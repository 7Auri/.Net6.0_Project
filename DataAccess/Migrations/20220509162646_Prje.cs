using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Prje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Birtday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DryFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DryFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fvrcp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fvrcp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Healths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sterilization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disease = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leukemia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leukemia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaltVits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Malt = table.Column<bool>(type: "bit", nullable: true),
                    MaltTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vitamin = table.Column<bool>(type: "bit", nullable: true),
                    VitTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaltVits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rabies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vaccine = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rabies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WetFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WetFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RabiesId = table.Column<int>(type: "int", nullable: false),
                    LeukemiaId = table.Column<int>(type: "int", nullable: false),
                    FvrcpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccines_Fvrcp_FvrcpId",
                        column: x => x.FvrcpId,
                        principalTable: "Fvrcp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccines_Leukemia_LeukemiaId",
                        column: x => x.LeukemiaId,
                        principalTable: "Leukemia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccines_Rabies_RabiesId",
                        column: x => x.RabiesId,
                        principalTable: "Rabies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WetFoodId = table.Column<int>(type: "int", nullable: true),
                    DryFoodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_DryFood_DryFoodId",
                        column: x => x.DryFoodId,
                        principalTable: "DryFood",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Foods_WetFood_WetFoodId",
                        column: x => x.WetFoodId,
                        principalTable: "WetFood",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_DryFoodId",
                table: "Foods",
                column: "DryFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_WetFoodId",
                table: "Foods",
                column: "WetFoodId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Healths");

            migrationBuilder.DropTable(
                name: "MaltVits");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "DryFood");

            migrationBuilder.DropTable(
                name: "WetFood");

            migrationBuilder.DropTable(
                name: "Fvrcp");

            migrationBuilder.DropTable(
                name: "Leukemia");

            migrationBuilder.DropTable(
                name: "Rabies");
        }
    }
}
