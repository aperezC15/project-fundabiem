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
        public Int64 idPaciente { get; set; }
        public Int64 idPersona { get; set; }
        public string parentezco { get; set; }
        public bool estaActivo { get; set; }

        public Persona persona { get; set; }
        public Paciente paciente { get; set; }
    }
}
