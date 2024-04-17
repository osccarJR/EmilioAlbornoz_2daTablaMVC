using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmilioAlbornoz_WebCF.Migrations
{
    /// <inheritdoc />
    public partial class Inicio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    PromoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BurgerID = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BurgerID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.PromoID);
                    table.ForeignKey(
                        name: "FK_Promo_Burger_BurgerID1",
                        column: x => x.BurgerID1,
                        principalTable: "Burger",
                        principalColumn: "BurgerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_BurgerID1",
                table: "Promo",
                column: "BurgerID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
