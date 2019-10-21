using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class DPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dpi",
                table: "Personas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dpi",
                table: "Personas");
        }
    }
}
