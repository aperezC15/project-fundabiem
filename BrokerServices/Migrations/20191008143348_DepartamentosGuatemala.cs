using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class DepartamentosGuatemala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "idDepartamento", "idPais", "nombre" },
                values: new object[,]
                {
                    { 1.0, 1.0, "Alta Verapaz" },
                    { 20.0, 1.0, "Totonicapán" },
                    { 19.0, 1.0, "Suchitepéquez" },
                    { 18.0, 1.0, "Sololá" },
                    { 17.0, 1.0, "Santa Rosa" },
                    { 16.0, 1.0, "San Marcos" },
                    { 15.0, 1.0, "Sacatepéquez" },
                    { 14.0, 1.0, "Retalhuleu" },
                    { 13.0, 1.0, "Quiché" },
                    { 12.0, 1.0, "Quetzaltenango" },
                    { 11.0, 1.0, "Petén" },
                    { 10.0, 1.0, "Jutiapa" },
                    { 9.0, 1.0, "Izabal" },
                    { 8.0, 1.0, "Huehuetenango" },
                    { 7.0, 1.0, "Guatemala" },
                    { 6.0, 1.0, "Escuintla" },
                    { 5.0, 1.0, "El Progreso" },
                    { 4.0, 1.0, "Chiquimula" },
                    { 3.0, 1.0, "Chimaltenango" },
                    { 2.0, 1.0, "Baja Verapaz" },
                    { 21.0, 1.0, "Zacapa" },
                    { 22.0, 1.0, "Jalapa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 1.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 2.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 3.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 4.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 5.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 6.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 7.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 8.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 9.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 10.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 11.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 12.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 13.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 14.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 15.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 16.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 17.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 18.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 19.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 20.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 21.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 22.0);
        }
    }
}
