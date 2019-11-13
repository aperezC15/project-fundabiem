using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public static class ItemEstudioSocioeconomicoSeeds
    {
        public static void seedItemEstudioSocioeconomico(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemEstudioSocioeconomico>().HasData(
                new ItemEstudioSocioeconomico
                {
                    Id = 1,
                    nombre = "Paredes",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 2,
                    nombre = "Techo",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 3,
                    nombre = "Pisos",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 4,
                    nombre = "No. de habitaciones",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 5,
                    nombre = "Agua",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 6,
                    nombre = "Luz eléctrica",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 7,
                    nombre = "Servicio sanitario",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 8,
                    nombre = "Letrina",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 9,
                    nombre = "Otros",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 10,
                    nombre = "La cocina está fuera del dormitorio",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 11,
                    nombre = "Vivienda",
                    SeccionEstudioSocioeconomicoId = 1
                },
                new ItemEstudioSocioeconomico
                {
                    Id = 12,
                    nombre = "Pago mensual de vivienda",
                    SeccionEstudioSocioeconomicoId = 1
                }
            );
        }
    }
}
