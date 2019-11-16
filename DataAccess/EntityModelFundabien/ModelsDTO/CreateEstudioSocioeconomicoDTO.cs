using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateEstudioSocioeconomicoDTO
    {
        [Required]
        public long idPaciente { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'entrevistadorTS' de 'EstudioSocioeconomico' no debe exceder de 100 caracteres.")]
        public string entrevistadorTS { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'evaluador' de 'EstudioSocioeconomico' no debe exceder de 100 caracteres.")]
        public string evaluador { get; set; }
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
        [Required]
        public ICollection<CreateGrupoFamiliarDTO> grupoFamiliar { get; set; }
        [Required]
        public ICollection<CreateEvaluacionEstudioSocioeconomicoDTO> evaluacion { get; set; }
        [Required]
        public ICollection<CreateTerapiaEstudioSocioeconomicoDTO> terapias { get; set; }
    }
}
