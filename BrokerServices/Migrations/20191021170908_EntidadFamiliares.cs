using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class EntidadFamiliares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "parentezco",
                table: "PersonasEncargadas");

            migrationBuilder.CreateTable(
                name: "familiaresPacientes",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idPersona = table.Column<long>(nullable: false),
                    idPaciente = table.Column<long>(nullable: false),
                    parentezco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_familiaresPacientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_familiaresPacientes_Personas_idPersona",
                        column: x => x.idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_familiaresPacientes_idPersona",
                table: "familiaresPacientes",
                column: "idPersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "familiaresPacientes");

            migrationBuilder.AddColumn<string>(
                name: "parentezco",
                table: "PersonasEncargadas",
                nullable: true);
        }
    }
}
