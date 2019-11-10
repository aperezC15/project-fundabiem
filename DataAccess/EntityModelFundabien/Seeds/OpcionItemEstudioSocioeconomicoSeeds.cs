using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public static class OpcionItemEstudioSocioeconomicoSeeds
    {
        public static void seedOpcionesItemEstudioSocioeconomico(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OpcionItemEstudioSocioeconomico>().HasData(
                new OpcionItemEstudioSocioeconomico
                {
                    Id = 1,
                    ItemEstudioSocioeconomicoId = 1,
                    nombre = "Block"
                },
                new OpcionItemEstudioSocioeconomico
                {
                    Id = 2,
                    ItemEstudioSocioeconomicoId = 1,
                    nombre = "Madera"
                },
                new OpcionItemEstudioSocioeconomico
                {
                    Id = 3,
                    ItemEstudioSocioeconomicoId = 1,
                    nombre = "Nylon"
                }
            );
        }
    }
}
