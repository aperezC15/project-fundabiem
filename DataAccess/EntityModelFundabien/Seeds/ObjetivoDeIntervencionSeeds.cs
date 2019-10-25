using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public static class ObjetivoDeIntervencionSeeds
    {
        public static void ObjetivoDeIntervencionSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObjetivoDeIntervencion>().HasData(
               new ObjetivoDeIntervencion
               {
                    idObjetivo = 1,
                    nombre="Funciones y Estructuras Corporales",
                    descripcion="Describe funciones y estructuras corporales del paciente"
               },
               new ObjetivoDeIntervencion
               {
                    idObjetivo = 2,
                    nombre = "Actividad y Participacion",
                    descripcion = "Describe Actividad y Participacion del paciente"
                },
                new ObjetivoDeIntervencion
                {
                    idObjetivo = 3,
                    nombre = "Factores Ambientales",
                    descripcion = "Describe Factores Ambientales del paciente"
                }
            );

        }
    }
}
