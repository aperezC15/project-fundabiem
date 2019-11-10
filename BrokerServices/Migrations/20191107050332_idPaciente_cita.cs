using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class idPaciente_cita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_pacienteidPaciente",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_pacienteidPaciente",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "pacienteidPaciente",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "dPaciente",
                table: "Citas",
                newName: "idPaciente");

            migrationBuilder.CreateTable(
                name: "SeccionesEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeccionesEstudioSocioeconomico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsEstudioSocioeconomico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idSeccionEstudioSocioeconomico = table.Column<long>(nullable: false),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(maxLength: 255, nullable: true),
                    seccionId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsEstudioSocioeconomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsEstudioSocioeconomico_SeccionesEstudioSocioeconomico_s~",
                        column: x => x.seccionId,
                        principalTable: "SeccionesEstudioSocioeconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_idPaciente",
                table: "Citas",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsEstudioSocioeconomico_seccionId",
                table: "ItemsEstudioSocioeconomico",
                column: "seccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_idPaciente",
                table: "Citas",
                column: "idPaciente",
                principalTable: "Pacientes",
                principalColumn: "idPaciente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_idPaciente",
                table: "Citas");

            migrationBuilder.DropTable(
                name: "ItemsEstudioSocioeconomico");

            migrationBuilder.DropTable(
                name: "SeccionesEstudioSocioeconomico");

            migrationBuilder.DropIndex(
                name: "IX_Citas_idPaciente",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "idPaciente",
                table: "Citas",
                newName: "dPaciente");

            migrationBuilder.AddColumn<long>(
                name: "pacienteidPaciente",
                table: "Citas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citas_pacienteidPaciente",
                table: "Citas",
                column: "pacienteidPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_pacienteidPaciente",
                table: "Citas",
                column: "pacienteidPaciente",
                principalTable: "Pacientes",
                principalColumn: "idPaciente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
