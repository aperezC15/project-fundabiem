using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateGrupoFamiliarDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'Nombre' de 'GrupoFamiliar' no debe exceder de 100 caracteres.")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El campo 'EstadoCivil' de 'GrupoFamiliar' no debe exceder de 50 caracteres.")]
        public string EstadoCivil { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'Parentezco' de 'GrupoFamiliar' no debe exceder de 100 caracteres.")]
        public string Parentezco { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'Escolaridad' de 'GrupoFamiliar' no debe exceder de 100 caracteres.")]
        public string Escolaridad { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'Ocupacion' de 'GrupoFamiliar' no debe exceder de 100 caracteres.")]
        public string Ocupacion { get; set; }
        [Required]
        public float salario { get; set; }
    }
}
