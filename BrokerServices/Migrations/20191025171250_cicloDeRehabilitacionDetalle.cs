using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class cicloDeRehabilitacionDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleCicloDeRehabilitaciones",
                columns: table => new
                {
                    idDetalle = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idObjetivo = table.Column<long>(nullable: false),
                    idcicloRehabilitacion = table.Column<long>(nullable: false),
                    intervencion = table.Column<bool>(nullable: false),
                    TF = table.Column<bool>(nullable: false),
                    TO = table.Column<bool>(nullable: false),
                    TL = table.Column<bool>(nullable: false),
                    PS = table.Column<bool>(nullable: false),
                    TS = table.Column<bool>(nullable: false),
                    EE = table.Column<bool>(nullable: false),
                    valoracionInicial = table.Column<bool>(nullable: false),
                    valoracionObjetivo = table.Column<bool>(nullable: false),
                    valoracionFinal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCicloDeRehabilitaciones", x => x.idDetalle);
                    table.ForeignKey(
                        name: "FK_DetalleCicloDeRehabilitaciones_ObjetivosDeIntervenciones_id~",
                        column: x => x.idObjetivo,
                        principalTable: "ObjetivosDeIntervenciones",
                        principalColumn: "idObjetivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCicloDeRehabilitaciones_CicloDeRehabilitaciones_idci~",
                        column: x => x.idcicloRehabilitacion,
                        principalTable: "CicloDeRehabilitaciones",
                        principalColumn: "idcicloRehabilitacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCicloDeRehabilitaciones_idObjetivo",
                table: "DetalleCicloDeRehabilitaciones",
                column: "idObjetivo");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCicloDeRehabilitaciones_idcicloRehabilitacion",
                table: "DetalleCicloDeRehabilitaciones",
                column: "idcicloRehabilitacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCicloDeRehabilitaciones");
        }
    }
}
