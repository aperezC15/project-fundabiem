using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class PersonaEncargada
    {
        [Key]
        public double idPersonaEncargada { get; set; }
        public double idPaciente { get; set; }
        public double idPersona { get; set; }
        public string parentezco { get; set; }
        public bool estaActivo { get; set; }

        public Persona persona { get; set; }
        public Paciente paciente { get; set; }
    }
}
