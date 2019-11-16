using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class nuevaTerapia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Terapias",
                columns: new[] { "IdTerapia", "Descripcion", "Encargado", "Nombre" },
                values: new object[] { 9L, "Cuarto de estimulación Sensorial", "e1f3b398-54a7-493a-adfa-11329a459e91", "ET" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Terapias",
                keyColumn: "IdTerapia",
                keyValue: 9L);
        }
    }
}
