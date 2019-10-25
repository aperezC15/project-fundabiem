using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Persona
    {
        [Key]
        public Int64 idPersona { get; set; }
        [Required]
        [MaxLength(13, ErrorMessage = "El campo 'dpi' de 'Persona' no debe exceder 13 caracteres.")]
        public string dpi { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "El campo 'primerNombre' de 'Persona' no debe exceder 25 caracteres.")]
        public string primerNombre { get; set; }
        [MaxLength(25, ErrorMessage = "El campo 'segundoNombre' de 'Persona' no debe exceder 25 caracteres.")]
        public string segundoNombre { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "El campo 'primerApellido' de 'Persona' no debe exceder 25 caracteres.")]
        public string primerApellido { get; set; }
        [MaxLength(25, ErrorMessage = "El campo 'segundoApellido' de 'Persona' no debe exceder 25 caracteres.")]
        public string segundoApellido { get; set; }
        [Required]
        public bool sexo { get; set; }
        [Required]
        public DateTime fechaNacimiento { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'grupoEtnico' de 'Persona' no debe exceder 100 caracteres.")]
        public string grupoEtnico { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'escolaridad' de 'Persona' no debe exceder 100 caracteres.")]
        public string escolaridad { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'religion' de 'Persona' no debe exceder 100 caracteres.")]
        public string religion { get; set; }
    }
}
