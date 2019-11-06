using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateCicloRehabilitacionDTO
    {
        [Required(ErrorMessage ="El idPaciente es requerido")]
        public Int64 idPaciente { get; set; }
        public string dignostico { get; set; }
        public string origen { get; set; }
        public string cie_10 { get; set; }
        public string otros { get; set; }
        public DateTime fecha { get; set; }
        public string funcionEstrucCorporales { get; set; }
        public string actividad { get; set; }
        public string participacion { get; set; }
        public string factoresAmbientales { get; set; }
        public string factoresPersonales { get; set; }
        public List<DetalleCicloRehabilitcionDTO> detalleCicloRehabilitacion { get; set; }
    }
}
