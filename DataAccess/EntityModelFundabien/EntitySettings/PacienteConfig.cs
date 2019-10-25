using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.EntitySettings
{
    public static class PacienteConfiguration
    {
        public static void PacienteConfig(this ModelBuilder modelBuider)
        {
            modelBuider.Entity<Paciente>()
                .HasAlternateKey(paciente => paciente.historialClinico);
        }
    }
}
