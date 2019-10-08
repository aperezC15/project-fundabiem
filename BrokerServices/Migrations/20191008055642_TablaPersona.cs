using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class TablaPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    idPais = table.Column<double>(nullable: false),
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
                    idDepartamento = table.Column<double>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    idPais = table.Column<double>(nullable: false)
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
                    idMunicipio = table.Column<double>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    idDepartamento = table.Column<double>(nullable: false)
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
                    idDireccion = table.Column<double>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    idMunicipio = table.Column<double>(nullable: false)
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
                    idPersona = table.Column<double>(nullable: false),
                    primerNombre = table.Column<string>(nullable: true),
                    segundoNombre = table.Column<string>(nullable: true),
                    primerApellido = table.Column<string>(nullable: true),
                    segundoApellido = table.Column<string>(nullable: true),
                    sexo = table.Column<bool>(nullable: false),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    grupoEtnico = table.Column<string>(nullable: true),
                    escolaridad = table.Column<string>(nullable: true),
                    religion = table.Column<string>(nullable: true),
                    idDomicilio = table.Column<double>(nullable: false),
                    idResidencia = table.Column<double>(nullable: false)
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
                    idCorreo = table.Column<double>(nullable: false),
                    correo = table.Column<string>(nullable: true),
                    fechaRegistro = table.Column<DateTime>(nullable: false),
                    estaHabilitado = table.Column<bool>(nullable: false),
                    personaidPersona = table.Column<double>(nullable: true)
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
                name: "Telefonos",
                columns: table => new
                {
                    idTelefono = table.Column<double>(nullable: false),
                    idPersona = table.Column<double>(nullable: false),
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
                name: "IX_Personas_idDomicilio",
                table: "Personas",
                column: "idDomicilio");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_idResidencia",
                table: "Personas",
                column: "idResidencia");

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
                name: "Telefonos");

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
