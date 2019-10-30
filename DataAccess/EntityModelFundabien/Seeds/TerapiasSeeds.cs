using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public static class TerapiasSeeds
    {
        public static void TerapiasSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Terapias>().HasData(
                new Terapias
                {
                    IdTerapia = 1,
                    Nombre = "FT",
                    Descripcion= "fisioterapia",
                    Encargado = "16e7295d-662e-440e-9e55-bb0680f8e9a0"
                },
                new Terapias
                {
                    IdTerapia = 2,
                    Nombre = "TO",
                    Descripcion = "Terapia Ocupacional",
                    Encargado = "21859333-eefc-4a3b-914e-0884df0d2ca0"
                },
                new Terapias
                {
                    IdTerapia = 3,
                    Nombre = "TL",
                    Descripcion = "Terapia de Lenguaje",
                    Encargado = "7af9189d-e12f-4d9e-b4f0-44e4fdba0790"
                },
                new Terapias
                {
                    IdTerapia = 4,
                    Nombre = "TS",
                    Descripcion = "Terapia Social",
                    Encargado = "332f07fc-0e28-4e9c-866c-d8ced8eba9a6"
                },
                new Terapias
                {
                    IdTerapia = 5,
                    Nombre = "PSCI",
                    Descripcion = "Terapia Psicologica",
                    Encargado = "eb1794b8-42b4-4ede-bba2-2d7073671eea"
                },
                new Terapias
                {
                    IdTerapia = 6,
                    Nombre = "IREX",
                    Descripcion = "Terapia Virtual",
                    Encargado = "79c300f9-46da-476f-830b-a1f74e02ad27"
                },
                new Terapias
                {
                    IdTerapia = 7,
                    Nombre = "MT",
                    Descripcion = "MecanoTerapia",
                    Encargado = "6e3516cd-1688-45a7-b9ce-1e4e8cfe2c09"
                },
                new Terapias
                {
                    IdTerapia = 8,
                    Nombre = "CEMS",
                    Descripcion = "Cuarto de estimulación Sensorial",
                    Encargado = "e1f3b398-54a7-493a-adfa-11329a459e91"
                }
            );
        }
    }
}
