using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class TerapiaEstudioSocioeconomico
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public long EstudioSocioeconomicoId { get; set; }
        [Required]
        public long IdTerapia { get; set; }

        public EstudioSocioeconomico estudioSocioeconomico { get; set; }
        public Terapias terapia { get; set; }
    }
}
