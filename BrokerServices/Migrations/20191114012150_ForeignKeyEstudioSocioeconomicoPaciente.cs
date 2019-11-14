using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class ForeignKeyEstudioSocioeconomicoPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EstudioSocioeconomico_idPaciente",
                table: "EstudioSocioeconomico",
                column: "idPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudioSocioeconomico_Pacientes_idPaciente",
                table: "EstudioSocioeconomico",
                column: "idPaciente",
                principalTable: "Pacientes",
                principalColumn: "idPaciente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudioSocioeconomico_Pacientes_idPaciente",
                table: "EstudioSocioeconomico");

            migrationBuilder.DropIndex(
                name: "IX_EstudioSocioeconomico_idPaciente",
                table: "EstudioSocioeconomico");
        }
    }
}
