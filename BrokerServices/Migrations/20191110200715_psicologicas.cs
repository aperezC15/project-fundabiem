using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class psicologicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriaClinicaPsicologicas",
                columns: table => new
                {
                    idHistoriaclinicaPsicologica = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    motivoDeConsulta = table.Column<string>(nullable: true),
                    perfilSocial = table.Column<string>(nullable: true),
                    personalidad = table.Column<string>(nullable: true),
                    datosRelevantesFamiliaPaciente = table.Column<string>(nullable: true),
                    diagnostico = table.Column<string>(nullable: true),
                    planOrientacionPsicologica = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinicaPsicologicas", x => x.idHistoriaclinicaPsicologica);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicaPsicologicas_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AntecedentesPacientes",
                columns: table => new
                {
                    idAntecedente = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idHistoriaClinicaPsicologica = table.Column<long>(nullable: false),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecedentesPacientes", x => x.idAntecedente);
                    table.ForeignKey(
                        name: "FK_AntecedentesPacientes_HistoriaClinicaPsicologicas_idHistori~",
                        column: x => x.idHistoriaClinicaPsicologica,
                        principalTable: "HistoriaClinicaPsicologicas",
                        principalColumn: "idHistoriaclinicaPsicologica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "examenMental",
                columns: table => new
                {
                    idExamenMental = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idHistoriaClinicaPsicologica = table.Column<long>(nullable: false),
                    aparecienciaGeneral = table.Column<string>(nullable: true),
                    estadoConciencia = table.Column<string>(nullable: true),
                    estadoAnimo = table.Column<string>(nullable: true),
                    activiadMotora = table.Column<string>(nullable: true),
                    asociacionIdeasYLenguaje = table.Column<string>(nullable: true),
                    sensorium = table.Column<string>(nullable: true),
                    memoria = table.Column<string>(nullable: true),
                    pensamiento = table.Column<string>(nullable: true),
                    resultadoExamen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examenMental", x => x.idExamenMental);
                    table.ForeignKey(
                        name: "FK_examenMental_HistoriaClinicaPsicologicas_idHistoriaClinicaP~",
                        column: x => x.idHistoriaClinicaPsicologica,
                        principalTable: "HistoriaClinicaPsicologicas",
                        principalColumn: "idHistoriaclinicaPsicologica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AntecedentesPacientes_idHistoriaClinicaPsicologica",
                table: "AntecedentesPacientes",
                column: "idHistoriaClinicaPsicologica");

            migrationBuilder.CreateIndex(
                name: "IX_examenMental_idHistoriaClinicaPsicologica",
                table: "examenMental",
                column: "idHistoriaClinicaPsicologica");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicaPsicologicas_idPaciente",
                table: "HistoriaClinicaPsicologicas",
                column: "idPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AntecedentesPacientes");

            migrationBuilder.DropTable(
                name: "examenMental");

            migrationBuilder.DropTable(
                name: "HistoriaClinicaPsicologicas");
        }
    }
}
