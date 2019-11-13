using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class OpcionesItemsEstudioSocioeconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_OpcionItemEstudioSocioecono~",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcionItemEstudioSocioeconomico_ItemsEstudioSocioeconomico_~",
                table: "OpcionItemEstudioSocioeconomico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpcionItemEstudioSocioeconomico",
                table: "OpcionItemEstudioSocioeconomico");

            migrationBuilder.RenameTable(
                name: "OpcionItemEstudioSocioeconomico",
                newName: "OpcionesItemsEstudioSocioeconomico");

            migrationBuilder.RenameIndex(
                name: "IX_OpcionItemEstudioSocioeconomico_ItemEstudioSocioeconomicoId",
                table: "OpcionesItemsEstudioSocioeconomico",
                newName: "IX_OpcionesItemsEstudioSocioeconomico_ItemEstudioSocioeconomic~");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpcionesItemsEstudioSocioeconomico",
                table: "OpcionesItemsEstudioSocioeconomico",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_OpcionesItemsEstudioSocioec~",
                table: "EvaluacionEstudioSocioeconomico",
                column: "OpcionItemEstudioSocioeconomicoId",
                principalTable: "OpcionesItemsEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesItemsEstudioSocioeconomico_ItemsEstudioSocioeconomi~",
                table: "OpcionesItemsEstudioSocioeconomico",
                column: "ItemEstudioSocioeconomicoId",
                principalTable: "ItemsEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_OpcionesItemsEstudioSocioec~",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesItemsEstudioSocioeconomico_ItemsEstudioSocioeconomi~",
                table: "OpcionesItemsEstudioSocioeconomico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpcionesItemsEstudioSocioeconomico",
                table: "OpcionesItemsEstudioSocioeconomico");

            migrationBuilder.RenameTable(
                name: "OpcionesItemsEstudioSocioeconomico",
                newName: "OpcionItemEstudioSocioeconomico");

            migrationBuilder.RenameIndex(
                name: "IX_OpcionesItemsEstudioSocioeconomico_ItemEstudioSocioeconomic~",
                table: "OpcionItemEstudioSocioeconomico",
                newName: "IX_OpcionItemEstudioSocioeconomico_ItemEstudioSocioeconomicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpcionItemEstudioSocioeconomico",
                table: "OpcionItemEstudioSocioeconomico",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_OpcionItemEstudioSocioecono~",
                table: "EvaluacionEstudioSocioeconomico",
                column: "OpcionItemEstudioSocioeconomicoId",
                principalTable: "OpcionItemEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionItemEstudioSocioeconomico_ItemsEstudioSocioeconomico_~",
                table: "OpcionItemEstudioSocioeconomico",
                column: "ItemEstudioSocioeconomicoId",
                principalTable: "ItemsEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
