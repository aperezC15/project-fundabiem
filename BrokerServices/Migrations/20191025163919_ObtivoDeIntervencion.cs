using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class ObtivoDeIntervencion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ObjetivosDeIntervenciones",
                columns: table => new
                {
                    idObjetivo = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetivosDeIntervenciones", x => x.idObjetivo);
                });

            migrationBuilder.InsertData(
                table: "ObjetivosDeIntervenciones",
                columns: new[] { "idObjetivo", "descripcion", "nombre" },
                values: new object[,]
                {
                    { 1L, "Describe funciones y estructuras corporales del paciente", "Funciones y Estructuras Corporales" },
                    { 2L, "Describe Actividad y Participacion del paciente", "Actividad y Participacion" },
                    { 3L, "Describe Factores Ambientales del paciente", "Factores Ambientales" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObjetivosDeIntervenciones");
        }
    }
}
