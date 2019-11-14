using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class CorreccionTablaEvaluacionEstudioSocioeconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_ItemsEstudioSocioeconomico_~",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_ItemEstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropColumn(
                name: "ItemEstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ItemEstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_ItemEstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico",
                column: "ItemEstudioSocioeconomicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_ItemsEstudioSocioeconomico_~",
                table: "EvaluacionEstudioSocioeconomico",
                column: "ItemEstudioSocioeconomicoId",
                principalTable: "ItemsEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
