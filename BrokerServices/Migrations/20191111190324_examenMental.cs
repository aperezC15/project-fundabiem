using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class examenMental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_examenMental_idHistoriaClinicaPsicologica",
                table: "examenMental");

            migrationBuilder.CreateIndex(
                name: "IX_examenMental_idHistoriaClinicaPsicologica",
                table: "examenMental",
                column: "idHistoriaClinicaPsicologica",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_examenMental_idHistoriaClinicaPsicologica",
                table: "examenMental");

            migrationBuilder.CreateIndex(
                name: "IX_examenMental_idHistoriaClinicaPsicologica",
                table: "examenMental",
                column: "idHistoriaClinicaPsicologica");
        }
    }
}
