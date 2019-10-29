using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Paciente
    {
        [Key]
        public Int64 idPaciente { get; set; }
        [Required]
        public Int64 historialClinico { get; set; }
        [Required]
        public Int64 idPersona { get; set; }
        [Required]
        public bool estaActivo { get; set; }

        public Persona persona { get; set; }
        public IList<RegistroMedico> registrosMedicos { get; set; }
        public IList<EvolucionMedica> evolucionesMedicas { get; set; }
    }
}
