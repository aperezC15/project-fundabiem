using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class seedTipoDirecciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tipoDirecciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1L, "Dirección" },
                    { 2L, "Residencia Habitual" },
                    { 3L, "Domicilio" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tipoDirecciones",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tipoDirecciones",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tipoDirecciones",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
