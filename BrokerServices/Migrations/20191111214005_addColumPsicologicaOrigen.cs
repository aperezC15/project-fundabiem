using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class addColumPsicologicaOrigen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "origenProcedencia",
                table: "HistoriaClinicaPsicologicas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "origenProcedencia",
                table: "HistoriaClinicaPsicologicas");
        }
    }
}
