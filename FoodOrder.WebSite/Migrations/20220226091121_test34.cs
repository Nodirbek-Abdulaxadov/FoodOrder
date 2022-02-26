using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrder.WebSite.Migrations
{
    public partial class test34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mahsulot",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nomi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Batafsil = table.Column<string>(type: "text", nullable: true),
                    Narxi = table.Column<double>(type: "double precision", nullable: false),
                    KategoriyaId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodOrderWebSiteUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahsulot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahsulot_AspNetUsers_FoodOrderWebSiteUserId",
                        column: x => x.FoodOrderWebSiteUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mahsulot_FoodOrderWebSiteUserId",
                table: "Mahsulot",
                column: "FoodOrderWebSiteUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mahsulot");
        }
    }
}
