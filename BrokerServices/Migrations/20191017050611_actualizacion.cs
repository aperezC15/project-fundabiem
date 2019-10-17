using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    idPais = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.idPais);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    idDepartamento = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(nullable: true),
                    idPais = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.idDepartamento);
                    table.ForeignKey(
                        name: "FK_Departamentos_Paises_idPais",
                        column: x => x.idPais,
                        principalTable: "Paises",
                        principalColumn: "idPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    idMunicipio = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(nullable: true),
                    idDepartamento = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.idMunicipio);
                    table.ForeignKey(
                        name: "FK_Municipios_Departamentos_idDepartamento",
                        column: x => x.idDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "idDepartamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    idDireccion = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descripcion = table.Column<string>(nullable: true),
                    idMunicipio = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.idDireccion);
                    table.ForeignKey(
                        name: "FK_Direcciones_Municipios_idMunicipio",
                        column: x => x.idMunicipio,
                        principalTable: "Municipios",
                        principalColumn: "idMunicipio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    idPersona = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    primerNombre = table.Column<string>(nullable: true),
                    segundoNombre = table.Column<string>(nullable: true),
                    primerApellido = table.Column<string>(nullable: true),
                    segundoApellido = table.Column<string>(nullable: true),
                    sexo = table.Column<bool>(nullable: false),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    grupoEtnico = table.Column<string>(nullable: true),
                    escolaridad = table.Column<string>(nullable: true),
                    religion = table.Column<string>(nullable: true),
                    idDomicilio = table.Column<long>(nullable: false),
                    idResidencia = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.idPersona);
                    table.ForeignKey(
                        name: "FK_Personas_Direcciones_idDomicilio",
                        column: x => x.idDomicilio,
                        principalTable: "Direcciones",
                        principalColumn: "idDireccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Direcciones_idResidencia",
                        column: x => x.idResidencia,
                        principalTable: "Direcciones",
                        principalColumn: "idDireccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Correos",
                columns: table => new
                {
                    idCorreo = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    correo = table.Column<string>(nullable: true),
                    fechaRegistro = table.Column<DateTime>(nullable: false),
                    estaHabilitado = table.Column<bool>(nullable: false),
                    personaidPersona = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correos", x => x.idCorreo);
                    table.ForeignKey(
                        name: "FK_Correos_Personas_personaidPersona",
                        column: x => x.personaidPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    idPaciente = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    historialClinico = table.Column<long>(nullable: false),
                    idPersona = table.Column<long>(nullable: false),
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
                name: "Telefonos",
                columns: table => new
                {
                    idTelefono = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPersona = table.Column<long>(nullable: false),
                    telefono = table.Column<string>(nullable: true),
                    fechaRegistro = table.Column<DateTime>(nullable: false),
                    estaHabilitado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.idTelefono);
                    table.ForeignKey(
                        name: "FK_Telefonos_Personas_idPersona",
                        column: x => x.idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonasEncargadas",
                columns: table => new
                {
                    idPersonaEncargada = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    idPersona = table.Column<long>(nullable: false),
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
                    idRegistroMedico = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
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
                    idRegistroMedicoDiagnostico = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idRegistroMedico = table.Column<long>(nullable: false),
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

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "idPais", "nombre" },
                values: new object[] { 1L, "Guatemala" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "idDepartamento", "idPais", "nombre" },
                values: new object[,]
                {
                    { 1L, 1L, "Alta Verapaz" },
                    { 20L, 1L, "Totonicapán" },
                    { 19L, 1L, "Suchitepéquez" },
                    { 18L, 1L, "Sololá" },
                    { 17L, 1L, "Santa Rosa" },
                    { 16L, 1L, "San Marcos" },
                    { 15L, 1L, "Sacatepéquez" },
                    { 14L, 1L, "Retalhuleu" },
                    { 13L, 1L, "Quiché" },
                    { 12L, 1L, "Quetzaltenango" },
                    { 11L, 1L, "Petén" },
                    { 10L, 1L, "Jutiapa" },
                    { 9L, 1L, "Izabal" },
                    { 8L, 1L, "Huehuetenango" },
                    { 7L, 1L, "Guatemala" },
                    { 6L, 1L, "Escuintla" },
                    { 5L, 1L, "El Progreso" },
                    { 4L, 1L, "Chiquimula" },
                    { 3L, 1L, "Chimaltenango" },
                    { 2L, 1L, "Baja Verapaz" },
                    { 21L, 1L, "Zacapa" },
                    { 22L, 1L, "Jalapa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Correos_personaidPersona",
                table: "Correos",
                column: "personaidPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_idPais",
                table: "Departamentos",
                column: "idPais");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_idMunicipio",
                table: "Direcciones",
                column: "idMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_idDepartamento",
                table: "Municipios",
                column: "idDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_idPersona",
                table: "Pacientes",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_idDomicilio",
                table: "Personas",
                column: "idDomicilio");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_idResidencia",
                table: "Personas",
                column: "idResidencia");

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

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_idPersona",
                table: "Telefonos",
                column: "idPersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Correos");

            migrationBuilder.DropTable(
                name: "PersonasEncargadas");

            migrationBuilder.DropTable(
                name: "RegistrosMedicosDiagnostico");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "RegistrosMedicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
