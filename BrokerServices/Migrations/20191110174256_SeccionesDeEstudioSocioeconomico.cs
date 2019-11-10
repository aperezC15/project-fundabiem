using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class SeccionesDeEstudioSocioeconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    fechaEntrevista = table.Column<DateTime>(nullable: false),
                    motivoSolicitud = table.Column<string>(maxLength: 5000, nullable: false),
                    diagnosticoSocial = table.Column<string>(maxLength: 5000, nullable: false),
                    opinionTS = table.Column<string>(maxLength: 5000, nullable: false),
                    observaciones = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudioSocioeconomico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeccionesEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeccionesEstudioSocioeconomico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoFamiliar",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EstudioSocioeconomicoId = table.Column<long>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    EstadoCivil = table.Column<string>(maxLength: 50, nullable: false),
                    Parentezco = table.Column<string>(maxLength: 100, nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Escolaridad = table.Column<string>(maxLength: 100, nullable: false),
                    Ocupacion = table.Column<string>(maxLength: 100, nullable: false),
                    salario = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoFamiliar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupoFamiliar_EstudioSocioeconomico_EstudioSocioeconomicoId",
                        column: x => x.EstudioSocioeconomicoId,
                        principalTable: "EstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemsEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idSeccionEstudioSocioeconomico = table.Column<long>(nullable: false),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(maxLength: 255, nullable: true),
                    seccionId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsEstudioSocioeconomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsEstudioSocioeconomico_SeccionesEstudioSocioeconomico_s~",
                        column: x => x.seccionId,
                        principalTable: "SeccionesEstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpcionItemEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    ItemEstudioSocioeconomicoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionItemEstudioSocioeconomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpcionItemEstudioSocioeconomico_ItemsEstudioSocioeconomico_~",
                        column: x => x.ItemEstudioSocioeconomicoId,
                        principalTable: "ItemsEstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EstudioSocioeconomicoId = table.Column<long>(nullable: false),
                    ItemEstudioSocioeconomicoId = table.Column<long>(nullable: false),
                    OpcionItemEstudioSocioeconomicoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionEstudioSocioeconomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluacionEstudioSocioeconomico_EstudioSocioeconomico_Estud~",
                        column: x => x.EstudioSocioeconomicoId,
                        principalTable: "EstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluacionEstudioSocioeconomico_ItemsEstudioSocioeconomico_~",
                        column: x => x.ItemEstudioSocioeconomicoId,
                        principalTable: "ItemsEstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluacionEstudioSocioeconomico_OpcionItemEstudioSocioecono~",
                        column: x => x.OpcionItemEstudioSocioeconomicoId,
                        principalTable: "OpcionItemEstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ItemsEstudioSocioeconomico",
                columns: new[] { "Id", "descripcion", "idSeccionEstudioSocioeconomico", "nombre", "seccionId" },
                values: new object[,]
                {
                    { 1L, null, 1L, "Paredes", null },
                    { 2L, null, 1L, "Techo", null },
                    { 3L, null, 1L, "Pisos", null },
                    { 4L, null, 1L, "No. de habitaciones", null },
                    { 5L, null, 1L, "Agua", null },
                    { 6L, null, 1L, "Luz eléctrica", null },
                    { 7L, null, 1L, "Servicio sanitario", null },
                    { 8L, null, 1L, "Letrina", null },
                    { 9L, null, 1L, "Otros", null },
                    { 10L, null, 1L, "La cocina está fuera del dormitorio", null },
                    { 11L, null, 1L, "Vivienda", null },
                    { 12L, null, 1L, "Pago mensual de vivienda", null }
                });

            migrationBuilder.InsertData(
                table: "SeccionesEstudioSocioeconomico",
                columns: new[] { "Id", "descripcion", "nombre" },
                values: new object[] { 1L, null, "Vivienda" });

            migrationBuilder.InsertData(
                table: "OpcionItemEstudioSocioeconomico",
                columns: new[] { "Id", "ItemEstudioSocioeconomicoId", "nombre" },
                values: new object[,]
                {
                    { 1L, 1L, "Block" },
                    { 2L, 1L, "Madera" },
                    { 3L, 1L, "Nylon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_EstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico",
                column: "EstudioSocioeconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_ItemEstudioSocioeconomicoId",
                table: "EvaluacionEstudioSocioeconomico",
                column: "ItemEstudioSocioeconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionEstudioSocioeconomico_OpcionItemEstudioSocioecono~",
                table: "EvaluacionEstudioSocioeconomico",
                column: "OpcionItemEstudioSocioeconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoFamiliar_EstudioSocioeconomicoId",
                table: "GrupoFamiliar",
                column: "EstudioSocioeconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsEstudioSocioeconomico_seccionId",
                table: "ItemsEstudioSocioeconomico",
                column: "seccionId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionItemEstudioSocioeconomico_ItemEstudioSocioeconomicoId",
                table: "OpcionItemEstudioSocioeconomico",
                column: "ItemEstudioSocioeconomicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluacionEstudioSocioeconomico");

            migrationBuilder.DropTable(
                name: "GrupoFamiliar");

            migrationBuilder.DropTable(
                name: "OpcionItemEstudioSocioeconomico");

            migrationBuilder.DropTable(
                name: "EstudioSocioeconomico");

            migrationBuilder.DropTable(
                name: "ItemsEstudioSocioeconomico");

            migrationBuilder.DropTable(
                name: "SeccionesEstudioSocioeconomico");
        }
    }
}
