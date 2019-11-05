using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class pruebaRg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RegistrosMedicosDiagnostico_idRegistroMedico",
                table: "RegistrosMedicosDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosMedicosDiagnostico_idRegistroMedico",
                table: "RegistrosMedicosDiagnostico",
                column: "idRegistroMedico",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RegistrosMedicosDiagnostico_idRegistroMedico",
                table: "RegistrosMedicosDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosMedicosDiagnostico_idRegistroMedico",
                table: "RegistrosMedicosDiagnostico",
                column: "idRegistroMedico");
        }
    }
}
