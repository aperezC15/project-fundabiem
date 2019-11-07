using EntityModelFundabien.ModelsDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class EvolucionMedica
    {
        [Key]
        public Int64 idEvolucionMedica { get; set; }
        [Required]
        public Int64 idPaciente { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "El campo 'diagnostico' de 'EvolucionMedica' no debe exceder 5000 caracteres.")]
        public string diagnostico { get; set; }
        [Required]
        public DateTime fecha { get; set; }

        public Paciente paciente { get; set; }
    }

    public class DTOEvolucionMedica
    {
        public Int64 idEvolucionMedica { get; set; }
        [Required]
        public Int64 idPaciente { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "El campo 'diagnostico' de 'EvolucionMedica' no debe exceder 5000 caracteres.")]
        public string diagnostico { get; set; }
        [Required]
        public DateTime fecha { get; set; }

        public  pacienteDTO paciente { get; set; }

    }
}
