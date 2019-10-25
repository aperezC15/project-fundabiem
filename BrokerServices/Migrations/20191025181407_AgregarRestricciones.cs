using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class AgregarRestricciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tipoDirecciones",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Telefonos",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "SeccionesAnamnesis",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "SeccionesAnamnesis",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "segundoNombre",
                table: "Personas",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "segundoApellido",
                table: "Personas",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "religion",
                table: "Personas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "primerNombre",
                table: "Personas",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "primerApellido",
                table: "Personas",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "grupoEtnico",
                table: "Personas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "escolaridad",
                table: "Personas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dpi",
                table: "Personas",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Paises",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Municipios",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "ItemsAnamnesis",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "ItemsAnamnesis",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "motivoDeConsulta",
                table: "HistoriasClinicas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "diagnosticoFinal",
                table: "HistoriasClinicas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "parentezco",
                table: "familiaresPacientes",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Direcciones",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Departamentos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Correos",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "diagnostico",
                table: "Anamnesis",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tipoDirecciones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Telefonos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "SeccionesAnamnesis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "SeccionesAnamnesis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "segundoNombre",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "segundoApellido",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "religion",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "primerNombre",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "primerApellido",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "grupoEtnico",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "escolaridad",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "dpi",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Paises",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Municipios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "ItemsAnamnesis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "ItemsAnamnesis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "motivoDeConsulta",
                table: "HistoriasClinicas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "diagnosticoFinal",
                table: "HistoriasClinicas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "parentezco",
                table: "familiaresPacientes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Direcciones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Departamentos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Correos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "diagnostico",
                table: "Anamnesis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);
        }
    }
}
