using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class nuevoEstadoCita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EstadoCitas",
                columns: new[] { "idEstado", "descripcion", "nombre" },
                values: new object[] { 5L, "Para indicar que la cita esta activa", "Activa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EstadoCitas",
                keyColumn: "idEstado",
                keyValue: 5L);
        }
    }
}
