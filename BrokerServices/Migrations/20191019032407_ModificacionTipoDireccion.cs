using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class ModificacionTipoDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Direcciones_idTipoDireccion",
                table: "Direcciones");

            migrationBuilder.CreateTable(
                name: "tipoDirecciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDirecciones", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_tipoDirecciones_idTipoDireccion",
                table: "Direcciones",
                column: "idTipoDireccion",
                principalTable: "tipoDirecciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_tipoDirecciones_idTipoDireccion",
                table: "Direcciones");

            migrationBuilder.DropTable(
                name: "tipoDirecciones");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Direcciones_idTipoDireccion",
                table: "Direcciones",
                column: "idTipoDireccion",
                principalTable: "Direcciones",
                principalColumn: "idDireccion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
