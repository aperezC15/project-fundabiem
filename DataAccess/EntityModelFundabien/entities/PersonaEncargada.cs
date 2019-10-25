using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class PersonaEncargada
    {
        [Key]
        public Int64 idPersonaEncargada { get; set; }
        [Required]
        public Int64 idPaciente { get; set; }
        [Required]
        public Int64 idPersona { get; set; }
        [Required]
        public bool estaActivo { get; set; }
        public Persona persona { get; set; }
        public Paciente paciente { get; set; }
    }
}
