using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.Seeds
{
    public  static class EstadoCitaSeeds
    {
        public static void EstadoCitaSedds(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstadoCitas>().HasData(
                new EstadoCitas
                {
                    idEstado =1,
                    nombre ="Asistencia",
                    descripcion="Para indicar que el paciente asistio a su cita"
                },
                new EstadoCitas
                {
                    idEstado = 2,
                    nombre = "Inasistencia",
                    descripcion = "Para indicar que el paciente no asistio a su cita"
                },
                new EstadoCitas
                {
                    idEstado = 3,
                    nombre = "Permiso",
                    descripcion = "Para marcar que el paciente solicito Permiso a no asistir a su cita"
                },
                new EstadoCitas
                {
                    idEstado = 4,
                    nombre = "Cancelada",
                    descripcion = "Para indicar que la cita fue cancelada"  
                }
            );
        }
    }
}
