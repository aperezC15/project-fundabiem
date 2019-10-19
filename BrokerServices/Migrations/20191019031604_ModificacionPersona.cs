using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class ModificacionPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Direcciones_idDomicilio",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Direcciones_idResidencia",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_idDomicilio",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_idResidencia",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "idDomicilio",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "idResidencia",
                table: "Personas");

            migrationBuilder.AddColumn<long>(
                name: "idPersona",
                table: "Direcciones",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "idTipoDireccion",
                table: "Direcciones",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_idPersona",
                table: "Direcciones",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_idTipoDireccion",
                table: "Direcciones",
                column: "idTipoDireccion");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Personas_idPersona",
                table: "Direcciones",
                column: "idPersona",
                principalTable: "Personas",
                principalColumn: "idPersona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Direcciones_idTipoDireccion",
                table: "Direcciones",
                column: "idTipoDireccion",
                principalTable: "Direcciones",
                principalColumn: "idDireccion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Personas_idPersona",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Direcciones_idTipoDireccion",
                table: "Direcciones");

            migrationBuilder.DropIndex(
                name: "IX_Direcciones_idPersona",
                table: "Direcciones");

            migrationBuilder.DropIndex(
                name: "IX_Direcciones_idTipoDireccion",
                table: "Direcciones");

            migrationBuilder.DropColumn(
                name: "idPersona",
                table: "Direcciones");

            migrationBuilder.DropColumn(
                name: "idTipoDireccion",
                table: "Direcciones");

            migrationBuilder.AddColumn<long>(
                name: "idDomicilio",
                table: "Personas",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "idResidencia",
                table: "Personas",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_idDomicilio",
                table: "Personas",
                column: "idDomicilio");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_idResidencia",
                table: "Personas",
                column: "idResidencia");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Direcciones_idDomicilio",
                table: "Personas",
                column: "idDomicilio",
                principalTable: "Direcciones",
                principalColumn: "idDireccion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Direcciones_idResidencia",
                table: "Personas",
                column: "idResidencia",
                principalTable: "Direcciones",
                principalColumn: "idDireccion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
