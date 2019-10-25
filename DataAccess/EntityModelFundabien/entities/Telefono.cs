using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Telefono
    {
        [Key]
        public Int64 idTelefono { get; set; }
        [Required]
        public Int64 idPersona { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "El campo 'telefono' de 'Telefono' no debe exceder 8 caracteres.")]
        public string telefono { get; set; }
        [Required]
        public DateTime fechaRegistro { get; set; }
        [Required]
        public bool estaHabilitado { get; set; }
        
        public Persona persona { get; set; }
    }
}
