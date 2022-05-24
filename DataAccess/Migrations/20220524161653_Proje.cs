using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Proje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_DryFoods_DryFoodId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_WetFoods_WetFoodId",
                table: "Foods");

            migrationBuilder.AlterColumn<int>(
                name: "WetFoodId",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DryFoodId",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_DryFoods_DryFoodId",
                table: "Foods",
                column: "DryFoodId",
                principalTable: "DryFoods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_WetFoods_WetFoodId",
                table: "Foods",
                column: "WetFoodId",
                principalTable: "WetFoods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_DryFoods_DryFoodId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_WetFoods_WetFoodId",
                table: "Foods");

            migrationBuilder.AlterColumn<int>(
                name: "WetFoodId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DryFoodId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_DryFoods_DryFoodId",
                table: "Foods",
                column: "DryFoodId",
                principalTable: "DryFoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_WetFoods_WetFoodId",
                table: "Foods",
                column: "WetFoodId",
                principalTable: "WetFoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
