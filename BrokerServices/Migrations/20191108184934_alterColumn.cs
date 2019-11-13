using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class alterColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idEvolucionMedica",
                table: "EvolucionTenica",
                newName: "idEvolucionTecnica");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idEvolucionTecnica",
                table: "EvolucionTenica",
                newName: "idEvolucionMedica");
        }
    }
}
