using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class AgregarTablaRegistrosMedicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    idPaciente = table.Column<double>(nullable: false),
                    historialClinico = table.Column<double>(nullable: false),
                    idPersona = table.Column<double>(nullable: false),
                    estaActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.idPaciente);
                    table.ForeignKey(
                        name: "FK_Pacientes_Personas_idPersona",
                        column: x => x.idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonasEncargadas",
                columns: table => new
                {
                    idPersonaEncargada = table.Column<double>(nullable: false),
                    idPaciente = table.Column<double>(nullable: false),
                    idPersona = table.Column<double>(nullable: false),
                    parentezco = table.Column<string>(nullable: true),
                    estaActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasEncargadas", x => x.idPersonaEncargada);
                    table.ForeignKey(
                        name: "FK_PersonasEncargadas_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonasEncargadas_Personas_idPersona",
                        column: x => x.idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosMedicos",
                columns: table => new
                {
                    idRegistroMedico = table.Column<double>(nullable: false),
                    idPaciente = table.Column<double>(nullable: false),
                    fechaAdmision = table.Column<DateTime>(nullable: false),
                    estaFirmado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosMedicos", x => x.idRegistroMedico);
                    table.ForeignKey(
                        name: "FK_RegistrosMedicos_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosMedicosDiagnostico",
                columns: table => new
                {
                    idRegistroMedicoDiagnostico = table.Column<double>(nullable: false),
                    idRegistroMedico = table.Column<double>(nullable: false),
                    diagnosticoFinal = table.Column<string>(nullable: true),
                    recomendaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosMedicosDiagnostico", x => x.idRegistroMedicoDiagnostico);
                    table.ForeignKey(
                        name: "FK_RegistrosMedicosDiagnostico_RegistrosMedicos_idRegistroMedi~",
                        column: x => x.idRegistroMedico,
                        principalTable: "RegistrosMedicos",
                        principalColumn: "idRegistroMedico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_idPersona",
                table: "Pacientes",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_PersonasEncargadas_idPaciente",
                table: "PersonasEncargadas",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_PersonasEncargadas_idPersona",
                table: "PersonasEncargadas",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosMedicos_idPaciente",
                table: "RegistrosMedicos",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosMedicosDiagnostico_idRegistroMedico",
                table: "RegistrosMedicosDiagnostico",
                column: "idRegistroMedico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasEncargadas");

            migrationBuilder.DropTable(
                name: "RegistrosMedicosDiagnostico");

            migrationBuilder.DropTable(
                name: "RegistrosMedicos");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
