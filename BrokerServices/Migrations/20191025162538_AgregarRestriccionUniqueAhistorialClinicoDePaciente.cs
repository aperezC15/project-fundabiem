using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class AgregarRestriccionUniqueAhistorialClinicoDePaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Pacientes_historialClinico",
                table: "Pacientes",
                column: "historialClinico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Pacientes_historialClinico",
                table: "Pacientes");
        }
    }
}
