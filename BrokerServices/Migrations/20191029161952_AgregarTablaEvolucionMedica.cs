using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class AgregarTablaEvolucionMedica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvolucionesMedicas",
                columns: table => new
                {
                    idEvolucionMedica = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    diagnostico = table.Column<string>(maxLength: 5000, nullable: false),
                    fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolucionesMedicas", x => x.idEvolucionMedica);
                    table.ForeignKey(
                        name: "FK_EvolucionesMedicas_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvolucionesMedicas_idPaciente",
                table: "EvolucionesMedicas",
                column: "idPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvolucionesMedicas");
        }
    }
}
