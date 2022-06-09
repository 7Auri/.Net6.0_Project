using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Arya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Healths_Cats_CatId",
                table: "Healths");

            migrationBuilder.DropIndex(
                name: "IX_Healths_CatId",
                table: "Healths");

            migrationBuilder.AlterColumn<int>(
                name: "CatId",
                table: "Healths",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CatId",
                table: "Healths",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_CatId",
                table: "Healths",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Healths_Cats_CatId",
                table: "Healths",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");
        }
    }
}
