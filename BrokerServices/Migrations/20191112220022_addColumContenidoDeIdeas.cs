using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class addColumContenidoDeIdeas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contenidoDeIdeas",
                table: "examenMental",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contenidoDeIdeas",
                table: "examenMental");
        }
    }
}
