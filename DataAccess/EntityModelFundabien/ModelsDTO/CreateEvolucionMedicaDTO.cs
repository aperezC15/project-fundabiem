using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateEvolucionMedicaDTO
    {
        [Required]
        public Int64 idPaciente { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "El campo 'diagnostico' de 'EvolucionMedica' no debe exceder 5000 caracteres.")]
        public string diagnostico { get; set; }
        [Required]
        public DateTime fecha { get; set; }
    }
}
