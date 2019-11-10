using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class EstudioSocioeconomicoDTO
    {
        public long Id { get; set; }
        
        public long idPaciente { get; set; }
        
        public DateTime fechaEntrevista { get; set; }
        
        public string motivoSolicitud { get; set; }
        
        public string diagnosticoSocial { get; set; }
        
        public string opinionTS { get; set; }
        
        public string observaciones { get; set; }
    }
}
