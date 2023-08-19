using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VintageShop.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionZapatoYTalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZapatoId",
                table: "Talles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talles_ZapatoId",
                table: "Talles",
                column: "ZapatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Talles_Zapatos_ZapatoId",
                table: "Talles",
                column: "ZapatoId",
                principalTable: "Zapatos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talles_Zapatos_ZapatoId",
                table: "Talles");

            migrationBuilder.DropIndex(
                name: "IX_Talles_ZapatoId",
                table: "Talles");

            migrationBuilder.DropColumn(
                name: "ZapatoId",
                table: "Talles");
        }
    }
}
