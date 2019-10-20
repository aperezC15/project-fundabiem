using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class AgregarTablaSeccionEItemAnamnesis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeccionesAnamnesis",
                columns: table => new
                {
                    idSeccionAnamnesis = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeccionesAnamnesis", x => x.idSeccionAnamnesis);
                });

            migrationBuilder.CreateTable(
                name: "ItemsAnamnesis",
                columns: table => new
                {
                    idItemAnamnesis = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idSeccionAnamnesis = table.Column<long>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsAnamnesis", x => x.idItemAnamnesis);
                    table.ForeignKey(
                        name: "FK_ItemsAnamnesis_SeccionesAnamnesis_idSeccionAnamnesis",
                        column: x => x.idSeccionAnamnesis,
                        principalTable: "SeccionesAnamnesis",
                        principalColumn: "idSeccionAnamnesis",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsAnamnesis_idSeccionAnamnesis",
                table: "ItemsAnamnesis",
                column: "idSeccionAnamnesis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsAnamnesis");

            migrationBuilder.DropTable(
                name: "SeccionesAnamnesis");
        }
    }
}
