using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class EvaluacionEstudioSocioeconomico
    {
        public long Id { get; set; }
        [Required]
        public long EstudioSocioeconomicoId { get; set; }
        
        [Required]
        public long OpcionItemEstudioSocioeconomicoId { get; set; }

        public EstudioSocioeconomico estudioSocioeconomico { get; set; }
        
        public OpcionItemEstudioSocioeconomico opcion { get; set; }
    }
}
