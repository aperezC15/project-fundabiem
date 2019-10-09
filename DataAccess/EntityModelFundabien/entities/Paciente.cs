using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Paciente
    {
        [Key]
        public double idPaciente { get; set; }
        public double historialClinico { get; set; }
        public double idPersona { get; set; }
        public bool estaActivo { get; set; }

        public Persona persona { get; set; }
    }
}
