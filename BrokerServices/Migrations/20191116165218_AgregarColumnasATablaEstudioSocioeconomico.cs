using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class AgregarColumnasATablaEstudioSocioeconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "entrevistadorTS",
                table: "EstudioSocioeconomico",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "evaluador",
                table: "EstudioSocioeconomico",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "entrevistadorTS",
                table: "EstudioSocioeconomico");

            migrationBuilder.DropColumn(
                name: "evaluador",
                table: "EstudioSocioeconomico");
        }
    }
}
