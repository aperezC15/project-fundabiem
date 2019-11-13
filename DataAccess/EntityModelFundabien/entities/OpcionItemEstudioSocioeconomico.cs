using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class OpcionItemEstudioSocioeconomico
    {
        public long Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El campo 'nombre' de 'OpcionItemEstudioSocioeconomico' no debe exceder de 100 caracteres.")]
        public string nombre { get; set; }
        [Required]
        public long ItemEstudioSocioeconomicoId { get; set; }

        public ItemEstudioSocioeconomico item { get; set; }
        public ICollection<EvaluacionEstudioSocioeconomico> evaluaciones { get; set; }
    }
}
