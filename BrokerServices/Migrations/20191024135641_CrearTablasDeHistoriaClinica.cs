using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class CrearTablasDeHistoriaClinica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    idHistoriaClinica = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    fechaDeRegistro = table.Column<DateTime>(nullable: false),
                    motivoDeConsulta = table.Column<string>(nullable: true),
                    diagnosticoFinal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.idHistoriaClinica);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anamnesis",
                columns: table => new
                {
                    idAnamnesis = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idHistoriaClinica = table.Column<long>(nullable: false),
                    idItemAnamnesis = table.Column<long>(nullable: false),
                    diagnostico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anamnesis", x => x.idAnamnesis);
                    table.ForeignKey(
                        name: "FK_Anamnesis_HistoriasClinicas_idHistoriaClinica",
                        column: x => x.idHistoriaClinica,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "idHistoriaClinica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anamnesis_ItemsAnamnesis_idItemAnamnesis",
                        column: x => x.idItemAnamnesis,
                        principalTable: "ItemsAnamnesis",
                        principalColumn: "idItemAnamnesis",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tratamientos",
                columns: table => new
                {
                    idTratamiento = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idHistoriaClinica = table.Column<long>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamientos", x => x.idTratamiento);
                    table.ForeignKey(
                        name: "FK_Tratamientos_HistoriasClinicas_idHistoriaClinica",
                        column: x => x.idHistoriaClinica,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "idHistoriaClinica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesTratamientos",
                columns: table => new
                {
                    idDetalleTratamiento = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idTratamiento = table.Column<long>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    duracion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesTratamientos", x => x.idDetalleTratamiento);
                    table.ForeignKey(
                        name: "FK_DetallesTratamientos_Tratamientos_idTratamiento",
                        column: x => x.idTratamiento,
                        principalTable: "Tratamientos",
                        principalColumn: "idTratamiento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anamnesis_idHistoriaClinica",
                table: "Anamnesis",
                column: "idHistoriaClinica");

            migrationBuilder.CreateIndex(
                name: "IX_Anamnesis_idItemAnamnesis",
                table: "Anamnesis",
                column: "idItemAnamnesis");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTratamientos_idTratamiento",
                table: "DetallesTratamientos",
                column: "idTratamiento");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_idPaciente",
                table: "HistoriasClinicas",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_idHistoriaClinica",
                table: "Tratamientos",
                column: "idHistoriaClinica",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anamnesis");

            migrationBuilder.DropTable(
                name: "DetallesTratamientos");

            migrationBuilder.DropTable(
                name: "Tratamientos");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");
        }
    }
}
