using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.EntitySettings
{
    public static class PersonaConfiguration
    {
        public static void PersonaConfig(this ModelBuilder modelBuider)
        {
            modelBuider.Entity<Persona>()
                .HasAlternateKey(persona => persona.dpi);
        }
    }
}
