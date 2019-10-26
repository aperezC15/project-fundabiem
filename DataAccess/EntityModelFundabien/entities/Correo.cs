using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Correo
    {
        [Key]
        public Int64 idCorreo { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo 'correo' de 'Correo' no debe exceder 50 caracteres.")]
        public string  correo { get; set; }
        [Required]
        public DateTime fechaRegistro { get; set; }
        [Required]
        public bool estaHabilitado { get; set; }

        public Persona persona { get; set; }
    }
}
