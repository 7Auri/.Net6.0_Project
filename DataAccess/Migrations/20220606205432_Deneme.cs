using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatId",
                table: "WetFoods");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "DryFoods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "WetFoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "DryFoods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
