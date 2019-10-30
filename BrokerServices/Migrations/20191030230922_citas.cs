using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class citas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    IdCita = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dPaciente = table.Column<long>(nullable: false),
                    IdTerapia = table.Column<long>(nullable: false),
                    idEstado = table.Column<long>(nullable: false),
                    edad = table.Column<int>(nullable: false),
                    NoOrden = table.Column<string>(nullable: true),
                    fechaCita = table.Column<DateTime>(nullable: false),
                    fechaAsignacion = table.Column<DateTime>(nullable: false),
                    AsignadoPor = table.Column<string>(nullable: true),
                    pacienteidPaciente = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.IdCita);
                    table.ForeignKey(
                        name: "FK_Citas_Terapias_IdTerapia",
                        column: x => x.IdTerapia,
                        principalTable: "Terapias",
                        principalColumn: "IdTerapia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_EstadoCitas_idEstado",
                        column: x => x.idEstado,
                        principalTable: "EstadoCitas",
                        principalColumn: "idEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_pacienteidPaciente",
                        column: x => x.pacienteidPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdTerapia",
                table: "Citas",
                column: "IdTerapia");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_idEstado",
                table: "Citas",
                column: "idEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_pacienteidPaciente",
                table: "Citas",
                column: "pacienteidPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");
        }
    }
}
