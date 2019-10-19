using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class InsertarDatosDeSeccionesEItemsAnamnesis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SeccionesAnamnesis",
                columns: new[] { "idSeccionAnamnesis", "descripcion", "nombre" },
                values: new object[,]
                {
                    { 1L, "", "Antecedentes familiares" },
                    { 2L, "", "Antecedentes médicos" },
                    { 3L, "", "Periodo neonatal" },
                    { 4L, "", "Desarrollo" }
                });

            migrationBuilder.InsertData(
                table: "ItemsAnamnesis",
                columns: new[] { "idItemAnamnesis", "descripcion", "idSeccionAnamnesis", "nombre" },
                values: new object[,]
                {
                    { 1L, "", 1L, "Hijos vivos" },
                    { 25L, "", 4L, "Vacunaciones" },
                    { 24L, "", 4L, "Edad en que empezó a hablar" },
                    { 23L, "", 4L, "Edad en que empezó a caminar solo" },
                    { 22L, "", 4L, "Edad en que empezó a andar" },
                    { 21L, "", 4L, "Edad en que empezó a pararse" },
                    { 20L, "", 4L, "Edad en que empezó a sentarse solo" },
                    { 19L, "", 4L, "Edad en que empezó a rodar al lado" },
                    { 18L, "", 4L, "Edad en que empezó a sonreir" },
                    { 17L, "", 4L, "Edad en que empezó a sostener la cabeza" },
                    { 16L, "", 3L, "Apgar" },
                    { 15L, "", 3L, "Estado al nacer" },
                    { 26L, "", 4L, "Enfermedades" },
                    { 14L, "", 2L, "Cesarea" },
                    { 12L, "", 2L, "Sufrimiento fetal" },
                    { 11L, "", 2L, "Duración del trabajo de parto" },
                    { 10L, "", 2L, "Alcohol" },
                    { 9L, "", 2L, "Tabaquismo" },
                    { 8L, "", 2L, "Medicamentos durante el embarazo" },
                    { 7L, "", 2L, "Problemas gestacionales" },
                    { 6L, "", 2L, "Duración del embarazo" },
                    { 5L, "", 2L, "Peso al nacer" },
                    { 4L, "", 1L, "Otros" },
                    { 3L, "", 1L, "Padres" },
                    { 2L, "", 1L, "Hijos muertos y sus causas" },
                    { 13L, "", 2L, "Vaginal" },
                    { 27L, "", 4L, "Antecedentes Qx" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ItemsAnamnesis",
                keyColumn: "idItemAnamnesis",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "SeccionesAnamnesis",
                keyColumn: "idSeccionAnamnesis",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SeccionesAnamnesis",
                keyColumn: "idSeccionAnamnesis",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SeccionesAnamnesis",
                keyColumn: "idSeccionAnamnesis",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SeccionesAnamnesis",
                keyColumn: "idSeccionAnamnesis",
                keyValue: 4L);
        }
    }
}
