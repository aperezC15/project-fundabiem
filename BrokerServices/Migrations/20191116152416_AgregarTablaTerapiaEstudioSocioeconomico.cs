using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class AgregarTablaTerapiaEstudioSocioeconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_EstudioSocioeconomico_Estud~",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_OpcionesItemsEstudioSocioec~",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvaluacionEstudioSocioeconomico",
                table: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.RenameTable(
                name: "EvaluacionEstudioSocioeconomico",
                newName: "EvaluacionesEstudioSocioeconomico");

            migrationBuilder.RenameIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_OpcionItemEstudioSocioecono~",
                table: "EvaluacionesEstudioSocioeconomico",
                newName: "IX_EvaluacionesEstudioSocioeconomico_OpcionItemEstudioSocioeco~");

            migrationBuilder.RenameIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_EstudioSocioeconomicoId",
                table: "EvaluacionesEstudioSocioeconomico",
                newName: "IX_EvaluacionesEstudioSocioeconomico_EstudioSocioeconomicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvaluacionesEstudioSocioeconomico",
                table: "EvaluacionesEstudioSocioeconomico",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TerapiasEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EstudioSocioeconomicoId = table.Column<long>(nullable: false),
                    IdTerapia = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerapiasEstudioSocioeconomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerapiasEstudioSocioeconomico_EstudioSocioeconomico_Estudio~",
                        column: x => x.EstudioSocioeconomicoId,
                        principalTable: "EstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TerapiasEstudioSocioeconomico_Terapias_IdTerapia",
                        column: x => x.IdTerapia,
                        principalTable: "Terapias",
                        principalColumn: "IdTerapia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TerapiasEstudioSocioeconomico_EstudioSocioeconomicoId",
                table: "TerapiasEstudioSocioeconomico",
                column: "EstudioSocioeconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_TerapiasEstudioSocioeconomico_IdTerapia",
                table: "TerapiasEstudioSocioeconomico",
                column: "IdTerapia");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionesEstudioSocioeconomico_EstudioSocioeconomico_Est~",
                table: "EvaluacionesEstudioSocioeconomico",
                column: "EstudioSocioeconomicoId",
                principalTable: "EstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionesEstudioSocioeconomico_OpcionesItemsEstudioSocio~",
                table: "EvaluacionesEstudioSocioeconomico",
                column: "OpcionItemEstudioSocioeconomicoId",
                principalTable: "OpcionesItemsEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionesEstudioSocioeconomico_EstudioSocioeconomico_Est~",
                table: "EvaluacionesEstudioSocioeconomico");

            migrationBuilder.DropForeignKey(
                name: "FK_EvaluacionesEstudioSocioeconomico_OpcionesItemsEstudioSocio~",
                table: "EvaluacionesEstudioSocioeconomico");

            migrationBuilder.DropTable(
                name: "TerapiasEstudioSocioeconomico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvaluacionesEstudioSocioeconomico",
                table: "EvaluacionesEstudioSocioeconomico");

            migrationBuilder.RenameTable(
                name: "EvaluacionesEstudioSocioeconomico",
                newName: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.RenameIndex(
                name: "IX_EvaluacionesEstudioSocioeconomico_OpcionItemEstudioSocioeco~",
                table: "EvaluacionEstudioSocioeconomico",
                newName: "IX_EvaluacionEstudioSocioeconomico_OpcionItemEstudioSocioecono~");

            migrationBuilder.RenameIndex(
                name: "IX_EvaluacionesEstudioSocioeconomico_EstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico",
                newName: "IX_EvaluacionEstudioSocioeconomico_EstudioSocioeconomicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvaluacionEstudioSocioeconomico",
                table: "EvaluacionEstudioSocioeconomico",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_EstudioSocioeconomico_Estud~",
                table: "EvaluacionEstudioSocioeconomico",
                column: "EstudioSocioeconomicoId",
                principalTable: "EstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluacionEstudioSocioeconomico_OpcionesItemsEstudioSocioec~",
                table: "EvaluacionEstudioSocioeconomico",
                column: "OpcionItemEstudioSocioeconomicoId",
                principalTable: "OpcionesItemsEstudioSocioeconomico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
