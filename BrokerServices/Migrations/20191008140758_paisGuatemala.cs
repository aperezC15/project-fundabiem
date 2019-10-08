using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class paisGuatemala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "idPais", "nombre" },
                values: new object[] { 1.0, "Guatemala" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "idPais",
                keyValue: 1.0);
        }
    }
}
