using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class cicloDeRehabilitacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CicloDeRehabilitaciones",
                columns: table => new
                {
                    idcicloRehabilitacion = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPaciente = table.Column<long>(nullable: false),
                    dignostico = table.Column<string>(nullable: true),
                    origen = table.Column<string>(nullable: true),
                    cie_10 = table.Column<string>(nullable: true),
                    otros = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    funcionEstrucCorporales = table.Column<string>(nullable: true),
                    actividad = table.Column<string>(nullable: true),
                    participacion = table.Column<string>(nullable: true),
                    factoresAmbientales = table.Column<string>(nullable: true),
                    factoresPersonales = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CicloDeRehabilitaciones", x => x.idcicloRehabilitacion);
                    table.ForeignKey(
                        name: "FK_CicloDeRehabilitaciones_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CicloDeRehabilitaciones_idPaciente",
                table: "CicloDeRehabilitaciones",
                column: "idPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CicloDeRehabilitaciones");
        }
    }
}
