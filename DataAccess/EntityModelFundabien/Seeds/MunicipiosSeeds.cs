using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;

namespace EntityModelFundabien.Seeds
{
    public static class MunicipiosSeeds
    {
        public static void seddMunicipios(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Municipio>().HasData(
                //municipios de Alta Verapaz
                new Municipio
                {
                    idMunicipio = 241,
                    idDepartamento = 1,
                    nombre= "Cahabón"
                },
                new Municipio
                {
                    idMunicipio = 2,
                    idDepartamento = 1,
                    nombre = "Chahal"
                },
                new Municipio
                {
                    idMunicipio = 3,
                    idDepartamento = 1,
                    nombre = "Chisec"
                },
                new Municipio
                {
                    idMunicipio = 4,
                    idDepartamento = 1,
                    nombre = "Cobán"
                },
                new Municipio
                {
                    idMunicipio = 5,
                    idDepartamento = 1,
                    nombre = "Fray Bartolomé de las Casas"
                },
                new Municipio
                {
                    idMunicipio = 6,
                    idDepartamento = 1,
                    nombre = "Lanquín"
                },
                new Municipio
                {
                    idMunicipio = 7,
                    idDepartamento = 1,
                    nombre = "Panzós"
                },
                new Municipio
                {
                    idMunicipio = 8,
                    idDepartamento = 1,
                    nombre = "Raxruha"
                },
                new Municipio
                {
                    idMunicipio = 9,
                    idDepartamento = 1,
                    nombre = "San Cristóbal Verapaz"
                },
                new Municipio
                {
                    idMunicipio = 10,
                    idDepartamento = 1,
                    nombre = "San Juan Chamelco"
                },
                new Municipio
                {
                    idMunicipio = 11,
                    idDepartamento = 1,
                    nombre = "San Pedro Carchá"
                },
                new Municipio
                {
                    idMunicipio = 12,
                    idDepartamento = 1,
                    nombre = "Santa Cruz Verapaz"
                },
                new Municipio
                {
                    idMunicipio = 13,
                    idDepartamento = 1,
                    nombre = "Senahú"
                },
                new Municipio
                {
                    idMunicipio = 14,
                    idDepartamento = 1,
                    nombre = "Tactic"
                },
                new Municipio
                {
                    idMunicipio = 15,
                    idDepartamento = 1,
                    nombre = "Tamahú"
                },
                new Municipio
                {
                    idMunicipio = 16,
                    idDepartamento = 1,
                    nombre = "Tucurú"
                },
                new Municipio
                {
                    idMunicipio = 17,
                    idDepartamento = 1,
                    nombre = "Santa Catarina La Tinta"
                },

                //municipios de Baja Verapaz
                new Municipio
                {
                    idMunicipio = 18,
                    idDepartamento = 2,
                    nombre = "Cubulco"
                },
                new Municipio
                {
                    idMunicipio = 19,
                    idDepartamento = 2,
                    nombre = "Granados"
                },
                new Municipio
                {
                    idMunicipio = 20,
                    idDepartamento = 2,
                    nombre = "Purulhá"
                },
                new Municipio
                {
                    idMunicipio = 21,
                    idDepartamento = 2,
                    nombre = "Rabinal"
                },
                new Municipio
                {
                    idMunicipio = 22,
                    idDepartamento = 2,
                    nombre = "Salamá"
                },
                new Municipio
                {
                    idMunicipio = 23,
                    idDepartamento = 2,
                    nombre = "San Jerónimo"
                },
                new Municipio
                {
                    idMunicipio = 24,
                    idDepartamento = 2,
                    nombre = "San Miguel Chicaj"
                },
                new Municipio
                {
                    idMunicipio = 25,
                    idDepartamento = 2,
                    nombre = "Santa Cruz El Chol"
                },
                //Municipios de chimaltenango
                new Municipio
                {
                    idMunicipio = 26,
                    idDepartamento = 3,
                    nombre = "Acatenango"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Chimaltenango"
                },
                new Municipio
                {
                    idMunicipio = 28,
                    idDepartamento = 3,
                    nombre = "El Tejar"
                },
                new Municipio
                {
                    idMunicipio = 29,
                    idDepartamento = 3,
                    nombre = "Parramos"
                },
                new Municipio
                {
                    idMunicipio = 30,
                    idDepartamento = 3,
                    nombre = "Patzicía"
                },
                new Municipio
                {
                    idMunicipio = 31,
                    idDepartamento = 3,
                    nombre = "Patzún"
                },
                new Municipio
                {
                    idMunicipio = 32,
                    idDepartamento = 3,
                    nombre = "Pochuta"
                },
                new Municipio
                {
                    idMunicipio = 33,
                    idDepartamento = 3,
                    nombre = "San Andrés Itzapa"
                },
                new Municipio
                {
                    idMunicipio = 34,
                    idDepartamento = 3,
                    nombre = "San José Poaquil"
                },
                new Municipio
                {
                    idMunicipio = 35,
                    idDepartamento = 3,
                    nombre = "San Juan Comalapa"
                },
                new Municipio
                {
                    idMunicipio = 36,
                    idDepartamento = 3,
                    nombre = "San Martín Jilotepeque"
                },
                new Municipio
                {
                    idMunicipio = 37,
                    idDepartamento = 3,
                    nombre = "Santa Apolonia"
                },
                new Municipio
                {
                    idMunicipio = 38,
                    idDepartamento = 3,
                    nombre = "Santa Cruz Balanyá"
                },
                new Municipio
                {
                    idMunicipio = 39,
                    idDepartamento = 3,
                    nombre = "Tecpán Guatemala"
                },
                new Municipio
                {
                    idMunicipio = 40,
                    idDepartamento = 3,
                    nombre = "Yepocapa"
                },
                new Municipio
                {
                    idMunicipio = 41,
                    idDepartamento = 3,
                    nombre = "Zaragoza"
                },
                //municipios de chiquimula
                new Municipio
                {
                    idMunicipio = 42,
                    idDepartamento = 4,
                    nombre = "Camotán"
                },
                new Municipio
                {
                    idMunicipio = 43,
                    idDepartamento = 4,
                    nombre = "Chiquimula"
                },
                new Municipio
                {
                    idMunicipio = 44,
                    idDepartamento = 4,
                    nombre = "Concepción Las Minas"
                },
                new Municipio
                {
                    idMunicipio = 45,
                    idDepartamento = 4,
                    nombre = "Esquipulas"
                },
                new Municipio
                {
                    idMunicipio = 46,
                    idDepartamento = 4,
                    nombre = "Ipala"
                },
                new Municipio
                {
                    idMunicipio = 47,
                    idDepartamento = 4,
                    nombre = "Jocotán"
                },
                new Municipio
                {
                    idMunicipio = 48,
                    idDepartamento = 4,
                    nombre = "Olopa"
                },
                new Municipio
                {
                    idMunicipio = 49,
                    idDepartamento = 4,
                    nombre = "Quezaltepeque"
                },
                new Municipio
                {
                    idMunicipio = 50,
                    idDepartamento = 4,
                    nombre = "San Jacinto"
                },
                new Municipio
                {
                    idMunicipio = 51,
                    idDepartamento = 4,
                    nombre = "San José La Arada"
                },
                new Municipio
                {
                    idMunicipio = 52,
                    idDepartamento = 4,
                    nombre = "San Juan Ermita"
                },
                //municipios de El progreso
                new Municipio
                {
                    idMunicipio = 53,
                    idDepartamento = 5,
                    nombre = "El Jícaro"
                },
                new Municipio
                {
                    idMunicipio = 54,
                    idDepartamento = 5,
                    nombre = "Guastatoya"
                },
                new Municipio
                {
                    idMunicipio = 55,
                    idDepartamento = 5,
                    nombre = "Morazán"
                },
                new Municipio
                {
                    idMunicipio = 56,
                    idDepartamento = 5,
                    nombre = "San Agustín Acasaguastlán"
                },
                new Municipio
                {
                    idMunicipio = 57,
                    idDepartamento = 5,
                    nombre = "San Antonio La Paz"
                },
                new Municipio
                {
                    idMunicipio = 58,
                    idDepartamento = 5,
                    nombre = "San Cristóbal Acasaguastlán"
                },
                new Municipio
                {
                    idMunicipio = 59,
                    idDepartamento = 5,
                    nombre = "Sanarate"
                },
                //municipios de escuintla
                new Municipio
                {
                    idMunicipio = 60,
                    idDepartamento = 6,
                    nombre = "Escuintla"
                },
                new Municipio
                {
                    idMunicipio = 61,
                    idDepartamento = 6,
                    nombre = "Iztapa"
                },
                new Municipio
                {
                    idMunicipio = 62,
                    idDepartamento = 6,
                    nombre = "La Democracia"
                },
                new Municipio
                {
                    idMunicipio = 63,
                    idDepartamento = 6,
                    nombre = "La Gomera"
                },
                new Municipio
                {
                    idMunicipio = 64,
                    idDepartamento = 6,
                    nombre = "Masagua"
                },
                new Municipio
                {
                    idMunicipio = 65,
                    idDepartamento = 6,
                    nombre = "Nueva Concepción"
                },
                new Municipio
                {
                    idMunicipio = 66,
                    idDepartamento = 6,
                    nombre = "Palín"
                },
                new Municipio
                {
                    idMunicipio = 67,
                    idDepartamento = 6,
                    nombre = "San José"
                },
                new Municipio
                {
                    idMunicipio = 68,
                    idDepartamento = 6,
                    nombre = "San Vicente Pacaya"
                },
                new Municipio
                {
                    idMunicipio = 69,
                    idDepartamento = 6,
                    nombre = "Santa Lucía Cotzumalguapa"
                },
                new Municipio
                {
                    idMunicipio = 70,
                    idDepartamento = 6,
                    nombre = "Siquinalá"
                },
                new Municipio
                {
                    idMunicipio = 71,
                    idDepartamento = 6,
                    nombre = "Tiquisate"
                },
                //municipios de Guatemala
                new Municipio
                {
                    idMunicipio = 72,
                    idDepartamento = 7,
                    nombre = "Amatitlán"
                },
                new Municipio
                {
                    idMunicipio = 73,
                    idDepartamento = 7,
                    nombre = "Chinautla"
                },
                new Municipio
                {
                    idMunicipio = 74,
                    idDepartamento = 7,
                    nombre = "Chuarrancho"
                },
                new Municipio
                {
                    idMunicipio = 75,
                    idDepartamento = 7,
                    nombre = "Fraijanes"
                },
                new Municipio
                {
                    idMunicipio = 76,
                    idDepartamento = 7,
                    nombre = "Guatemala"
                },
                new Municipio
                {
                    idMunicipio = 77,
                    idDepartamento = 7,
                    nombre = "Mixco"
                },
                new Municipio
                {
                    idMunicipio = 78,
                    idDepartamento = 7,
                    nombre = "Palencia"
                },
                new Municipio
                {
                    idMunicipio = 79,
                    idDepartamento = 7,
                    nombre = "San Miguel Petapa"
                },
                new Municipio
                {
                    idMunicipio = 80,
                    idDepartamento = 7,
                    nombre = "San José del Golfo"
                },
                new Municipio
                {
                    idMunicipio = 81,
                    idDepartamento = 7,
                    nombre = "San José Pinula"
                },
                new Municipio
                {
                    idMunicipio = 82,
                    idDepartamento = 7,
                    nombre = "San Juan Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 83,
                    idDepartamento = 7,
                    nombre = "San Pedro Ayampuc"
                },
                new Municipio
                {
                    idMunicipio = 84,
                    idDepartamento = 7,
                    nombre = "San Pedro Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 85,
                    idDepartamento = 7,
                    nombre = "San Raymundo"
                },
                new Municipio
                {
                    idMunicipio = 86,
                    idDepartamento = 7,
                    nombre = "Santa Catarina Pinula"
                },
                new Municipio
                {
                    idMunicipio = 87,
                    idDepartamento = 7,
                    nombre = "Villa Canales"
                },
                //municipios de huehuetenango
                new Municipio
                {
                    idMunicipio = 88,
                    idDepartamento = 8,
                    nombre = "Aguacatán"
                },
                new Municipio
                {
                    idMunicipio = 89,
                    idDepartamento = 8,
                    nombre = "Chiantla"
                },
                new Municipio
                {
                    idMunicipio = 90,
                    idDepartamento = 8,
                    nombre = "Colotenango"
                },
                new Municipio
                {
                    idMunicipio = 91,
                    idDepartamento = 8,
                    nombre = "Concepción Huista"
                },
                new Municipio
                {
                    idMunicipio = 92,
                    idDepartamento = 8,
                    nombre = "Cuilco"
                },
                new Municipio
                {
                    idMunicipio = 93,
                    idDepartamento = 8,
                    nombre = "Huehuetenango"
                },
                new Municipio
                {
                    idMunicipio = 94,
                    idDepartamento = 8,
                    nombre = "Ixtahuacán"
                },
                new Municipio
                {
                    idMunicipio = 95,
                    idDepartamento = 8,
                    nombre = "Jacaltenango"
                },
                new Municipio
                {
                    idMunicipio = 96,
                    idDepartamento = 8,
                    nombre = "La Democracia"
                },
                new Municipio
                {
                    idMunicipio = 97,
                    idDepartamento = 8,
                    nombre = "La Libertad"
                },
                new Municipio
                {
                    idMunicipio = 98,
                    idDepartamento = 8,
                    nombre = "Malacatancito"
                },
                new Municipio
                {
                    idMunicipio = 99,
                    idDepartamento = 8,
                    nombre = "Nentón"
                },
                new Municipio
                {
                    idMunicipio = 100,
                    idDepartamento = 8,
                    nombre = "San Antonio Huista"
                },
                new Municipio
                {
                    idMunicipio = 101,
                    idDepartamento = 8,
                    nombre = "San Gaspar Ixchil"
                },
                new Municipio
                {
                    idMunicipio = 102,
                    idDepartamento = 8,
                    nombre = "San Juan Atitán"
                },
                new Municipio
                {
                    idMunicipio = 103,
                    idDepartamento = 8,
                    nombre = "San Juan Ixcoy"
                },
                new Municipio
                {
                    idMunicipio = 104,
                    idDepartamento = 8,
                    nombre = "San Mateo Ixtatán"
                },
                new Municipio
                {
                    idMunicipio = 105,
                    idDepartamento = 8,
                    nombre = "San Miguel Acatán"
                },
                new Municipio
                {
                    idMunicipio = 106,
                    idDepartamento = 8,
                    nombre = "San Pedro Necta"
                },
                new Municipio
                {
                    idMunicipio = 107,
                    idDepartamento = 8,
                    nombre = "San Rafael La Independencia"
                },
                new Municipio
                {
                    idMunicipio = 108,
                    idDepartamento = 8,
                    nombre = "San Rafael Petzal"
                },
                new Municipio
                {
                    idMunicipio = 109,
                    idDepartamento = 8,
                    nombre = "San Sebastián Coatán"
                },
                new Municipio
                {
                    idMunicipio = 110,
                    idDepartamento = 8,
                    nombre = "San Sebastián Huehuetenango"
                },
                new Municipio
                {
                    idMunicipio = 111,
                    idDepartamento = 8,
                    nombre = "Santa Ana Huista"
                },
                new Municipio
                {
                    idMunicipio = 112,
                    idDepartamento = 8,
                    nombre = "Santa Bárbara"
                },
                new Municipio
                {
                    idMunicipio = 113,
                    idDepartamento = 8,
                    nombre = "Santa Cruz Barillas"
                },
                new Municipio
                {
                    idMunicipio = 114,
                    idDepartamento = 8,
                    nombre = "Santa Eulalia"
                },
                new Municipio
                {
                    idMunicipio = 115,
                    idDepartamento = 8,
                    nombre = "Santiago Chimaltenango"
                },
                new Municipio
                {
                    idMunicipio = 116,
                    idDepartamento = 8,
                    nombre = "Soloma"
                },
                new Municipio
                {
                    idMunicipio = 117,
                    idDepartamento = 8,
                    nombre = "Tectitán"
                },
                new Municipio
                {
                    idMunicipio = 118,
                    idDepartamento = 8,
                    nombre = "Todos Santos Cuchumatan"
                },
                //municipios de izabal
                new Municipio
                {
                    idMunicipio = 119,
                    idDepartamento = 9,
                    nombre = "El Estor"
                },
                new Municipio
                {
                    idMunicipio = 120,
                    idDepartamento = 9,
                    nombre = "Livingston"
                },
                new Municipio
                {
                    idMunicipio = 121,
                    idDepartamento = 9,
                    nombre = "Los Amates"
                },
                new Municipio
                {
                    idMunicipio = 122,
                    idDepartamento = 9,
                    nombre = "Morales"
                },
                new Municipio
                {
                    idMunicipio = 123,
                    idDepartamento = 9,
                    nombre = "Puerto Barrios"
                },
                //municipios de Jutiapa
                new Municipio
                {
                    idMunicipio = 124,
                    idDepartamento = 10,
                    nombre = "Agua Blanca"
                },
                new Municipio
                {
                    idMunicipio = 125,
                    idDepartamento = 10,
                    nombre = "Asunción Mita"
                },
                new Municipio
                {
                    idMunicipio = 126,
                    idDepartamento = 10,
                    nombre = "Atescatempa"
                },
                new Municipio
                {
                    idMunicipio = 127,
                    idDepartamento = 10,
                    nombre = "Comapa"
                },
                new Municipio
                {
                    idMunicipio = 128,
                    idDepartamento = 10,
                    nombre = "Conguaco"
                },
                new Municipio
                {
                    idMunicipio = 129,
                    idDepartamento = 10,
                    nombre = "El Adelanto"
                },
                new Municipio
                {
                    idMunicipio = 130,
                    idDepartamento = 10,
                    nombre = "El Progreso"
                },
                new Municipio
                {
                    idMunicipio = 131,
                    idDepartamento = 10,
                    nombre = "Jalpatagua"
                },
                new Municipio
                {
                    idMunicipio = 132,
                    idDepartamento = 10,
                    nombre = "Jerez"
                },
                new Municipio
                {
                    idMunicipio = 133,
                    idDepartamento = 10,
                    nombre = "Jutiapa"
                },
                new Municipio
                {
                    idMunicipio = 134,
                    idDepartamento = 10,
                    nombre = "Moyuta"
                },
                new Municipio
                {
                    idMunicipio = 135,
                    idDepartamento = 10,
                    nombre = "Pasaco"
                },
                new Municipio
                {
                    idMunicipio = 136,
                    idDepartamento = 10,
                    nombre = "Quezada"
                },
                new Municipio
                {
                    idMunicipio = 137,
                    idDepartamento = 10,
                    nombre = "San José Acatempa"
                },
                new Municipio
                {
                    idMunicipio = 138,
                    idDepartamento = 10,
                    nombre = "Santa Catarina Mita"
                },
                new Municipio
                {
                    idMunicipio = 139,
                    idDepartamento = 10,
                    nombre = "Yupiltepeque"
                },
                new Municipio
                {
                    idMunicipio = 140,
                    idDepartamento = 10,
                    nombre = "Zapotitlán"
                },
                //municipios de peten
                new Municipio
                {
                    idMunicipio = 141,
                    idDepartamento = 11,
                    nombre = "Dolores"
                },
                new Municipio
                {
                    idMunicipio = 142,
                    idDepartamento = 11,
                    nombre = "Flores"
                },
                new Municipio
                {
                    idMunicipio = 143,
                    idDepartamento = 11,
                    nombre = "La Libertad"
                },
                new Municipio
                {
                    idMunicipio = 144,
                    idDepartamento = 11,
                    nombre = "Melchor de Mencos"
                },
                new Municipio
                {
                    idMunicipio = 145,
                    idDepartamento = 11,
                    nombre = "Poptún"
                },
                new Municipio
                {
                    idMunicipio = 146,
                    idDepartamento = 11,
                    nombre = "San Andrés"
                },
                new Municipio
                {
                    idMunicipio = 147,
                    idDepartamento = 11,
                    nombre = "San Benito"
                },
                new Municipio
                {
                    idMunicipio = 148,
                    idDepartamento = 11,
                    nombre = "San Francisco"
                },
                new Municipio
                {
                    idMunicipio = 149,
                    idDepartamento = 11,
                    nombre = "San José"
                },
                new Municipio
                {
                    idMunicipio = 150,
                    idDepartamento = 11,
                    nombre = "San Luis"
                },
                new Municipio
                {
                    idMunicipio = 151,
                    idDepartamento = 11,
                    nombre = "Santa Ana"
                },
                new Municipio
                {
                    idMunicipio = 152,
                    idDepartamento = 11,
                    nombre = "Sayaxché"
                },
                new Municipio
                {
                    idMunicipio = 153,
                    idDepartamento = 11,
                    nombre = "Las Cruces"
                },
                //municpios de quetzaltenango
                new Municipio
                {
                    idMunicipio = 154,
                    idDepartamento = 12,
                    nombre = "Almolonga"
                },
                new Municipio
                {
                    idMunicipio = 155,
                    idDepartamento = 12,
                    nombre = "Cabricán"
                },
                new Municipio
                {
                    idMunicipio = 156,
                    idDepartamento = 12,
                    nombre = "Cajolá"
                }, new Municipio
                {
                    idMunicipio = 157,
                    idDepartamento = 12,
                    nombre = "Cantel"
                },
                new Municipio
                {
                    idMunicipio = 158,
                    idDepartamento = 12,
                    nombre = "Coatepeque"
                },
                new Municipio
                {
                    idMunicipio = 159,
                    idDepartamento = 12,
                    nombre = "Colomba"
                },
                new Municipio
                {
                    idMunicipio = 160,
                    idDepartamento = 12,
                    nombre = "Concepción Chiquirichapa"
                },
                new Municipio
                {
                    idMunicipio = 161,
                    idDepartamento = 12,
                    nombre = "El Palmar"
                },
                new Municipio
                {
                    idMunicipio = 162,
                    idDepartamento = 12,
                    nombre = "Flores Costa Cuca"
                },
                new Municipio
                {
                    idMunicipio = 163,
                    idDepartamento = 12,
                    nombre = "Génova"
                },
                new Municipio
                {
                    idMunicipio = 164,
                    idDepartamento = 12,
                    nombre = "Huitán"
                },
                new Municipio
                {
                    idMunicipio = 165,
                    idDepartamento = 12,
                    nombre = "La Esperanza"
                },
                new Municipio
                {
                    idMunicipio = 166,
                    idDepartamento = 12,
                    nombre = "Olintepeque"
                },
                new Municipio
                {
                    idMunicipio = 167,
                    idDepartamento = 12,
                    nombre = "Ostuncalco"
                },
                new Municipio
                {
                    idMunicipio = 168,
                    idDepartamento = 12,
                    nombre = "Palestina de Los Altos"
                },
                new Municipio
                {
                    idMunicipio = 169,
                    idDepartamento = 12,
                    nombre = "Quetzaltenango"
                },
                new Municipio
                {
                    idMunicipio = 170,
                    idDepartamento = 12,
                    nombre = "Salcajá"
                },
                new Municipio
                {
                    idMunicipio = 171,
                    idDepartamento = 12,
                    nombre = "San Carlos Sija"
                },
                new Municipio
                {
                    idMunicipio = 172,
                    idDepartamento = 12,
                    nombre = "San Francisco La Unión"
                },
                new Municipio
                {
                    idMunicipio = 173,
                    idDepartamento = 12,
                    nombre = "San Martín Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 174,
                    idDepartamento = 12,
                    nombre = "San Mateo"
                },
                new Municipio
                {
                    idMunicipio = 175,
                    idDepartamento = 12,
                    nombre = "San Miguel Sigüilá"
                },
                new Municipio
                {
                    idMunicipio = 176,
                    idDepartamento = 12,
                    nombre = "Sibilia"
                },
                new Municipio
                {
                    idMunicipio = 177,
                    idDepartamento = 12,
                    nombre = "Zunil"
                },
                //municipios de QUICHE
                new Municipio
                {
                    idMunicipio = 178,
                    idDepartamento = 13,
                    nombre = "Canillá"
                },
                new Municipio
                {
                    idMunicipio = 179,
                    idDepartamento = 13,
                    nombre = "Chajul"
                },
                new Municipio
                {
                    idMunicipio = 180,
                    idDepartamento = 13,
                    nombre = "Chicamán"
                },
                new Municipio
                {
                    idMunicipio = 181,
                    idDepartamento = 13,
                    nombre = "Chiché"
                },
                new Municipio
                {
                    idMunicipio = 182,
                    idDepartamento = 13,
                    nombre = "Chichicastenango"
                },
                new Municipio
                {
                    idMunicipio = 183,
                    idDepartamento = 13,
                    nombre = "Chinique"
                },
                new Municipio
                {
                    idMunicipio = 184,
                    idDepartamento = 13,
                    nombre = "Cunén"
                },
                new Municipio
                {
                    idMunicipio = 185,
                    idDepartamento = 13,
                    nombre = "Ixcán"
                },
                new Municipio
                {
                    idMunicipio = 186,
                    idDepartamento = 13,
                    nombre = "Joyabaj"
                },
                new Municipio
                {
                    idMunicipio = 187,
                    idDepartamento = 13,
                    nombre = "Nebaj"
                },
                new Municipio
                {
                    idMunicipio = 188,
                    idDepartamento = 13,
                    nombre = "Pachalum"
                },
                new Municipio
                {
                    idMunicipio = 189,
                    idDepartamento = 13,
                    nombre = "Patzité"
                },
                new Municipio
                {
                    idMunicipio = 190,
                    idDepartamento = 13,
                    nombre = "Sacapulas"
                },
                new Municipio
                {
                    idMunicipio = 191,
                    idDepartamento = 13,
                    nombre = "San Andrés Sajcabajá"
                },
                new Municipio
                {
                    idMunicipio = 192,
                    idDepartamento = 13,
                    nombre = "San Antonio Ilotenango"
                },
                new Municipio
                {
                    idMunicipio = 193,
                    idDepartamento = 13,
                    nombre = "San Bartolomé Jocotenango"
                },
                new Municipio
                {
                    idMunicipio = 194,
                    idDepartamento = 13,
                    nombre = "San Juan Cotzal"
                },
                new Municipio
                {
                    idMunicipio = 195,
                    idDepartamento = 13,
                    nombre = "San Pedro Jocopilas"
                },
                new Municipio
                {
                    idMunicipio = 196,
                    idDepartamento = 13,
                    nombre = "Santa Cruz del Quiché"
                },
                new Municipio
                {
                    idMunicipio = 197,
                    idDepartamento = 13,
                    nombre = "Uspantán"
                },
                new Municipio
                {
                    idMunicipio = 198,
                    idDepartamento = 13,
                    nombre = "Zacualpa"
                },
                //Municipios de retalhuleu
                new Municipio
                {
                    idMunicipio = 199,
                    idDepartamento = 14,
                    nombre = "Champerico"
                },
                new Municipio
                {
                    idMunicipio = 200,
                    idDepartamento = 14,
                    nombre = "El Asintal"
                },
                new Municipio
                {
                    idMunicipio = 201,
                    idDepartamento = 14,
                    nombre = "Nuevo San Carlos"
                },
                new Municipio
                {
                    idMunicipio = 202,
                    idDepartamento = 14,
                    nombre = "Retalhuleu"
                },
                new Municipio
                {
                    idMunicipio = 203,
                    idDepartamento = 14,
                    nombre = "San Andrés Villa Seca"
                },
                new Municipio
                {
                    idMunicipio = 204,
                    idDepartamento = 14,
                    nombre = "San Felipe"
                },
                new Municipio
                {
                    idMunicipio = 205,
                    idDepartamento = 14,
                    nombre = "San Martín Zapotitlán"
                },
                new Municipio
                {
                    idMunicipio = 206,
                    idDepartamento = 14,
                    nombre = "San Sebastián"
                },
                new Municipio
                {
                    idMunicipio = 207,
                    idDepartamento = 14,
                    nombre = "Santa Cruz Muluá"
                },
                //Municipios de sacatepequez
                new Municipio
                {
                    idMunicipio = 208,
                    idDepartamento = 15,
                    nombre = "Alotenango"
                },
                new Municipio
                {
                    idMunicipio = 209,
                    idDepartamento = 15,
                    nombre = "Antigua"
                },
                new Municipio
                {
                    idMunicipio = 210,
                    idDepartamento = 15,
                    nombre = "Ciudad Vieja"
                },
                new Municipio
                {
                    idMunicipio = 211,
                    idDepartamento = 15,
                    nombre = "Jocotenango"
                },
                new Municipio
                {
                    idMunicipio = 212,
                    idDepartamento = 15,
                    nombre = "Magdalena Milpas Altas"
                },
                new Municipio
                {
                    idMunicipio = 213,
                    idDepartamento = 15,
                    nombre = "Pastores"
                },
                new Municipio
                {
                    idMunicipio = 214,
                    idDepartamento = 15,
                    nombre = "San Antonio Aguas Calientes"
                },
                new Municipio
                {
                    idMunicipio = 215,
                    idDepartamento = 15,
                    nombre = "San Bartolomé Milpas Altas"
                },
                new Municipio
                {
                    idMunicipio = 216,
                    idDepartamento = 15,
                    nombre = "San Lucas Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 217,
                    idDepartamento = 15,
                    nombre = "San Miguel Dueñas"
                },
                new Municipio
                {
                    idMunicipio = 218,
                    idDepartamento = 15,
                    nombre = "Santa Catarina Barahona"
                },
                new Municipio
                {
                    idMunicipio = 219,
                    idDepartamento = 15,
                    nombre = "Santa Lucía Milpas Altas"
                },
                new Municipio
                {
                    idMunicipio = 220,
                    idDepartamento = 15,
                    nombre = "Santa María de Jesús"
                },
                new Municipio
                {
                    idMunicipio = 221,
                    idDepartamento = 15,
                    nombre = "Santiago Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 222,
                    idDepartamento = 15,
                    nombre = "Santo Domingo Xenacoj"
                },
                new Municipio
                {
                    idMunicipio = 223,
                    idDepartamento = 15,
                    nombre = "Sumpango"
                },
                //Municipios de San Marcos
                new Municipio
                {
                    idMunicipio = 224,
                    idDepartamento = 16,
                    nombre = "Ayutla"
                },
                new Municipio
                {
                    idMunicipio = 225,
                    idDepartamento = 16,
                    nombre = "Catarina"
                },
                new Municipio
                {
                    idMunicipio = 226,
                    idDepartamento = 16,
                    nombre = "Comitancillo"
                },
                new Municipio
                {
                    idMunicipio = 227,
                    idDepartamento = 16,
                    nombre = "Concepción Tutuapa"
                },
                new Municipio
                {
                    idMunicipio = 228,
                    idDepartamento = 16,
                    nombre = "El Quetzal"
                },
                new Municipio
                {
                    idMunicipio = 229,
                    idDepartamento = 16,
                    nombre = "El Rodeo"
                },
                new Municipio
                {
                    idMunicipio = 230,
                    idDepartamento = 16,
                    nombre = "El Tumbador"
                },
                new Municipio
                {
                    idMunicipio = 231,
                    idDepartamento = 16,
                    nombre = "Esquipulas Palo Gordo"
                },
                new Municipio
                {
                    idMunicipio = 232,
                    idDepartamento = 16,
                    nombre = "Ixchiguan"
                },
                new Municipio
                {
                    idMunicipio = 233,
                    idDepartamento = 16,
                    nombre = "La Reforma"
                },
                new Municipio
                {
                    idMunicipio = 234,
                    idDepartamento = 16,
                    nombre = "Malacatán"
                },
                new Municipio
                {
                    idMunicipio = 235,
                    idDepartamento = 16,
                    nombre = "Nuevo Progreso"
                },
                new Municipio
                {
                    idMunicipio = 236,
                    idDepartamento = 16,
                    nombre = "Ocos"
                },
                new Municipio
                {
                    idMunicipio = 237,
                    idDepartamento = 16,
                    nombre = "Pajapita"
                },
                new Municipio
                {
                    idMunicipio = 238,
                    idDepartamento = 16,
                    nombre = "Río Blanco"
                },
                new Municipio
                {
                    idMunicipio = 239,
                    idDepartamento = 16,
                    nombre = "San Antonio Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 240,
                    idDepartamento = 16,
                    nombre = "San Cristóbal Cucho"
                },
                new Municipio
                {
                    idMunicipio = 241,
                    idDepartamento = 16,
                    nombre = "San José Ojetenam"
                },
                new Municipio
                {
                    idMunicipio = 242,
                    idDepartamento = 16,
                    nombre = "San Lorenzo"
                },
                new Municipio
                {
                    idMunicipio = 243,
                    idDepartamento = 16,
                    nombre = "San Marcos"
                },
                new Municipio
                {
                    idMunicipio = 244,
                    idDepartamento = 16,
                    nombre = "San Miguel Ixtahuacán"
                },
                new Municipio
                {
                    idMunicipio = 245,
                    idDepartamento = 16,
                    nombre = "San Pablo"
                },
                new Municipio
                {
                    idMunicipio = 246,
                    idDepartamento = 16,
                    nombre = "San Pedro Sacatepéquez"
                },
                new Municipio
                {
                    idMunicipio = 247,
                    idDepartamento = 16,
                    nombre = "San Rafael Pie de La Cuesta"
                },
                new Municipio
                {
                    idMunicipio = 248,
                    idDepartamento = 16,
                    nombre = "San Sibinal"
                },
                new Municipio
                {
                    idMunicipio = 249,
                    idDepartamento = 16,
                    nombre = "Sipacapa"
                },
                new Municipio
                {
                    idMunicipio = 250,
                    idDepartamento = 16,
                    nombre = "Tacaná"
                },
                new Municipio
                {
                    idMunicipio = 251,
                    idDepartamento = 16,
                    nombre = "Tajumulco"
                },
                new Municipio
                {
                    idMunicipio = 252,
                    idDepartamento = 16,
                    nombre = "Tejutla"
                },
                //municpios de Santa Rosa
                new Municipio
                {
                    idMunicipio = 253,
                    idDepartamento = 17,
                    nombre = "Barberena"
                },
                new Municipio
                {
                    idMunicipio = 254,
                    idDepartamento = 17,
                    nombre = "Casillas"
                },
                new Municipio
                {
                    idMunicipio = 255,
                    idDepartamento = 17,
                    nombre = "Chiquimulilla"
                },
                new Municipio
                {
                    idMunicipio = 256,
                    idDepartamento = 17,
                    nombre = "Cuilapa"
                },
                new Municipio
                {
                    idMunicipio = 257,
                    idDepartamento = 17,
                    nombre = "Guazacapán"
                },
                new Municipio
                {
                    idMunicipio = 258,
                    idDepartamento = 17,
                    nombre = "Nueva Santa Rosa"
                },
                new Municipio
                {
                    idMunicipio = 259,
                    idDepartamento = 17,
                    nombre = "Oratorio"
                },
                new Municipio
                {
                    idMunicipio = 260,
                    idDepartamento = 17,
                    nombre = "Pueblo Nuevo Viñas"
                },
                new Municipio
                {
                    idMunicipio = 261,
                    idDepartamento = 17,
                    nombre = "San Juan Tecuaco"
                },
                new Municipio
                {
                    idMunicipio = 262,
                    idDepartamento = 17,
                    nombre = "San Rafael Las Flores"
                },
                new Municipio
                {
                    idMunicipio = 263,
                    idDepartamento = 17,
                    nombre = "Santa Cruz Naranjo"
                },
                new Municipio
                {
                    idMunicipio = 264,
                    idDepartamento = 17,
                    nombre = "Santa María Ixhuatán"
                },
                new Municipio
                {
                    idMunicipio = 265,
                    idDepartamento = 17,
                    nombre = "Santa Rosa de Lima"
                },
                new Municipio
                {
                    idMunicipio = 266,
                    idDepartamento = 17,
                    nombre = "Taxisco"
                },
                //Municpios de solola
                new Municipio
                {
                    idMunicipio = 267,
                    idDepartamento = 18,
                    nombre = "Concepción"
                },
                new Municipio
                {
                    idMunicipio = 268,
                    idDepartamento = 18,
                    nombre = "Nahualá"
                },
                new Municipio
                {
                    idMunicipio = 269,
                    idDepartamento = 18,
                    nombre = "Panajachel"
                },
                new Municipio
                {
                    idMunicipio = 270,
                    idDepartamento = 18,
                    nombre = "San Andrés Semetabaj"
                },
                new Municipio
                {
                    idMunicipio = 271,
                    idDepartamento = 18,
                    nombre = "San Antonio Palopó"
                },
                new Municipio
                {
                    idMunicipio = 272,
                    idDepartamento = 18,
                    nombre = "San José Chacaya"
                },
                new Municipio
                {
                    idMunicipio = 273,
                    idDepartamento = 18,
                    nombre = "San Juan La Laguna"
                },
                new Municipio
                {
                    idMunicipio = 274,
                    idDepartamento = 18,
                    nombre = "San Lucas Tolimán"
                },
                new Municipio
                {
                    idMunicipio = 275,
                    idDepartamento = 18,
                    nombre = "San Marcos La Laguna"
                },
                new Municipio
                {
                    idMunicipio = 276,
                    idDepartamento = 18,
                    nombre = "San Pablo La Laguna"
                },
                new Municipio
                {
                    idMunicipio = 277,
                    idDepartamento = 18,
                    nombre = "San Pedro La Laguna"
                },
                new Municipio
                {
                    idMunicipio = 278,
                    idDepartamento = 18,
                    nombre = "Santa Catarina Ixtahuacan"
                },
                new Municipio
                {
                    idMunicipio = 279,
                    idDepartamento = 18,
                    nombre = "Santa Catarina Palopó"
                },
                new Municipio
                {
                    idMunicipio = 280,
                    idDepartamento = 18,
                    nombre = "Santa Clara La Laguna"
                },
                new Municipio
                {
                    idMunicipio = 281,
                    idDepartamento = 18,
                    nombre = "Santa Cruz La Laguna"
                },
                new Municipio
                {
                    idMunicipio = 282,
                    idDepartamento = 18,
                    nombre = "Santa Lucía Utatlán"
                },
                new Municipio
                {
                    idMunicipio = 283,
                    idDepartamento = 18,
                    nombre = "Santa María Visitación"
                },
                new Municipio
                {
                    idMunicipio = 284,
                    idDepartamento = 18,
                    nombre = "Santiago Atitlán"
                },
                new Municipio
                {
                    idMunicipio = 285,
                    idDepartamento = 18,
                    nombre = "Sololá"
                },
                //Municipios de Suchitepequez
                new Municipio
                {
                    idMunicipio = 286,
                    idDepartamento = 19,
                    nombre = "Chicacao"
                },
                new Municipio
                {
                    idMunicipio = 287,
                    idDepartamento = 19,
                    nombre = "Cuyotenango"
                },
                new Municipio
                {
                    idMunicipio = 288,
                    idDepartamento = 19,
                    nombre = "Mazatenango"
                },
                new Municipio
                {
                    idMunicipio = 289,
                    idDepartamento = 19,
                    nombre = "Patulul"
                },
                new Municipio
                {
                    idMunicipio = 290,
                    idDepartamento = 19,
                    nombre = "Pueblo Nuevo"
                },
                new Municipio
                {
                    idMunicipio = 291,
                    idDepartamento = 19,
                    nombre = "Río Bravo"
                },
                new Municipio
                {
                    idMunicipio = 292,
                    idDepartamento = 19,
                    nombre = "Samayac"
                },
                new Municipio
                {
                    idMunicipio = 293,
                    idDepartamento = 19,
                    nombre = "San Antonio Suchitepéquez"
                },
                new Municipio
                {
                    idMunicipio = 294,
                    idDepartamento = 19,
                    nombre = "San Bernardino"
                },
                new Municipio
                {
                    idMunicipio = 295,
                    idDepartamento = 19,
                    nombre = "San Francisco Zapotitlán"
                },
                new Municipio
                {
                    idMunicipio = 296,
                    idDepartamento = 19,
                    nombre = "San Gabriel"
                },
                new Municipio
                {
                    idMunicipio = 297,
                    idDepartamento = 19,
                    nombre = "San José El Idolo"
                },
                new Municipio
                {
                    idMunicipio = 298,
                    idDepartamento = 19,
                    nombre = "San Juan Bautista"
                },
                new Municipio
                {
                    idMunicipio = 299,
                    idDepartamento = 19,
                    nombre = "San Lorenzo"
                },
                new Municipio
                {
                    idMunicipio = 300,
                    idDepartamento = 19,
                    nombre = "San Miguel Panán"
                },
                new Municipio
                {
                    idMunicipio = 301,
                    idDepartamento = 19,
                    nombre = "San Pablo Jocopilas"
                },
                new Municipio
                {
                    idMunicipio = 302,
                    idDepartamento = 19,
                    nombre = "Santa Bárbara"
                },
                new Municipio
                {
                    idMunicipio = 303,
                    idDepartamento = 19,
                    nombre = "Santo Domingo Suchitepequez"
                },
                new Municipio
                {
                    idMunicipio = 304,
                    idDepartamento = 19,
                    nombre = "Santo Tomas La Unión"
                },
                new Municipio
                {
                    idMunicipio = 305,
                    idDepartamento = 19,
                    nombre = "Zunilito"
                },
                //Municipios de Totonicapan
                new Municipio
                {
                    idMunicipio = 306,
                    idDepartamento = 20,
                    nombre = "Momostenango"
                },
                new Municipio
                {
                    idMunicipio = 307,
                    idDepartamento = 20,
                    nombre = "San Andrés Xecul"
                },
                new Municipio
                {
                    idMunicipio = 308,
                    idDepartamento = 20,
                    nombre = "San Bartolo"
                },
                new Municipio
                {
                    idMunicipio = 309,
                    idDepartamento = 20,
                    nombre = "San Cristóbal Totonicapán"
                },
                new Municipio
                {
                    idMunicipio = 310,
                    idDepartamento = 20,
                    nombre = "San Francisco El Alto"
                },
                new Municipio
                {
                    idMunicipio = 311,
                    idDepartamento = 20,
                    nombre = "Santa Lucía La Reforma"
                },
                new Municipio
                {
                    idMunicipio = 312,
                    idDepartamento = 20,
                    nombre = "Santa María Chiquimula"
                },
                new Municipio
                {
                    idMunicipio = 313,
                    idDepartamento = 20,
                    nombre = "Totonicapán"
                },
                new Municipio
                {
                    idMunicipio = 314,
                    idDepartamento = 20,
                    nombre = "San"
                },
                //municipios de Zacapa
                new Municipio
                {
                    idMunicipio = 315,
                    idDepartamento = 21,
                    nombre = "Cabañas"
                },
                new Municipio
                {
                    idMunicipio = 316,
                    idDepartamento = 21,
                    nombre = "Estanzuela"
                },
                new Municipio
                {
                    idMunicipio = 317,
                    idDepartamento = 21,
                    nombre = "Gualán"
                },
                new Municipio
                {
                    idMunicipio = 318,
                    idDepartamento = 21,
                    nombre = "Huité"
                },
                new Municipio
                {
                    idMunicipio = 319,
                    idDepartamento = 21,
                    nombre = "La Unión"
                },
                new Municipio
                {
                    idMunicipio = 320,
                    idDepartamento = 21,
                    nombre = "Río Hondo"
                },
                new Municipio
                {
                    idMunicipio = 321,
                    idDepartamento = 21,
                    nombre = "San Diego"
                },
                new Municipio
                {
                    idMunicipio = 322,
                    idDepartamento = 21,
                    nombre = "Teculután"
                },
                new Municipio
                {
                    idMunicipio = 323,
                    idDepartamento = 21,
                    nombre = "Usumatlán"
                },
                new Municipio
                {
                    idMunicipio = 324,
                    idDepartamento = 21,
                    nombre = "Zacapa"
                },
                //municpios de Jalapa
                new Municipio
                {
                    idMunicipio = 325,
                    idDepartamento = 22,
                    nombre = "Jalapa"
                }, new Municipio
                {
                    idMunicipio = 326,
                    idDepartamento = 22,
                    nombre = "Mataquescuintla"
                },
                new Municipio
                {
                    idMunicipio = 327,
                    idDepartamento = 22,
                    nombre = "Monjas"
                },
                new Municipio
                {
                    idMunicipio = 328,
                    idDepartamento = 22,
                    nombre = "San Carlos Alzatate"
                },
                new Municipio
                {
                    idMunicipio = 329,
                    idDepartamento = 22,
                    nombre = "San Luis Jilotepeque"
                },
                new Municipio
                {
                    idMunicipio = 330,
                    idDepartamento = 22,
                    nombre = "San Pedro Pinula"
                },
                new Municipio
                {
                    idMunicipio = 331,
                    idDepartamento = 22,
                    nombre = "San Manuel Chaparrón"
                },
                new Municipio
                {
                    idMunicipio = 332,
                    idDepartamento = 5,
                    nombre = "Sansare"
                },
                new Municipio
                {
                    idMunicipio = 333,
                    idDepartamento = 6,
                    nombre = "Guanagazapa"
                },
                new Municipio
                {
                    idMunicipio = 334,
                    idDepartamento = 6,
                    nombre = "Sipacate"
                },
                new Municipio
                {
                    idMunicipio = 335,
                    idDepartamento = 7,
                    nombre = "Villa Nueva"
                },
                new Municipio
                {
                    idMunicipio = 336,
                    idDepartamento = 8,
                    nombre = "Petatán"
                },
                new Municipio
                {
                    idMunicipio = 337,
                    idDepartamento = 8,
                    nombre = "San Ildefonso Ixtahuacán"
                },
                new Municipio
                {
                    idMunicipio = 338,
                    idDepartamento = 11,
                    nombre = "El Chal"
                },
                new Municipio
                {
                    idMunicipio = 339,
                    idDepartamento = 16,
                    nombre = "La Blanca"
                },
                new Municipio
                {
                    idMunicipio = 340,
                    idDepartamento = 19,
                    nombre = "San José La Máquina"
                }

            );
        }
    }
}
