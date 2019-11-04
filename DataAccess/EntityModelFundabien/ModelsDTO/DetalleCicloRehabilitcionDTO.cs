using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class DetalleCicloRehabilitcionDTO
    {
        [Required]
        public Int64 idObjetivo { get; set; }
        public bool intervencion { get; set; }
        public bool TF { get; set; }
        public bool TO { get; set; }
        public bool TL { get; set; }
        public bool PS { get; set; }
        public bool TS { get; set; }
        public bool EE { get; set; }
        public bool valoracionInicial { get; set; }
        public bool valoracionObjetivo { get; set; }
        public bool valoracionFinal { get; set; }
    }
}
