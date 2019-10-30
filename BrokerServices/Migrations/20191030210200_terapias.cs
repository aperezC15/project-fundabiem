using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class terapias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terapias",
                columns: table => new
                {
                    IdTerapia = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Encargado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapias", x => x.IdTerapia);
                });

            migrationBuilder.InsertData(
                table: "Terapias",
                columns: new[] { "IdTerapia", "Descripcion", "Encargado", "Nombre" },
                values: new object[,]
                {
                    { 1L, "fisioterapia", "16e7295d-662e-440e-9e55-bb0680f8e9a0", "FT" },
                    { 2L, "Terapia Ocupacional", "21859333-eefc-4a3b-914e-0884df0d2ca0", "TO" },
                    { 3L, "Terapia de Lenguaje", "7af9189d-e12f-4d9e-b4f0-44e4fdba0790", "TL" },
                    { 4L, "Terapia Social", "332f07fc-0e28-4e9c-866c-d8ced8eba9a6", "TS" },
                    { 5L, "Terapia Psicologica", "eb1794b8-42b4-4ede-bba2-2d7073671eea", "PSCI" },
                    { 6L, "Terapia Virtual", "79c300f9-46da-476f-830b-a1f74e02ad27", "IREX" },
                    { 7L, "MecanoTerapia", "6e3516cd-1688-45a7-b9ce-1e4e8cfe2c09", "MT" },
                    { 8L, "Cuarto de estimulación Sensorial", "e1f3b398-54a7-493a-adfa-11329a459e91", "CEMS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terapias");
        }
    }
}
