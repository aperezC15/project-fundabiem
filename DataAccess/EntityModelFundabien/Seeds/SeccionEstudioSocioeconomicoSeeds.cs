using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public static class SeccionEstudioSocioeconomicoSeeds
    {
        public static void seedSeccionEstudioSocioeconomico(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeccionEstudioSocioeconomico>().HasData(
                new SeccionEstudioSocioeconomico
                {
                    Id = 1,
                    nombre = "Vivienda"
                }
            );
        }
    }
}
