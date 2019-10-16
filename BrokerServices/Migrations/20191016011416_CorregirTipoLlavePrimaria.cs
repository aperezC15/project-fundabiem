using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrokerServices.Migrations
{
    public partial class CorregirTipoLlavePrimaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 1.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 2.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 3.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 4.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 5.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 6.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 7.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 8.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 9.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 10.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 11.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 12.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 13.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 14.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 15.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 16.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 17.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 18.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 19.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 20.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 21.0);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 22.0);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "idPais",
                keyValue: 1.0);

            migrationBuilder.AlterColumn<long>(
                name: "idPersona",
                table: "Telefonos",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idTelefono",
                table: "Telefonos",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idRegistroMedico",
                table: "RegistrosMedicosDiagnostico",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idRegistroMedicoDiagnostico",
                table: "RegistrosMedicosDiagnostico",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idPaciente",
                table: "RegistrosMedicos",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idRegistroMedico",
                table: "RegistrosMedicos",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idPersona",
                table: "PersonasEncargadas",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idPaciente",
                table: "PersonasEncargadas",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idPersonaEncargada",
                table: "PersonasEncargadas",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idResidencia",
                table: "Personas",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idDomicilio",
                table: "Personas",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idPersona",
                table: "Personas",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idPais",
                table: "Paises",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idPersona",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "historialClinico",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idPaciente",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idDepartamento",
                table: "Municipios",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idMunicipio",
                table: "Municipios",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idMunicipio",
                table: "Direcciones",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idDireccion",
                table: "Direcciones",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "idPais",
                table: "Departamentos",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "idDepartamento",
                table: "Departamentos",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "personaidPersona",
                table: "Correos",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "idCorreo",
                table: "Correos",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "idPais", "nombre" },
                values: new object[] { 1L, "Guatemala" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "idDepartamento", "idPais", "nombre" },
                values: new object[,]
                {
                    { 1L, 1L, "Alta Verapaz" },
                    { 20L, 1L, "Totonicapán" },
                    { 19L, 1L, "Suchitepéquez" },
                    { 18L, 1L, "Sololá" },
                    { 17L, 1L, "Santa Rosa" },
                    { 16L, 1L, "San Marcos" },
                    { 15L, 1L, "Sacatepéquez" },
                    { 14L, 1L, "Retalhuleu" },
                    { 13L, 1L, "Quiché" },
                    { 12L, 1L, "Quetzaltenango" },
                    { 11L, 1L, "Petén" },
                    { 10L, 1L, "Jutiapa" },
                    { 9L, 1L, "Izabal" },
                    { 8L, 1L, "Huehuetenango" },
                    { 7L, 1L, "Guatemala" },
                    { 6L, 1L, "Escuintla" },
                    { 5L, 1L, "El Progreso" },
                    { 4L, 1L, "Chiquimula" },
                    { 3L, 1L, "Chimaltenango" },
                    { 2L, 1L, "Baja Verapaz" },
                    { 21L, 1L, "Zacapa" },
                    { 22L, 1L, "Jalapa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "idDepartamento",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "idPais",
                keyValue: 1L);

            migrationBuilder.AlterColumn<double>(
                name: "idPersona",
                table: "Telefonos",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idTelefono",
                table: "Telefonos",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idRegistroMedico",
                table: "RegistrosMedicosDiagnostico",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idRegistroMedicoDiagnostico",
                table: "RegistrosMedicosDiagnostico",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idPaciente",
                table: "RegistrosMedicos",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idRegistroMedico",
                table: "RegistrosMedicos",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idPersona",
                table: "PersonasEncargadas",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idPaciente",
                table: "PersonasEncargadas",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idPersonaEncargada",
                table: "PersonasEncargadas",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idResidencia",
                table: "Personas",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idDomicilio",
                table: "Personas",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idPersona",
                table: "Personas",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idPais",
                table: "Paises",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idPersona",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "historialClinico",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idPaciente",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idDepartamento",
                table: "Municipios",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idMunicipio",
                table: "Municipios",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idMunicipio",
                table: "Direcciones",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idDireccion",
                table: "Direcciones",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "idPais",
                table: "Departamentos",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "idDepartamento",
                table: "Departamentos",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<double>(
                name: "personaidPersona",
                table: "Correos",
                nullable: true,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "idCorreo",
                table: "Correos",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "idPais", "nombre" },
                values: new object[] { 1.0, "Guatemala" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "idDepartamento", "idPais", "nombre" },
                values: new object[,]
                {
                    { 1, 1, "Alta Verapaz" },
                    { 20, 1, "Totonicapán" },
                    { 19, 1, "Suchitepéquez" },
                    { 18, 1, "Sololá" },
                    { 17, 1, "Santa Rosa" },
                    { 16, 1, "San Marcos" },
                    { 15, 1, "Sacatepéquez" },
                    { 14, 1, "Retalhuleu" },
                    { 13, 1, "Quiché" },
                    { 12, 1, "Quetzaltenango" },
                    { 11, 1, "Petén" },
                    { 10, 1, "Jutiapa" },
                    { 9, 1, "Izabal" },
                    { 8, 1, "Huehuetenango" },
                    { 7, 1, "Guatemala" },
                    { 6, 1, "Escuintla" },
                    { 5, 1, "El Progreso" },
                    { 4, 1, "Chiquimula" },
                    { 3, 1, "Chimaltenango" },
                    { 2, 1, "Baja Verapaz" },
                    { 21, 1, "Zacapa" },
                    { 22, 1, "Jalapa" }
                });
        }
    }
}
