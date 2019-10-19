using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public static class SeccionesAnamnesisSeeds
    {
        public static void seddSeccionesAnamnesis(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeccionAnamnesis>().HasData(
                new SeccionAnamnesis
                {
                    idSeccionAnamnesis = 1,
                    nombre = "Antecedentes familiares",
                    descripcion = ""
                },
                new SeccionAnamnesis
                {
                    idSeccionAnamnesis = 2,
                    nombre = "Antecedentes médicos",
                    descripcion = ""
                },
                new SeccionAnamnesis
                {
                    idSeccionAnamnesis = 3,
                    nombre = "Periodo neonatal",
                    descripcion = ""
                },
                new SeccionAnamnesis
                {
                    idSeccionAnamnesis = 4,
                    nombre = "Desarrollo",
                    descripcion = ""
                }
            );
        }
    }
}
