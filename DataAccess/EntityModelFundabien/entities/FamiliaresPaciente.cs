using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class FamiliaresPaciente
    {
        public Int64 id { get; set; }
        [Required]
        public Int64 idPersona { get; set; }
        [Required]
        public Int64 idPaciente { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "El campo 'parentezco' de 'FamiliaresPaciente' no debe exceder 100 caracteres.")]
        public string parentezco { get; set; }
        public Persona persona { get; set; }
    }
}
