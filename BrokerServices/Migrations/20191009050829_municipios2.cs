using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class municipios2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 326.0,
                column: "idDepartamento",
                value: 22.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 326.0,
                column: "idDepartamento",
                value: 223.0);
        }
    }
}
