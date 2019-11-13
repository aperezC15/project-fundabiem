using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class citas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_idPaciente",
                table: "Citas");

            migrationBuilder.CreateTable(
                name: "EvolucionTenica",
                columns: table => new
                {
                    idEvolucionTecnica = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    diagnostico = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolucionTenica", x => x.idEvolucionTecnica);
                    table.ForeignKey(
                        name: "FK_EvolucionTenica_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvolucionTenica_idPaciente",
                table: "EvolucionTenica",
                column: "idPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_idPaciente",
                table: "Citas",
                column: "idPaciente",
                principalTable: "Pacientes",
                principalColumn: "idPaciente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_idPaciente",
                table: "Citas");

            migrationBuilder.DropTable(
                name: "EvolucionTenica");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_idPaciente",
                table: "Citas",
                column: "idPaciente",
                principalTable: "Pacientes",
                principalColumn: "idPaciente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
