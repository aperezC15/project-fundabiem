using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerServices.Migrations
{
    public partial class Municipios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "idMunicipio", "idDepartamento", "nombre" },
                values: new object[,]
                {
                    { 1.0, 1.0, "Cahabón" },
                    { 232.0, 16.0, "Ixchiguan" },
                    { 231.0, 16.0, "Esquipulas Palo Gordo" },
                    { 230.0, 16.0, "El Tumbador" },
                    { 229.0, 16.0, "El Rodeo" },
                    { 228.0, 16.0, "El Quetzal" },
                    { 227.0, 16.0, "Concepción Tutuapa" },
                    { 226.0, 16.0, "Comitancillo" },
                    { 225.0, 16.0, "Catarina" },
                    { 224.0, 16.0, "Ayutla" },
                    { 223.0, 15.0, "Sumpango" },
                    { 222.0, 15.0, "Santo Domingo Xenacoj" },
                    { 221.0, 15.0, "Santiago Sacatepéquez" },
                    { 220.0, 15.0, "Santa María de Jesús" },
                    { 219.0, 15.0, "Santa Lucía Milpas Altas" },
                    { 218.0, 15.0, "Santa Catarina Barahona" },
                    { 217.0, 15.0, "San Miguel Dueñas" },
                    { 216.0, 15.0, "San Lucas Sacatepéquez" },
                    { 233.0, 16.0, "La Reforma" },
                    { 215.0, 15.0, "San Bartolomé Milpas Altas" },
                    { 234.0, 16.0, "Malacatán" },
                    { 236.0, 16.0, "Ocos" },
                    { 253.0, 17.0, "Barberena" },
                    { 252.0, 16.0, "Tejutla" },
                    { 251.0, 16.0, "Tajumulco" },
                    { 250.0, 16.0, "Tacaná" },
                    { 249.0, 16.0, "Sipacapa" },
                    { 248.0, 16.0, "San Sibinal" },
                    { 247.0, 16.0, "San Rafael Pie de La Cuesta" },
                    { 246.0, 16.0, "San Pedro Sacatepéquez" },
                    { 245.0, 16.0, "San Pablo" },
                    { 244.0, 16.0, "San Miguel Ixtahuacán" },
                    { 243.0, 16.0, "San Marcos" },
                    { 242.0, 16.0, "San Lorenzo" },
                    { 241.0, 16.0, "San José Ojetenam" },
                    { 240.0, 16.0, "San Cristóbal Cucho" },
                    { 239.0, 16.0, "San Antonio Sacatepéquez" },
                    { 238.0, 16.0, "Río Blanco" },
                    { 237.0, 16.0, "Pajapita" },
                    { 235.0, 16.0, "Nuevo Progreso" },
                    { 214.0, 15.0, "San Antonio Aguas Calientes" },
                    { 213.0, 15.0, "Pastores" },
                    { 212.0, 15.0, "Magdalena Milpas Altas" },
                    { 189.0, 13.0, "Patzité" },
                    { 188.0, 13.0, "Pachalum" },
                    { 187.0, 13.0, "Nebaj" },
                    { 186.0, 13.0, "Joyabaj" },
                    { 185.0, 13.0, "Ixcán" },
                    { 184.0, 13.0, "Cunén" },
                    { 183.0, 13.0, "Chinique" },
                    { 182.0, 13.0, "Chichicastenango" },
                    { 181.0, 13.0, "Chiché" },
                    { 180.0, 13.0, "Chicamán" },
                    { 179.0, 13.0, "Chajul" },
                    { 178.0, 13.0, "Canillá" },
                    { 177.0, 12.0, "Zunil" },
                    { 176.0, 12.0, "Sibilia" },
                    { 175.0, 12.0, "San Miguel Sigüilá" },
                    { 174.0, 12.0, "San Mateo" },
                    { 173.0, 12.0, "San Martín Sacatepéquez" },
                    { 190.0, 13.0, "Sacapulas" },
                    { 191.0, 13.0, "San Andrés Sajcabajá" },
                    { 192.0, 13.0, "San Antonio Ilotenango" },
                    { 193.0, 13.0, "San Bartolomé Jocotenango" },
                    { 211.0, 15.0, "Jocotenango" },
                    { 210.0, 15.0, "Ciudad Vieja" },
                    { 209.0, 15.0, "Antigua" },
                    { 208.0, 15.0, "Alotenango" },
                    { 207.0, 14.0, "Santa Cruz Muluá" },
                    { 206.0, 14.0, "San Sebastián" },
                    { 205.0, 14.0, "San Martín Zapotitlán" },
                    { 204.0, 14.0, "San Felipe" },
                    { 254.0, 17.0, "Casillas" },
                    { 203.0, 14.0, "San Andrés Villa Seca" },
                    { 201.0, 14.0, "Nuevo San Carlos" },
                    { 200.0, 14.0, "El Asintal" },
                    { 199.0, 14.0, "Champerico" },
                    { 198.0, 13.0, "Zacualpa" },
                    { 197.0, 13.0, "Uspantán" },
                    { 196.0, 13.0, "Santa Cruz del Quiché" },
                    { 195.0, 13.0, "San Pedro Jocopilas" },
                    { 194.0, 13.0, "San Juan Cotzal" },
                    { 202.0, 14.0, "Retalhuleu" },
                    { 172.0, 12.0, "San Francisco La Unión" },
                    { 255.0, 17.0, "Chiquimulilla" },
                    { 257.0, 17.0, "Guazacapán" },
                    { 317.0, 21.0, "Gualán" },
                    { 316.0, 21.0, "Estanzuela" },
                    { 315.0, 21.0, "Cabañas" },
                    { 314.0, 20.0, "San" },
                    { 313.0, 20.0, "Totonicapán" },
                    { 312.0, 20.0, "Santa María Chiquimula" },
                    { 311.0, 20.0, "Santa Lucía La Reforma" },
                    { 310.0, 20.0, "San Francisco El Alto" },
                    { 309.0, 20.0, "San Cristóbal Totonicapán" },
                    { 308.0, 20.0, "San Bartolo" },
                    { 307.0, 20.0, "San Andrés Xecul" },
                    { 306.0, 20.0, "Momostenango" },
                    { 305.0, 19.0, "Zunilito" },
                    { 304.0, 19.0, "Santo Tomas La Unión" },
                    { 303.0, 19.0, "Santo Domingo Suchitepequez" },
                    { 302.0, 19.0, "Santa Bárbara" },
                    { 301.0, 19.0, "San Pablo Jocopilas" },
                    { 318.0, 21.0, "Huité" },
                    { 300.0, 19.0, "San Miguel Panán" },
                    { 319.0, 21.0, "La Unión" },
                    { 321.0, 21.0, "San Diego" },
                    { 338.0, 11.0, "El Chal" },
                    { 337.0, 8.0, "San Ildefonso Ixtahuacán" },
                    { 336.0, 8.0, "Petatán" },
                    { 335.0, 7.0, "Villa Nueva" },
                    { 334.0, 6.0, "Sipacate" },
                    { 333.0, 6.0, "Guanagazapa" },
                    { 332.0, 5.0, "Sansare" },
                    { 331.0, 22.0, "San Manuel Chaparrón" },
                    { 330.0, 22.0, "San Pedro Pinula" },
                    { 329.0, 22.0, "San Luis Jilotepeque" },
                    { 328.0, 22.0, "San Carlos Alzatate" },
                    { 327.0, 22.0, "Monjas" },
                    { 326.0, 22.0, "Mataquescuintla" },
                    { 325.0, 22.0, "Jalapa" },
                    { 324.0, 21.0, "Zacapa" },
                    { 323.0, 21.0, "Usumatlán" },
                    { 322.0, 21.0, "Teculután" },
                    { 320.0, 21.0, "Río Hondo" },
                    { 299.0, 19.0, "San Lorenzo" },
                    { 298.0, 19.0, "San Juan Bautista" },
                    { 297.0, 19.0, "San José El Idolo" },
                    { 274.0, 18.0, "San Lucas Tolimán" },
                    { 273.0, 18.0, "San Juan La Laguna" },
                    { 272.0, 18.0, "San José Chacaya" },
                    { 271.0, 18.0, "San Antonio Palopó" },
                    { 270.0, 18.0, "San Andrés Semetabaj" },
                    { 269.0, 18.0, "Panajachel" },
                    { 268.0, 18.0, "Nahualá" },
                    { 267.0, 18.0, "Concepción" },
                    { 266.0, 17.0, "Taxisco" },
                    { 265.0, 17.0, "Santa Rosa de Lima" },
                    { 264.0, 17.0, "Santa María Ixhuatán" },
                    { 263.0, 17.0, "Santa Cruz Naranjo" },
                    { 262.0, 17.0, "San Rafael Las Flores" },
                    { 261.0, 17.0, "San Juan Tecuaco" },
                    { 260.0, 17.0, "Pueblo Nuevo Viñas" },
                    { 259.0, 17.0, "Oratorio" },
                    { 258.0, 17.0, "Nueva Santa Rosa" },
                    { 275.0, 18.0, "San Marcos La Laguna" },
                    { 276.0, 18.0, "San Pablo La Laguna" },
                    { 277.0, 18.0, "San Pedro La Laguna" },
                    { 278.0, 18.0, "Santa Catarina Ixtahuacan" },
                    { 296.0, 19.0, "San Gabriel" },
                    { 295.0, 19.0, "San Francisco Zapotitlán" },
                    { 294.0, 19.0, "San Bernardino" },
                    { 293.0, 19.0, "San Antonio Suchitepéquez" },
                    { 292.0, 19.0, "Samayac" },
                    { 291.0, 19.0, "Río Bravo" },
                    { 290.0, 19.0, "Pueblo Nuevo" },
                    { 289.0, 19.0, "Patulul" },
                    { 256.0, 17.0, "Cuilapa" },
                    { 288.0, 19.0, "Mazatenango" },
                    { 286.0, 19.0, "Chicacao" },
                    { 285.0, 18.0, "Sololá" },
                    { 284.0, 18.0, "Santiago Atitlán" },
                    { 283.0, 18.0, "Santa María Visitación" },
                    { 282.0, 18.0, "Santa Lucía Utatlán" },
                    { 281.0, 18.0, "Santa Cruz La Laguna" },
                    { 280.0, 18.0, "Santa Clara La Laguna" },
                    { 279.0, 18.0, "Santa Catarina Palopó" },
                    { 287.0, 19.0, "Cuyotenango" },
                    { 171.0, 12.0, "San Carlos Sija" },
                    { 170.0, 12.0, "Salcajá" },
                    { 169.0, 12.0, "Quetzaltenango" },
                    { 61.0, 6.0, "Iztapa" },
                    { 60.0, 6.0, "Escuintla" },
                    { 59.0, 5.0, "Sanarate" },
                    { 58.0, 5.0, "San Cristóbal Acasaguastlán" },
                    { 57.0, 5.0, "San Antonio La Paz" },
                    { 56.0, 5.0, "San Agustín Acasaguastlán" },
                    { 55.0, 5.0, "Morazán" },
                    { 54.0, 5.0, "Guastatoya" },
                    { 53.0, 5.0, "El Jícaro" },
                    { 52.0, 4.0, "San Juan Ermita" },
                    { 51.0, 4.0, "San José La Arada" },
                    { 50.0, 4.0, "San Jacinto" },
                    { 49.0, 4.0, "Quezaltepeque" },
                    { 48.0, 4.0, "Olopa" },
                    { 47.0, 4.0, "Jocotán" },
                    { 46.0, 4.0, "Ipala" },
                    { 45.0, 4.0, "Esquipulas" },
                    { 62.0, 6.0, "La Democracia" },
                    { 44.0, 4.0, "Concepción Las Minas" },
                    { 63.0, 6.0, "La Gomera" },
                    { 65.0, 6.0, "Nueva Concepción" },
                    { 82.0, 7.0, "San Juan Sacatepéquez" },
                    { 81.0, 7.0, "San José Pinula" },
                    { 80.0, 7.0, "San José del Golfo" },
                    { 79.0, 7.0, "San Miguel Petapa" },
                    { 78.0, 7.0, "Palencia" },
                    { 77.0, 7.0, "Mixco" },
                    { 76.0, 7.0, "Guatemala" },
                    { 75.0, 7.0, "Fraijanes" },
                    { 74.0, 7.0, "Chuarrancho" },
                    { 73.0, 7.0, "Chinautla" },
                    { 72.0, 7.0, "Amatitlán" },
                    { 71.0, 6.0, "Tiquisate" },
                    { 70.0, 6.0, "Siquinalá" },
                    { 69.0, 6.0, "Santa Lucía Cotzumalguapa" },
                    { 68.0, 6.0, "San Vicente Pacaya" },
                    { 67.0, 6.0, "San José" },
                    { 66.0, 6.0, "Palín" },
                    { 64.0, 6.0, "Masagua" },
                    { 43.0, 4.0, "Chiquimula" },
                    { 42.0, 4.0, "Camotán" },
                    { 41.0, 3.0, "Zaragoza" },
                    { 18.0, 2.0, "Cubulco" },
                    { 17.0, 1.0, "Santa Catarina La Tinta" },
                    { 16.0, 1.0, "Tucurú" },
                    { 15.0, 1.0, "Tamahú" },
                    { 14.0, 1.0, "Tactic" },
                    { 13.0, 1.0, "Senahú" },
                    { 12.0, 1.0, "Santa Cruz Verapaz" },
                    { 11.0, 1.0, "San Pedro Carchá" },
                    { 10.0, 1.0, "San Juan Chamelco" },
                    { 9.0, 1.0, "San Cristóbal Verapaz" },
                    { 8.0, 1.0, "Raxruha" },
                    { 7.0, 1.0, "Panzós" },
                    { 6.0, 1.0, "Lanquín" },
                    { 5.0, 1.0, "Fray Bartolomé de las Casas" },
                    { 4.0, 1.0, "Cobán" },
                    { 3.0, 1.0, "Chisec" },
                    { 2.0, 1.0, "Chahal" },
                    { 19.0, 2.0, "Granados" },
                    { 20.0, 2.0, "Purulhá" },
                    { 21.0, 2.0, "Rabinal" },
                    { 22.0, 2.0, "Salamá" },
                    { 40.0, 3.0, "Yepocapa" },
                    { 39.0, 3.0, "Tecpán Guatemala" },
                    { 38.0, 3.0, "Santa Cruz Balanyá" },
                    { 37.0, 3.0, "Santa Apolonia" },
                    { 36.0, 3.0, "San Martín Jilotepeque" },
                    { 35.0, 3.0, "San Juan Comalapa" },
                    { 34.0, 3.0, "San José Poaquil" },
                    { 33.0, 3.0, "San Andrés Itzapa" },
                    { 83.0, 7.0, "San Pedro Ayampuc" },
                    { 32.0, 3.0, "Pochuta" },
                    { 30.0, 3.0, "Patzicía" },
                    { 29.0, 3.0, "Parramos" },
                    { 28.0, 3.0, "El Tejar" },
                    { 27.0, 3.0, "Chimaltenango" },
                    { 26.0, 3.0, "Acatenango" },
                    { 25.0, 2.0, "Santa Cruz El Chol" },
                    { 24.0, 2.0, "San Miguel Chicaj" },
                    { 23.0, 2.0, "San Jerónimo" },
                    { 31.0, 3.0, "Patzún" },
                    { 84.0, 7.0, "San Pedro Sacatepéquez" },
                    { 85.0, 7.0, "San Raymundo" },
                    { 86.0, 7.0, "Santa Catarina Pinula" },
                    { 146.0, 11.0, "San Andrés" },
                    { 145.0, 11.0, "Poptún" },
                    { 144.0, 11.0, "Melchor de Mencos" },
                    { 143.0, 11.0, "La Libertad" },
                    { 142.0, 11.0, "Flores" },
                    { 141.0, 11.0, "Dolores" },
                    { 140.0, 10.0, "Zapotitlán" },
                    { 139.0, 10.0, "Yupiltepeque" },
                    { 138.0, 10.0, "Santa Catarina Mita" },
                    { 137.0, 10.0, "San José Acatempa" },
                    { 136.0, 10.0, "Quezada" },
                    { 135.0, 10.0, "Pasaco" },
                    { 134.0, 10.0, "Moyuta" },
                    { 133.0, 10.0, "Jutiapa" },
                    { 132.0, 10.0, "Jerez" },
                    { 131.0, 10.0, "Jalpatagua" },
                    { 130.0, 10.0, "El Progreso" },
                    { 147.0, 11.0, "San Benito" },
                    { 148.0, 11.0, "San Francisco" },
                    { 149.0, 11.0, "San José" },
                    { 150.0, 11.0, "San Luis" },
                    { 168.0, 12.0, "Palestina de Los Altos" },
                    { 167.0, 12.0, "Ostuncalco" },
                    { 166.0, 12.0, "Olintepeque" },
                    { 165.0, 12.0, "La Esperanza" },
                    { 164.0, 12.0, "Huitán" },
                    { 163.0, 12.0, "Génova" },
                    { 162.0, 12.0, "Flores Costa Cuca" },
                    { 161.0, 12.0, "El Palmar" },
                    { 129.0, 10.0, "El Adelanto" },
                    { 160.0, 12.0, "Concepción Chiquirichapa" },
                    { 158.0, 12.0, "Coatepeque" },
                    { 157.0, 12.0, "Cantel" },
                    { 156.0, 12.0, "Cajolá" },
                    { 155.0, 12.0, "Cabricán" },
                    { 154.0, 12.0, "Almolonga" },
                    { 153.0, 11.0, "Las Cruces" },
                    { 152.0, 11.0, "Sayaxché" },
                    { 151.0, 11.0, "Santa Ana" },
                    { 159.0, 12.0, "Colomba" },
                    { 339.0, 16.0, "La Blanca" },
                    { 128.0, 10.0, "Conguaco" },
                    { 126.0, 10.0, "Atescatempa" },
                    { 103.0, 8.0, "San Juan Ixcoy" },
                    { 102.0, 8.0, "San Juan Atitán" },
                    { 101.0, 8.0, "San Gaspar Ixchil" },
                    { 100.0, 8.0, "San Antonio Huista" },
                    { 99.0, 8.0, "Nentón" },
                    { 98.0, 8.0, "Malacatancito" },
                    { 97.0, 8.0, "La Libertad" },
                    { 96.0, 8.0, "La Democracia" },
                    { 95.0, 8.0, "Jacaltenango" },
                    { 94.0, 8.0, "Ixtahuacán" },
                    { 93.0, 8.0, "Huehuetenango" },
                    { 92.0, 8.0, "Cuilco" },
                    { 91.0, 8.0, "Concepción Huista" },
                    { 90.0, 8.0, "Colotenango" },
                    { 89.0, 8.0, "Chiantla" },
                    { 88.0, 8.0, "Aguacatán" },
                    { 87.0, 7.0, "Villa Canales" },
                    { 104.0, 8.0, "San Mateo Ixtatán" },
                    { 105.0, 8.0, "San Miguel Acatán" },
                    { 106.0, 8.0, "San Pedro Necta" },
                    { 107.0, 8.0, "San Rafael La Independencia" },
                    { 125.0, 10.0, "Asunción Mita" },
                    { 124.0, 10.0, "Agua Blanca" },
                    { 123.0, 9.0, "Puerto Barrios" },
                    { 122.0, 9.0, "Morales" },
                    { 121.0, 9.0, "Los Amates" },
                    { 120.0, 9.0, "Livingston" },
                    { 119.0, 9.0, "El Estor" },
                    { 118.0, 8.0, "Todos Santos Cuchumatan" },
                    { 127.0, 10.0, "Comapa" },
                    { 117.0, 8.0, "Tectitán" },
                    { 115.0, 8.0, "Santiago Chimaltenango" },
                    { 114.0, 8.0, "Santa Eulalia" },
                    { 113.0, 8.0, "Santa Cruz Barillas" },
                    { 112.0, 8.0, "Santa Bárbara" },
                    { 111.0, 8.0, "Santa Ana Huista" },
                    { 110.0, 8.0, "San Sebastián Huehuetenango" },
                    { 109.0, 8.0, "San Sebastián Coatán" },
                    { 108.0, 8.0, "San Rafael Petzal" },
                    { 116.0, 8.0, "Soloma" },
                    { 340.0, 19.0, "San José La Máquina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 1.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 2.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 3.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 4.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 5.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 6.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 7.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 8.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 9.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 10.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 11.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 12.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 13.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 14.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 15.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 16.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 17.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 18.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 19.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 20.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 21.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 22.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 23.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 24.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 25.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 26.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 27.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 28.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 29.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 30.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 31.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 32.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 33.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 34.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 35.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 36.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 37.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 38.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 39.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 40.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 41.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 42.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 43.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 44.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 45.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 46.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 47.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 48.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 49.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 50.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 51.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 52.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 53.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 54.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 55.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 56.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 57.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 58.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 59.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 60.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 61.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 62.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 63.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 64.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 65.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 66.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 67.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 68.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 69.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 70.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 71.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 72.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 73.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 74.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 75.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 76.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 77.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 78.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 79.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 80.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 81.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 82.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 83.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 84.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 85.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 86.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 87.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 88.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 89.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 90.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 91.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 92.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 93.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 94.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 95.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 96.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 97.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 98.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 99.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 100.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 101.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 102.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 103.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 104.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 105.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 106.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 107.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 108.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 109.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 110.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 111.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 112.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 113.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 114.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 115.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 116.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 117.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 118.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 119.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 120.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 121.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 122.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 123.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 124.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 125.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 126.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 127.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 128.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 129.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 130.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 131.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 132.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 133.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 134.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 135.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 136.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 137.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 138.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 139.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 140.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 141.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 142.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 143.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 144.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 145.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 146.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 147.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 148.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 149.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 150.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 151.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 152.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 153.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 154.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 155.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 156.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 157.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 158.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 159.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 160.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 161.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 162.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 163.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 164.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 165.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 166.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 167.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 168.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 169.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 170.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 171.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 172.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 173.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 174.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 175.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 176.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 177.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 178.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 179.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 180.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 181.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 182.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 183.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 184.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 185.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 186.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 187.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 188.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 189.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 190.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 191.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 192.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 193.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 194.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 195.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 196.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 197.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 198.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 199.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 200.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 201.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 202.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 203.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 204.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 205.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 206.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 207.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 208.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 209.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 210.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 211.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 212.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 213.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 214.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 215.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 216.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 217.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 218.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 219.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 220.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 221.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 222.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 22.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 224.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 225.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 226.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 227.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 228.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 229.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 230.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 231.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 232.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 233.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 234.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 235.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 236.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 237.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 238.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 239.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 240.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 241.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 242.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 243.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 244.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 245.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 246.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 247.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 248.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 249.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 250.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 251.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 252.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 253.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 254.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 255.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 256.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 257.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 258.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 259.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 260.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 261.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 262.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 263.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 264.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 265.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 266.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 267.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 268.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 269.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 270.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 271.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 272.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 273.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 274.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 275.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 276.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 277.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 278.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 279.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 280.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 281.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 282.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 283.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 284.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 285.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 286.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 287.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 288.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 289.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 290.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 291.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 292.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 293.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 294.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 295.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 296.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 297.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 298.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 299.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 300.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 301.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 302.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 303.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 304.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 305.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 306.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 307.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 308.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 309.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 310.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 311.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 312.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 313.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 314.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 315.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 316.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 317.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 318.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 319.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 320.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 321.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 322.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 323.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 324.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 325.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 326.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 327.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 328.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 329.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 330.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 331.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 332.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 333.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 334.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 335.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 336.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 337.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 338.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 339.0);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "idMunicipio",
                keyValue: 340.0);
        }
    }
}
