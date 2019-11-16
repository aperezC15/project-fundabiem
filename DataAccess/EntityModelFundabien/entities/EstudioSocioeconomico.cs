using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class EstudioSocioeconomico
    {
        public long Id { get; set; }
        [Required]
        public long idPaciente { get; set; }
        [Required]
        public DateTime fechaEntrevista { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "El campo 'motivoSolicitud' de 'EstudioSocioeconomico' no debe exceder de 5000 caracteres.")]
        public string motivoSolicitud { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "El campo 'diagnosticoSocial' de 'EstudioSocioeconomico' no debe exceder de 5000 caracteres.")]
        public string diagnosticoSocial { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "El campo 'opinionTS' de 'EstudioSocioeconomico' no debe exceder de 5000 caracteres.")]
        public string opinionTS { get; set; }
        [StringLength(5000, ErrorMessage = "El campo 'observaciones' de 'EstudioSocioeconomico' no debe exceder de 5000 caracteres.")]
        public string observaciones { get; set; }

        public ICollection<GrupoFamiliar> grupoFamiliar { get; set; }
        public ICollection<EvaluacionEstudioSocioeconomico> evaluacion { get; set; }
        public Paciente paciente { get; set; }
    }
}
