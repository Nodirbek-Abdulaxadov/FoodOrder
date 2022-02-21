using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrder.DataLayer.Migrations
{
    public partial class test21323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rasmi",
                table: "Mahsulotlar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rasmi",
                table: "Mahsulotlar",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
