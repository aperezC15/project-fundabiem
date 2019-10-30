using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class estadoDeCitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoCitas",
                columns: table => new
                {
                    idEstado = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCitas", x => x.idEstado);
                });

            migrationBuilder.InsertData(
                table: "EstadoCitas",
                columns: new[] { "idEstado", "descripcion", "nombre" },
                values: new object[,]
                {
                    { 1L, "Para indicar que el paciente asistio a su cita", "Asistencia" },
                    { 2L, "Para indicar que el paciente no asistio a su cita", "Inasistencia" },
                    { 3L, "Para marcar que el paciente solicito Permiso a no asistir a su cita", "Permiso" },
                    { 4L, "Para indicar que la cita fue cancelada", "Cancelada" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoCitas");
        }
    }
}
