using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Vaccines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "MaltVits",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Healths",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_CatId",
                table: "Vaccines",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_MaltVits_CatId",
                table: "MaltVits",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_CatId",
                table: "Healths",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CatId",
                table: "Foods",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Cats_CatId",
                table: "Foods",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Healths_Cats_CatId",
                table: "Healths",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaltVits_Cats_CatId",
                table: "MaltVits",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_Cats_CatId",
                table: "Vaccines",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Cats_CatId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Healths_Cats_CatId",
                table: "Healths");

            migrationBuilder.DropForeignKey(
                name: "FK_MaltVits_Cats_CatId",
                table: "MaltVits");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccines_Cats_CatId",
                table: "Vaccines");

            migrationBuilder.DropIndex(
                name: "IX_Vaccines_CatId",
                table: "Vaccines");

            migrationBuilder.DropIndex(
                name: "IX_MaltVits_CatId",
                table: "MaltVits");

            migrationBuilder.DropIndex(
                name: "IX_Healths_CatId",
                table: "Healths");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CatId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Vaccines");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "MaltVits");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Healths");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Foods");
        }
    }
}
