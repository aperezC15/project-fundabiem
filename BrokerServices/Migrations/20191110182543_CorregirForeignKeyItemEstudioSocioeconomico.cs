using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class CorregirForeignKeyItemEstudioSocioeconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsEstudioSocioeconomico_SeccionesEstudioSocioeconomico_s~",
                table: "ItemsEstudioSocioeconomico");

            migrationBuilder.DropIndex(
                name: "IX_ItemsEstudioSocioeconomico_seccionId",
                table: "ItemsEstudioSocioeconomico");

            migrationBuilder.DropColumn(
                name: "seccionId",
                table: "ItemsEstudioSocioeconomico");

            migrationBuilder.RenameColumn(
                name: "idSeccionEstudioSocioeconomico",
                table: "ItemsEstudioSocioeconomico",
                newName: "SeccionEstudioSocioeconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsEstudioSocioeconomico_SeccionEstudioSocioeconomicoId",
                table: "ItemsEstudioSocioeconomico",
                column: "SeccionEstudioSocioeconomicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsEstudioSocioeconomico_SeccionesEstudioSocioeconomico_S~",
                table: "ItemsEstudioSocioeconomico",
                column: "SeccionEstudioSocioeconomicoId",
                principalTable: "SeccionesEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsEstudioSocioeconomico_SeccionesEstudioSocioeconomico_S~",
                table: "ItemsEstudioSocioeconomico");

            migrationBuilder.DropIndex(
                name: "IX_ItemsEstudioSocioeconomico_SeccionEstudioSocioeconomicoId",
                table: "ItemsEstudioSocioeconomico");

            migrationBuilder.RenameColumn(
                name: "SeccionEstudioSocioeconomicoId",
                table: "ItemsEstudioSocioeconomico",
                newName: "idSeccionEstudioSocioeconomico");

            migrationBuilder.AddColumn<long>(
                name: "seccionId",
                table: "ItemsEstudioSocioeconomico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemsEstudioSocioeconomico_seccionId",
                table: "ItemsEstudioSocioeconomico",
                column: "seccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsEstudioSocioeconomico_SeccionesEstudioSocioeconomico_s~",
                table: "ItemsEstudioSocioeconomico",
                column: "seccionId",
                principalTable: "SeccionesEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
