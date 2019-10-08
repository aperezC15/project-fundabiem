using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
                    idMunicipio=1,
                    idDepartamento=1,
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
                    idMunicipio = 27,
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
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "El Tejar"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Parramos"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Patzicía"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Patzún"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Pochuta"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "San Andrés Itzapa"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "San José Poaquil"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "San Juan Comalapa"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "San Martín Jilotepeque"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Santa Apolonia"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Santa Cruz Balanyá"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Tecpán Guatemala"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Yepocapa"
                },
                new Municipio
                {
                    idMunicipio = 27,
                    idDepartamento = 3,
                    nombre = "Zaragoza"
                }
                
            );
        }
    }
}
