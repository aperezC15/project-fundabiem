using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateEvaluacionEstudioSocioeconomicoDTO
    {
        [Required]
        public long ItemEstudioSocioeconomicoId { get; set; }
        [Required]
        public long OpcionItemEstudioSocioeconomicoId { get; set; }
    }
}
