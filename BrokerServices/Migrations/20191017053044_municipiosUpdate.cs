using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class municipiosUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "idMunicipio", "idDepartamento", "nombre" },
                values: new object[,]
                {
                    { 1L, 1L, "Cahabón" },
                    { 232L, 16L, "Ixchiguan" },
                    { 231L, 16L, "Esquipulas Palo Gordo" },
                    { 230L, 16L, "El Tumbador" },
                    { 229L, 16L, "El Rodeo" },
                    { 228L, 16L, "El Quetzal" },
                    { 227L, 16L, "Concepción Tutuapa" },
                    { 226L, 16L, "Comitancillo" },
                    { 225L, 16L, "Catarina" },
                    { 224L, 16L, "Ayutla" },
                    { 223L, 15L, "Sumpango" },
                    { 222L, 15L, "Santo Domingo Xenacoj" },
                    { 221L, 15L, "Santiago Sacatepéquez" },
                    { 220L, 15L, "Santa María de Jesús" },
                    { 219L, 15L, "Santa Lucía Milpas Altas" },
                    { 218L, 15L, "Santa Catarina Barahona" },
                    { 217L, 15L, "San Miguel Dueñas" },
                    { 216L, 15L, "San Lucas Sacatepéquez" },
                    { 233L, 16L, "La Reforma" },
                    { 215L, 15L, "San Bartolomé Milpas Altas" },
                    { 234L, 16L, "Malacatán" },
                    { 236L, 16L, "Ocos" },
                    { 253L, 17L, "Barberena" },
                    { 252L, 16L, "Tejutla" },
                    { 251L, 16L, "Tajumulco" },
                    { 250L, 16L, "Tacaná" },
                    { 249L, 16L, "Sipacapa" },
                    { 248L, 16L, "San Sibinal" },
                    { 247L, 16L, "San Rafael Pie de La Cuesta" },
                    { 246L, 16L, "San Pedro Sacatepéquez" },
                    { 245L, 16L, "San Pablo" },
                    { 244L, 16L, "San Miguel Ixtahuacán" },
                    { 243L, 16L, "San Marcos" },
                    { 242L, 16L, "San Lorenzo" },
                    { 241L, 16L, "San José Ojetenam" },
                    { 240L, 16L, "San Cristóbal Cucho" },
                    { 239L, 16L, "San Antonio Sacatepéquez" },
                    { 238L, 16L, "Río Blanco" },
                    { 237L, 16L, "Pajapita" },
                    { 235L, 16L, "Nuevo Progreso" },
                    { 214L, 15L, "San Antonio Aguas Calientes" },
                    { 213L, 15L, "Pastores" },
                    { 212L, 15L, "Magdalena Milpas Altas" },
                    { 189L, 13L, "Patzité" },
                    { 188L, 13L, "Pachalum" },
                    { 187L, 13L, "Nebaj" },
                    { 186L, 13L, "Joyabaj" },
                    { 185L, 13L, "Ixcán" },
                    { 184L, 13L, "Cunén" },
                    { 183L, 13L, "Chinique" },
                    { 182L, 13L, "Chichicastenango" },
                    { 181L, 13L, "Chiché" },
                    { 180L, 13L, "Chicamán" },
                    { 179L, 13L, "Chajul" },
                    { 178L, 13L, "Canillá" },
                    { 177L, 12L, "Zunil" },
                    { 176L, 12L, "Sibilia" },
                    { 175L, 12L, "San Miguel Sigüilá" },
                    { 174L, 12L, "San Mateo" },
                    { 173L, 12L, "San Martín Sacatepéquez" },
                    { 190L, 13L, "Sacapulas" },
                    { 191L, 13L, "San Andrés Sajcabajá" },
                    { 192L, 13L, "San Antonio Ilotenango" },
                    { 193L, 13L, "San Bartolomé Jocotenango" },
                    { 211L, 15L, "Jocotenango" },
                    { 210L, 15L, "Ciudad Vieja" },
                    { 209L, 15L, "Antigua" },
                    { 208L, 15L, "Alotenango" },
                    { 207L, 14L, "Santa Cruz Muluá" },
                    { 206L, 14L, "San Sebastián" },
                    { 205L, 14L, "San Martín Zapotitlán" },
                    { 204L, 14L, "San Felipe" },
                    { 254L, 17L, "Casillas" },
                    { 203L, 14L, "San Andrés Villa Seca" },
                    { 201L, 14L, "Nuevo San Carlos" },
                    { 200L, 14L, "El Asintal" },
                    { 199L, 14L, "Champerico" },
                    { 198L, 13L, "Zacualpa" },
                    { 197L, 13L, "Uspantán" },
                    { 196L, 13L, "Santa Cruz del Quiché" },
                    { 195L, 13L, "San Pedro Jocopilas" },
                    { 194L, 13L, "San Juan Cotzal" },
                    { 202L, 14L, "Retalhuleu" },
                    { 172L, 12L, "San Francisco La Unión" },
                    { 255L, 17L, "Chiquimulilla" },
                    { 257L, 17L, "Guazacapán" },
                    { 317L, 21L, "Gualán" },
                    { 316L, 21L, "Estanzuela" },
                    { 315L, 21L, "Cabañas" },
                    { 314L, 20L, "San" },
                    { 313L, 20L, "Totonicapán" },
                    { 312L, 20L, "Santa María Chiquimula" },
                    { 311L, 20L, "Santa Lucía La Reforma" },
                    { 310L, 20L, "San Francisco El Alto" },
                    { 309L, 20L, "San Cristóbal Totonicapán" },
                    { 308L, 20L, "San Bartolo" },
                    { 307L, 20L, "San Andrés Xecul" },
                    { 306L, 20L, "Momostenango" },
                    { 305L, 19L, "Zunilito" },
                    { 304L, 19L, "Santo Tomas La Unión" },
                    { 303L, 19L, "Santo Domingo Suchitepequez" },
                    { 302L, 19L, "Santa Bárbara" },
                    { 301L, 19L, "San Pablo Jocopilas" },
                    { 318L, 21L, "Huité" },
                    { 300L, 19L, "San Miguel Panán" },
                    { 319L, 21L, "La Unión" },
                    { 321L, 21L, "San Diego" },
                    { 338L, 11L, "El Chal" },
                    { 337L, 8L, "San Ildefonso Ixtahuacán" },
                    { 336L, 8L, "Petatán" },
                    { 335L, 7L, "Villa Nueva" },
                    { 334L, 6L, "Sipacate" },
                    { 333L, 6L, "Guanagazapa" },
                    { 332L, 5L, "Sansare" },
                    { 331L, 22L, "San Manuel Chaparrón" },
                    { 330L, 22L, "San Pedro Pinula" },
                    { 329L, 22L, "San Luis Jilotepeque" },
                    { 328L, 22L, "San Carlos Alzatate" },
                    { 327L, 22L, "Monjas" },
                    { 326L, 22L, "Mataquescuintla" },
                    { 325L, 22L, "Jalapa" },
                    { 324L, 21L, "Zacapa" },
                    { 323L, 21L, "Usumatlán" },
                    { 322L, 21L, "Teculután" },
                    { 320L, 21L, "Río Hondo" },
                    { 299L, 19L, "San Lorenzo" },
                    { 298L, 19L, "San Juan Bautista" },
                    { 297L, 19L, "San José El Idolo" },
                    { 274L, 18L, "San Lucas Tolimán" },
                    { 273L, 18L, "San Juan La Laguna" },
                    { 272L, 18L, "San José Chacaya" },
                    { 271L, 18L, "San Antonio Palopó" },
                    { 270L, 18L, "San Andrés Semetabaj" },
                    { 269L, 18L, "Panajachel" },
                    { 268L, 18L, "Nahualá" },
                    { 267L, 18L, "Concepción" },
                    { 266L, 17L, "Taxisco" },
                    { 265L, 17L, "Santa Rosa de Lima" },
                    { 264L, 17L, "Santa María Ixhuatán" },
                    { 263L, 17L, "Santa Cruz Naranjo" },
                    { 262L, 17L, "San Rafael Las Flores" },
                    { 261L, 17L, "San Juan Tecuaco" },
                    { 260L, 17L, "Pueblo Nuevo Viñas" },
                    { 259L, 17L, "Oratorio" },
                    { 258L, 17L, "Nueva Santa Rosa" },
                    { 275L, 18L, "San Marcos La Laguna" },
                    { 276L, 18L, "San Pablo La Laguna" },
                    { 277L, 18L, "San Pedro La Laguna" },
                    { 278L, 18L, "Santa Catarina Ixtahuacan" },
                    { 296L, 19L, "San Gabriel" },
                    { 295L, 19L, "San Francisco Zapotitlán" },
                    { 294L, 19L, "San Bernardino" },
                    { 293L, 19L, "San Antonio Suchitepéquez" },
                    { 292L, 19L, "Samayac" },
                    { 291L, 19L, "Río Bravo" },
                    { 290L, 19L, "Pueblo Nuevo" },
                    { 289L, 19L, "Patulul" },
                    { 256L, 17L, "Cuilapa" },
                    { 288L, 19L, "Mazatenango" },
                    { 286L, 19L, "Chicacao" },
                    { 285L, 18L, "Sololá" },
                    { 284L, 18L, "Santiago Atitlán" },
                    { 283L, 18L, "Santa María Visitación" },
                    { 282L, 18L, "Santa Lucía Utatlán" },
                    { 281L, 18L, "Santa Cruz La Laguna" },
                    { 280L, 18L, "Santa Clara La Laguna" },
                    { 279L, 18L, "Santa Catarina Palopó" },
                    { 287L, 19L, "Cuyotenango" },
                    { 171L, 12L, "San Carlos Sija" },
                    { 170L, 12L, "Salcajá" },
                    { 169L, 12L, "Quetzaltenango" },
                    { 61L, 6L, "Iztapa" },
                    { 60L, 6L, "Escuintla" },
                    { 59L, 5L, "Sanarate" },
                    { 58L, 5L, "San Cristóbal Acasaguastlán" },
                    { 57L, 5L, "San Antonio La Paz" },
                    { 56L, 5L, "San Agustín Acasaguastlán" },
                    { 55L, 5L, "Morazán" },
                    { 54L, 5L, "Guastatoya" },
                    { 53L, 5L, "El Jícaro" },
                    { 52L, 4L, "San Juan Ermita" },
                    { 51L, 4L, "San José La Arada" },
                    { 50L, 4L, "San Jacinto" },
                    { 49L, 4L, "Quezaltepeque" },
                    { 48L, 4L, "Olopa" },
                    { 47L, 4L, "Jocotán" },
                    { 46L, 4L, "Ipala" },
                    { 45L, 4L, "Esquipulas" },
                    { 62L, 6L, "La Democracia" },
                    { 44L, 4L, "Concepción Las Minas" },
                    { 63L, 6L, "La Gomera" },
                    { 65L, 6L, "Nueva Concepción" },
                    { 82L, 7L, "San Juan Sacatepéquez" },
                    { 81L, 7L, "San José Pinula" },
                    { 80L, 7L, "San José del Golfo" },
                    { 79L, 7L, "San Miguel Petapa" },
                    { 78L, 7L, "Palencia" },
                    { 77L, 7L, "Mixco" },
                    { 76L, 7L, "Guatemala" },
                    { 75L, 7L, "Fraijanes" },
                    { 74L, 7L, "Chuarrancho" },
                    { 73L, 7L, "Chinautla" },
                    { 72L, 7L, "Amatitlán" },
                    { 71L, 6L, "Tiquisate" },
                    { 70L, 6L, "Siquinalá" },
                    { 69L, 6L, "Santa Lucía Cotzumalguapa" },
                    { 68L, 6L, "San Vicente Pacaya" },
                    { 67L, 6L, "San José" },
                    { 66L, 6L, "Palín" },
                    { 64L, 6L, "Masagua" },
                    { 43L, 4L, "Chiquimula" },
                    { 42L, 4L, "Camotán" },
                    { 41L, 3L, "Zaragoza" },
                    { 18L, 2L, "Cubulco" },
                    { 17L, 1L, "Santa Catarina La Tinta" },
                    { 16L, 1L, "Tucurú" },
                    { 15L, 1L, "Tamahú" },
                    { 14L, 1L, "Tactic" },
                    { 13L, 1L, "Senahú" },
                    { 12L, 1L, "Santa Cruz Verapaz" },
                    { 11L, 1L, "San Pedro Carchá" },
                    { 10L, 1L, "San Juan Chamelco" },
                    { 9L, 1L, "San Cristóbal Verapaz" },
                    { 8L, 1L, "Raxruha" },
                    { 7L, 1L, "Panzós" },
                    { 6L, 1L, "Lanquín" },
                    { 5L, 1L, "Fray Bartolomé de las Casas" },
                    { 4L, 1L, "Cobán" },
                    { 3L, 1L, "Chisec" },
                    { 2L, 1L, "Chahal" },
                    { 19L, 2L, "Granados" },
                    { 20L, 2L, "Purulhá" },
                    { 21L, 2L, "Rabinal" },
                    { 22L, 2L, "Salamá" },
                    { 40L, 3L, "Yepocapa" },
                    { 39L, 3L, "Tecpán Guatemala" },
                    { 38L, 3L, "Santa Cruz Balanyá" },
                    { 37L, 3L, "Santa Apolonia" },
                    { 36L, 3L, "San Martín Jilotepeque" },
                    { 35L, 3L, "San Juan Comalapa" },
                    { 34L, 3L, "San José Poaquil" },
                    { 33L, 3L, "San Andrés Itzapa" },
                    { 83L, 7L, "San Pedro Ayampuc" },
                    { 32L, 3L, "Pochuta" },
                    { 30L, 3L, "Patzicía" },
                    { 29L, 3L, "Parramos" },
                    { 28L, 3L, "El Tejar" },
                    { 27L, 3L, "Chimaltenango" },
                    { 26L, 3L, "Acatenango" },
                    { 25L, 2L, "Santa Cruz El Chol" },
                    { 24L, 2L, "San Miguel Chicaj" },
                    { 23L, 2L, "San Jerónimo" },
                    { 31L, 3L, "Patzún" },
                    { 84L, 7L, "San Pedro Sacatepéquez" },
                    { 85L, 7L, "San Raymundo" },
                    { 86L, 7L, "Santa Catarina Pinula" },
                    { 146L, 11L, "San Andrés" },
                    { 145L, 11L, "Poptún" },
                    { 144L, 11L, "Melchor de Mencos" },
                    { 143L, 11L, "La Libertad" },
                    { 142L, 11L, "Flores" },
                    { 141L, 11L, "Dolores" },
                    { 140L, 10L, "Zapotitlán" },
                    { 139L, 10L, "Yupiltepeque" },
                    { 138L, 10L, "Santa Catarina Mita" },
                    { 137L, 10L, "San José Acatempa" },
                    { 136L, 10L, "Quezada" },
                    { 135L, 10L, "Pasaco" },
                    { 134L, 10L, "Moyuta" },
                    { 133L, 10L, "Jutiapa" },
                    { 132L, 10L, "Jerez" },
                    { 131L, 10L, "Jalpatagua" },
                    { 130L, 10L, "El Progreso" },
                    { 147L, 11L, "San Benito" },
                    { 148L, 11L, "San Francisco" },
                    { 149L, 11L, "San José" },
                    { 150L, 11L, "San Luis" },
                    { 168L, 12L, "Palestina de Los Altos" },
                    { 167L, 12L, "Ostuncalco" },
                    { 166L, 12L, "Olintepeque" },
                    { 165L, 12L, "La Esperanza" },
                    { 164L, 12L, "Huitán" },
                    { 163L, 12L, "Génova" },
                    { 162L, 12L, "Flores Costa Cuca" },
                    { 161L, 12L, "El Palmar" },
                    { 129L, 10L, "El Adelanto" },
                    { 160L, 12L, "Concepción Chiquirichapa" },
                    { 158L, 12L, "Coatepeque" },
                    { 157L, 12L, "Cantel" },
                    { 156L, 12L, "Cajolá" },
                    { 155L, 12L, "Cabricán" },
                    { 154L, 12L, "Almolonga" },
                    { 153L, 11L, "Las Cruces" },
                    { 152L, 11L, "Sayaxché" },
                    { 151L, 11L, "Santa Ana" },
                    { 159L, 12L, "Colomba" },
                    { 339L, 16L, "La Blanca" },
                    { 128L, 10L, "Conguaco" },
                    { 126L, 10L, "Atescatempa" },
                    { 103L, 8L, "San Juan Ixcoy" },
                    { 102L, 8L, "San Juan Atitán" },
                    { 101L, 8L, "San Gaspar Ixchil" },
                    { 100L, 8L, "San Antonio Huista" },
                    { 99L, 8L, "Nentón" },
                    { 98L, 8L, "Malacatancito" },
                    { 97L, 8L, "La Libertad" },
                    { 96L, 8L, "La Democracia" },
                    { 95L, 8L, "Jacaltenango" },
                    { 94L, 8L, "Ixtahuacán" },
                    { 93L, 8L, "Huehuetenango" },
                    { 92L, 8L, "Cuilco" },
                    { 91L, 8L, "Concepción Huista" },
                    { 90L, 8L, "Colotenango" },
                    { 89L, 8L, "Chiantla" },
                    { 88L, 8L, "Aguacatán" },
                    { 87L, 7L, "Villa Canales" },
                    { 104L, 8L, "San Mateo Ixtatán" },
                    { 105L, 8L, "San Miguel Acatán" },
                    { 106L, 8L, "San Pedro Necta" },
                    { 107L, 8L, "San Rafael La Independencia" },
                    { 125L, 10L, "Asunción Mita" },
                    { 124L, 10L, "Agua Blanca" },
                    { 123L, 9L, "Puerto Barrios" },
                    { 122L, 9L, "Morales" },
                    { 121L, 9L, "Los Amates" },
                    { 120L, 9L, "Livingston" },
                    { 119L, 9L, "El Estor" },
                    { 118L, 8L, "Todos Santos Cuchumatan" },
                    { 127L, 10L, "Comapa" },
                    { 117L, 8L, "Tectitán" },
                    { 115L, 8L, "Santiago Chimaltenango" },
                    { 114L, 8L, "Santa Eulalia" },
                    { 113L, 8L, "Santa Cruz Barillas" },
                    { 112L, 8L, "Santa Bárbara" },
                    { 111L, 8L, "Santa Ana Huista" },
                    { 110L, 8L, "San Sebastián Huehuetenango" },
                    { 109L, 8L, "San Sebastián Coatán" },
                    { 108L, 8L, "San Rafael Petzal" },
                    { 116L, 8L, "Soloma" },
                    { 340L, 19L, "San José La Máquina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 340L);
        }
    }
}
